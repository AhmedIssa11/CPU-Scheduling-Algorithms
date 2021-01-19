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

    public partial class Form1 : Form
    {
        private Random rand = new Random();

        List<Color> listColor = new List<Color>();

        List<string> listP = new List<string>();
        List<string> listTmp = new List<string>();

        List<int> listTotal = new List<int>();
        List<int> listR = new List<int>();
        List<int> listTL = new List<int>();
        List<int> listQ = new List<int>();
        List<int> listArrT = new List<int>();
        LinkedList<NewProcess> processesList;

        NewProcess p1;       
        RoundRobin rrAlgo;

        public Form1()
        {
            InitializeComponent();
            processesList = new LinkedList<NewProcess>();
        }

        ///////form2
        public void AddProcess(NewProcess tempProcess)
        {
            //Create Strings of each process value and send to Data Grid View
            string ID = tempProcess.ID.ToString();
            string name = tempProcess.name;
            string time = tempProcess.time.ToString();
            string arrTime = tempProcess.arrTime.ToString();
            string[] tempProcessArray = { ID, name, time, arrTime, "Ready" };
            dataGridView.Rows.Add(tempProcessArray);

            processesList.AddLast(tempProcess);
        }

        public void TurnaroundTime()
        {
            int total = 0,totalTurn=0;
            int x = 0, y = 0;
            for(int i=0;i<listTmp.Count;i++)
            {
                for(int j=0;j<listP.Count;j++)
                {
                    if(listTmp[i] == listP[j])
                    {
                        total = listTL[j] - listArrT[i];
                       /* x = listTL[j];
                        y = listArrT[i];*/
                    }
                }
                //MessageBox.Show("" + x + "-" + y + "=" + total);
                totalTurn += total;
                total = 0;               
            }
            turnLb.Text = "" + totalTurn/listTmp.Count;
        }

        public void WaitingTime()
        {
            int startPos = 0, endPos = 0, total, ct;
            for (int i = 0; i < listTmp.Count; i++)
            {
                ct = 0; total = 0;
                for (int j = 0; j < listP.Count; j++)
                {
                    if (listP[j] == listTmp[i])
                    {
                        ct++;
                        if (j == 0)
                        {
                            // odd
                            if (ct % 2 != 0)
                            {
                                endPos = listTL[j];
                            }
                            else
                            {
                                startPos = listTL[j - 1];
                                total += startPos - endPos;
                                MessageBox.Show(Convert.ToString(startPos) + "-" + Convert.ToString(endPos));
                                //3
                                endPos = listTL[j];
                                ct = 1;
                            }
                        }
                        else if (j != 0 && listP[j - 1] != listP[j])
                        {
                            // odd
                            if (ct % 2 != 0)
                            {
                                endPos = listTL[j];
                                total += listTL[j - 1];
                                int tmp = listTL[j - 1];
                                //MessageBox.Show(Convert.ToString(tmp));
                            }
                            else
                            {
                                startPos = listTL[j - 1];
                                total += startPos - endPos;
                                //MessageBox.Show(Convert.ToString(startPos) + "-" + Convert.ToString(endPos));
                                //3
                                endPos = listTL[j];
                                ct = 1;
                            }
                        }
                    }
                }
                listTotal.Add(total);
            }
            int total1 = 0;
            for (int i = 0; i < listTotal.Count; i++)
            {
                total1 += listTotal[i];
            }
            waitingLb.Text = Convert.ToString(total1 / listTmp.Count);
            //MessageBox.Show(Convert.ToString(total1) + "/" + Convert.ToString(listTmp.Count));
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            boxID.Text = "1";
        }

        public void SetTextForLabel()
        {
            //
            int x = 45;
            int gantt = 0;
            string str = "";
            Color lbColor = Color.Black;
            listTmp = listP.Distinct().ToList();
            for(int j=0;j<listTmp.Count;j++)
            {
                listColor.Add(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            }

            for (int i=0;i<listR.Count;i++)
            {
                ///Color
                for(int k = 0; k < listTmp.Count; k++) 
                {
                    if(listTmp[k] == listP[i]) 
                    {
                        lbColor = listColor[k];
                    }
                }
                gantt += listQ[i];
                listTL.Add(gantt);
                ///line
                Label ll = new Label();
                ll.BackColor = label7.BackColor;
                ll.Size = this.label7.Size;
                ll.Location = new Point(label7.Location.X + x, label7.Location.Y);
                ll.Visible = true;
                ll.Text = listP[i];
                this.tabPage_GanttChart.Controls.Add(ll);

                //label
                Label lb = new Label();
                lb.BackColor = lbColor;
                lb.Size = this.label11.Size;
                lb.Width = (45 * listQ[i]);
                lb.Location = new Point(label11.Location.X + x , label11.Location.Y);
                lb.Visible = true;
                lb.Text = Convert.ToString(listP[i]) + listQ[i];
                lb.TextAlign = ContentAlignment.MiddleCenter;
                this.tabPage_GanttChart.Controls.Add(lb);

                //number
                Label ln = new Label();
                ln.BackColor = label9.BackColor;
                ln.Size = this.label9.Size;
                ln.Location = new Point(label9.Location.X + x + (45 * (listQ[i] - 1)), label9.Location.Y);
                ln.Visible = true;
                ln.Text = Convert.ToString(gantt);
                this.tabPage_GanttChart.Controls.Add(ln);
                //
                x += 45 + (45 * (listQ[i]-1));
                
            }

            Label llb = new Label();
            llb.BackColor = label7.BackColor;
            llb.Size = this.label7.Size;
            llb.Location = new Point(label7.Location.X + x, label7.Location.Y);
            llb.Visible = true;
            this.tabPage_GanttChart.Controls.Add(llb);


        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int error = 0;
            try
            {
                p1 = new NewProcess();
                p1.name = boxName.Text;
                p1.ID = Convert.ToInt32(boxID.Text);
                p1.time = Convert.ToInt32(boxTime.Text);
                p1.arrTime = Convert.ToInt32(boxIO.Text);

                AddProcess(p1);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Fill All Fields!");
                error = 1;
            }

            if (error != 1)
            {
                boxName.Text = "";
                boxTime.Text = "";
                boxIO.Text = "";

                int tempID = Convert.ToInt32(boxID.Text);
                tempID = tempID + 1;
                boxID.Text = tempID.ToString();
            }
        }

        private void boxID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            boxName.Text = "";
            boxTime.Text = "";
            boxIO.Text = "";
            //SetTextForLabel();
        }

        private void boxIO_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void boxTime_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void boxName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Hide();
            quantum_Box.Hide();
            label2.Hide();

            NewProcess[] processesArray = processesList.ToArray();
            int quantum = (int)quantum_Box.Value;

            rrAlgo = new RoundRobin(ref dataGridView);

            rrAlgo.runRoundRobin(ref processesArray, quantum, listR, listP, listQ, listArrT);
            SetTextForLabel();
            WaitingTime();
            TurnaroundTime();
        }
    }
}
