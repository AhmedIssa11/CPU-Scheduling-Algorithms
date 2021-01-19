using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Schedule
{
    public class RoundRobin
    {
        Form1 form1;
        DataGridView dataGridView;

        public RoundRobin(ref DataGridView temp_dataGridView)
        {
            dataGridView = temp_dataGridView;       
        }

        public void runRoundRobin(ref NewProcess[] multiNewProcesses, int quantum, List<int> listR, List<string> listP, List<int> listQ,List<int> listArrT)
        {
            
            foreach (var NewProcess in multiNewProcesses)
            {
                NewProcess.remainingTime = NewProcess.time;
                listArrT.Add(NewProcess.arrTime);
            }
            while (true)
            {              
                bool executionFinished = true;
                foreach (var NewProcess in multiNewProcesses)
                {
                    if (NewProcess.remainingTime == 0)
                    {
                        NewProcess.status = "Completed";
                        updateDataGridView(dataGridView, multiNewProcesses);
                    }

                    //Check if the process has any burst time left
                    else if (NewProcess.remainingTime > 0)
                    {
                        executionFinished = false;

                        //Check if the process remaining time is greater than quantum
                        if (NewProcess.remainingTime > quantum)
                        {
                            NewProcess.status = "Running";
                            updateDataGridView(dataGridView, multiNewProcesses);
                            executionTimer(quantum);                          

                            //Remove the quantum time from the remaining time
                            NewProcess.remainingTime = NewProcess.remainingTime - quantum;
                            //////
                            listR.Add(NewProcess.remainingTime);
                            listP.Add(NewProcess.name);
                            listQ.Add(quantum);

                            NewProcess.status = "Ready";
                            updateDataGridView(dataGridView, multiNewProcesses);
                        }
                        //Only runs when the process is on its last cpu burst cycle
                        else
                        {
                            while (NewProcess.IO > 0)
                            {
                                ioExecution(multiNewProcesses, NewProcess.ID, NewProcess.IO);
                                NewProcess.IO = NewProcess.IO - 1;
                            }

                            NewProcess.status = "Running";
                            //
                            listR.Add(NewProcess.remainingTime);
                            listP.Add(NewProcess.name);
                            listQ.Add(NewProcess.remainingTime);
                            //
                            updateDataGridView(dataGridView, multiNewProcesses);
                            executionTimer(NewProcess.remainingTime);

                            //Set remaining time to 0, as the last cpu burst ended
                            NewProcess.remainingTime = 0;
                            NewProcess.status = "Completed";
                            updateDataGridView(dataGridView, multiNewProcesses);
                        }
                    }
                    if (NewProcess.IO > 0)
                    {
                        ioExecution(multiNewProcesses, NewProcess.ID, NewProcess.IO);
                        NewProcess.IO = NewProcess.IO - 1;
                    }
                }

                //When All Processes have completed their execution
                if (executionFinished == true)
                {
                    break;
                }
            }
        }

        public void updateDataGridView(DataGridView dataGridView, NewProcess[] multiNewProcesses)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            foreach (var NewProcess in multiNewProcesses)
            {
                string[] row = { NewProcess.ID.ToString(), NewProcess.name, NewProcess.remainingTime.ToString(), NewProcess.arrTime.ToString(), NewProcess.status };
                dataGridView.Rows.Add(row);
            }
        }
         

        //canceled
        public void ioExecution(NewProcess[] multiNewProcesses, int id, int interupt)
        {
            //Change Process State to Waiting when it goes to IO
            foreach (var NewProcess in multiNewProcesses)
            {
                if (NewProcess.ID == id && NewProcess.status != "Completed")
                {
                    NewProcess.status = "Waiting";
                }
            }
            updateDataGridView(dataGridView, multiNewProcesses);
            executionTimer(1);
            foreach (var NewProcess in multiNewProcesses)
            {
                if (NewProcess.ID == id && NewProcess.status != "Completed")
                {
                    NewProcess.status = "Ready";
                }
            }
            updateDataGridView(dataGridView, multiNewProcesses);
        }

        //Timer Method
        public void executionTimer(int tempTime)
        {
            int executionTime = tempTime * 1000;
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (executionTime == 0 || executionTime < 0)
            {
                return;
            }
            timer1.Interval = executionTime;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
