using FireflyAlgorithm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSPFirefly
{
    public partial class TSPFirefly : Form
    {
        public TSPFirefly()
        {
            InitializeComponent();
            Cities = new List<City>();        
            Solution = new List<City>();
            indexes = new List<int>();

        }


        List<City> Solution; //Found Path
        Fireflies firefly;
        List<City> Cities; //List of TSP cities
        List<int> indexes; //List with optimal tour (taken from file)
        int n = 1;
        int length;
        string path = string.Empty;
        string name_of_tsp = string.Empty;//TSP name
        string[] comments = new string[3]; //Array of TSP comments
        int session_sum = 0; //Sum of all paths per session, used when calculating the average value
        int session_n = 0; //Number of search runs per session
        int session_min = int.MaxValue; //Minimum path per session
        
        Stopwatch timeCounter; //Тimer



        /// <summary>

        /// Responsible for increasing the value in the progressBar 
        /// </summary>
        public void OnIterationPassed(object source, EventArgs e)
        {

            Invoke((MethodInvoker)(() => { this.progressBar.Increment(+1); }));
        }

        #region Opening and Saving data

        /// <summary>
        /// An event handler that occurs when the button for opening a .tsp file is clicked
        /// </summary>
        private void Open_File_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Task.Factory.StartNew(() =>
                {
                    try
                    {

                        Invoke((MethodInvoker)(() =>
                        {
                            ClearData();
                            progressBar.Visible = true;
                            progressBar.Value = 0;
                        }));

                        string myfile = openFileDialog.FileName;
                        string[] strings = File.ReadAllLines(myfile);
                        string[] name = strings[0].Split(':');
                        name_of_tsp = name[1].Trim(' ');
                        string[] cm = strings[1].Split(':');
                        comments[0] = cm[1].Trim(' ');
                        cm = strings[2].Split(':');
                        comments[1] = cm[1].Trim(' ');
                        cm = strings[3].Split(':');
                        comments[2] = cm[1].Trim(' ');

                        for (int i = 8; i < strings.Length - 1; i++)
                        {
                            string[] str = strings[i].Split(' ');
                            int x = int.Parse(str[1]);
                            int y = int.Parse(str[2]);
                            Cities.Add(new City(x, y, n));
                            n++;
                        }

                        Invoke((MethodInvoker)(() =>
                        {
                            progressBar.Visible = true;
                            progressBar.Value = 511;
                        }));


                        

                        session_sum = 0;
                        session_n = 0;
                    }
                    catch (Exception ex)
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            MessageBox.Show(ex.Message + "\nThe error might have occurred due to incorrect input data.\nTry opening another file.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                        }));
                    }
                });
            }
        }



        /// <summary>
        /// Event handler for the event that occurs when the FIND A PATH BUTTON is clicked
        /// </summary>
        private void find_btn_Click(object sender, EventArgs e)
        {
            if (Cities.Count > 2)
            {
                Task.Factory.StartNew(() =>
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        progressBar.Visible = true;
                        progressBar.Value = 0;
                    }));
                    timeCounter = new Stopwatch();

                    if (Solution.Count <= Cities.Count) Solution.Clear();
                    if (Solution.Count > 0)
                    {
                        Solution.RemoveAt(Solution.Count - 1);
                    }

                    firefly = new Fireflies(Solution);
                    firefly.IterationPassed += OnIterationPassed;

                    timeCounter.Start();
                    Solution = firefly.start(Cities);
                    timeCounter.Stop();

                    string ellapsedTime = (timeCounter.ElapsedMilliseconds / 1000) + "." + (timeCounter.ElapsedMilliseconds % 1000) +
                    " s";
                    int cost = SinglePathCost(Solution); //Also adds the first point to the end (makes a cycle from our path)
                    session_sum += cost;
                    session_n++;

                    length = cost;
                    if (length < session_min) session_min = length;
                    Invoke((MethodInvoker)(() =>
                    {
                        length_label.Text = "Best tour length : " + cost.ToString();
                        time_label.Text = "Time: " + ellapsedTime;
                        label2.Text = "Runs: " + session_n;

                    }));

                    path = string.Empty;
                    foreach (City c in Solution)
                    {
                        path += c.index.ToString() + "--> ";
                    }
                    path = path.TrimEnd('>', '-');

                    Invoke((MethodInvoker)(() =>
                    {
                        richTextBox.Text = path;
                        progressBar.Visible = false;

                    }));
                });
            }
            else
            {
                MessageBox.Show("You need at least three points to find the path!",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        /// <summary>
        ///Event handler for the event that occurs when the clear button is clicked
        /// </summary>
        private void del_btn_Click(object sender, EventArgs e)
        {
            ClearData();
        }




        /// <summary>
        /// Returns the total length of the resulting tour
        /// </summary>
        /// <param name="path">requested tour</param>
        /// <returns></returns>
        int SinglePathCost(List<City> path)
        {
            int sum = 0;
            path.Add(path[0]);
            for (int i = 0; i < path.Count - 1; i++)
            {
                sum += City.getDestination(path[i], path[i + 1]);
            }
            return sum;
        }
        


        /// <summary>
        /// Method for clearing data reset all
        /// </summary>
        void ClearData()
        {

            n = 1;

            richTextBox.Text = string.Empty;
            path = string.Empty;
            name_of_tsp = string.Empty;
            comments = new string[3];
            length_label.Text = "Best tour length : ";
            time_label.Text = "Time: ";
            label2.Text = "Runs: ";
            session_n = 0;
            session_sum = 0;
            session_min = int.MaxValue;            
            Cities.Clear();
            Solution.Clear();
            indexes.Clear();
            


        }

        #endregion

    }
}
