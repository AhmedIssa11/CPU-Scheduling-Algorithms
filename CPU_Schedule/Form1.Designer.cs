namespace CPU_Schedule
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReset = new System.Windows.Forms.Button();
            this.boxIO = new System.Windows.Forms.TextBox();
            this.boxTime = new System.Windows.Forms.TextBox();
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Burst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.io = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.quantum_Box = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl_GanttChart = new System.Windows.Forms.TabControl();
            this.tabPage_GanttChart = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.waitingLb = new System.Windows.Forms.Label();
            this.turnLb = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantum_Box)).BeginInit();
            this.tabControl_GanttChart.SuspendLayout();
            this.tabPage_GanttChart.SuspendLayout();
            this.Average.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(240, 343);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 34);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // boxIO
            // 
            this.boxIO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.boxIO.Location = new System.Drawing.Point(127, 237);
            this.boxIO.Margin = new System.Windows.Forms.Padding(4);
            this.boxIO.Name = "boxIO";
            this.boxIO.Size = new System.Drawing.Size(227, 29);
            this.boxIO.TabIndex = 13;
            this.boxIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxIO_KeyPress_1);
            // 
            // boxTime
            // 
            this.boxTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTime.Location = new System.Drawing.Point(127, 174);
            this.boxTime.Margin = new System.Windows.Forms.Padding(4);
            this.boxTime.Name = "boxTime";
            this.boxTime.Size = new System.Drawing.Size(227, 29);
            this.boxTime.TabIndex = 11;
            this.boxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTime_KeyPress_1);
            // 
            // boxID
            // 
            this.boxID.Enabled = false;
            this.boxID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.boxID.Location = new System.Drawing.Point(127, 111);
            this.boxID.Margin = new System.Windows.Forms.Padding(4);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(227, 29);
            this.boxID.TabIndex = 9;
            this.boxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxID_KeyPress_1);
            // 
            // boxName
            // 
            this.boxName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.boxName.Location = new System.Drawing.Point(127, 50);
            this.boxName.Margin = new System.Windows.Forms.Padding(4);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(227, 29);
            this.boxName.TabIndex = 7;
            this.boxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxName_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Burst Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(127, 343);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Burst,
            this.io,
            this.status});
            this.dataGridView.Location = new System.Drawing.Point(419, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 4;
            this.dataGridView.Size = new System.Drawing.Size(694, 277);
            this.dataGridView.TabIndex = 26;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Burst
            // 
            this.Burst.HeaderText = "Burst Time";
            this.Burst.MinimumWidth = 6;
            this.Burst.Name = "Burst";
            this.Burst.ReadOnly = true;
            // 
            // io
            // 
            this.io.HeaderText = "Arrival Time";
            this.io.MinimumWidth = 6;
            this.io.Name = "io";
            this.io.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(640, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Algorithm";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "RR";
            // 
            // quantum_Box
            // 
            this.quantum_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantum_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.quantum_Box.Location = new System.Drawing.Point(504, 347);
            this.quantum_Box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantum_Box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantum_Box.Name = "quantum_Box";
            this.quantum_Box.Size = new System.Drawing.Size(130, 29);
            this.quantum_Box.TabIndex = 30;
            this.quantum_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Arrival Time";
            // 
            // tabControl_GanttChart
            // 
            this.tabControl_GanttChart.Controls.Add(this.tabPage_GanttChart);
            this.tabControl_GanttChart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_GanttChart.Location = new System.Drawing.Point(92, 451);
            this.tabControl_GanttChart.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_GanttChart.Name = "tabControl_GanttChart";
            this.tabControl_GanttChart.SelectedIndex = 0;
            this.tabControl_GanttChart.Size = new System.Drawing.Size(1021, 153);
            this.tabControl_GanttChart.TabIndex = 168;
            // 
            // tabPage_GanttChart
            // 
            this.tabPage_GanttChart.AutoScroll = true;
            this.tabPage_GanttChart.Controls.Add(this.label7);
            this.tabPage_GanttChart.Controls.Add(this.label9);
            this.tabPage_GanttChart.Controls.Add(this.label10);
            this.tabPage_GanttChart.Controls.Add(this.label11);
            this.tabPage_GanttChart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_GanttChart.Location = new System.Drawing.Point(4, 28);
            this.tabPage_GanttChart.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_GanttChart.Name = "tabPage_GanttChart";
            this.tabPage_GanttChart.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_GanttChart.Size = new System.Drawing.Size(1013, 121);
            this.tabPage_GanttChart.TabIndex = 0;
            this.tabPage_GanttChart.Text = "Gantt Chart";
            this.tabPage_GanttChart.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(29, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 62);
            this.label7.TabIndex = 172;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            this.label7.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(81, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 23);
            this.label9.TabIndex = 170;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(89, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1, 62);
            this.label10.TabIndex = 169;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Maroon;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(29, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 37);
            this.label11.TabIndex = 162;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.UseCompatibleTextRendering = true;
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(60, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 25);
            this.label12.TabIndex = 170;
            this.label12.Text = "Waiting";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(175, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 25);
            this.label13.TabIndex = 171;
            this.label13.Text = "Turnaround";
            // 
            // waitingLb
            // 
            this.waitingLb.AutoSize = true;
            this.waitingLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingLb.ForeColor = System.Drawing.Color.Black;
            this.waitingLb.Location = new System.Drawing.Point(93, 90);
            this.waitingLb.Name = "waitingLb";
            this.waitingLb.Size = new System.Drawing.Size(24, 25);
            this.waitingLb.TabIndex = 172;
            this.waitingLb.Text = "0";
            // 
            // turnLb
            // 
            this.turnLb.AutoSize = true;
            this.turnLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLb.ForeColor = System.Drawing.Color.Black;
            this.turnLb.Location = new System.Drawing.Point(226, 90);
            this.turnLb.Name = "turnLb";
            this.turnLb.Size = new System.Drawing.Size(24, 25);
            this.turnLb.TabIndex = 173;
            this.turnLb.Text = "0";
            // 
            // Average
            // 
            this.Average.Controls.Add(this.waitingLb);
            this.Average.Controls.Add(this.turnLb);
            this.Average.Controls.Add(this.label12);
            this.Average.Controls.Add(this.label13);
            this.Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Average.Location = new System.Drawing.Point(770, 343);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(343, 126);
            this.Average.TabIndex = 174;
            this.Average.TabStop = false;
            this.Average.Text = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 625);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.tabControl_GanttChart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantum_Box);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.boxIO);
            this.Controls.Add(this.boxTime);
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantum_Box)).EndInit();
            this.tabControl_GanttChart.ResumeLayout(false);
            this.tabPage_GanttChart.ResumeLayout(false);
            this.Average.ResumeLayout(false);
            this.Average.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox boxIO;
        private System.Windows.Forms.TextBox boxTime;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown quantum_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl_GanttChart;
        private System.Windows.Forms.TabPage tabPage_GanttChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label waitingLb;
        private System.Windows.Forms.Label turnLb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Burst;
        private System.Windows.Forms.DataGridViewTextBoxColumn io;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.GroupBox Average;
    }
}

