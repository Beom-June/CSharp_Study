namespace AyncBasicTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart1 = new Button();
            btnStart2 = new Button();
            btnStartAll = new Button();
            btnStart4 = new Button();
            lbLogs = new ListBox();
            bugA = new Label();
            bugB = new Label();
            bugC = new Label();
            bugD = new Label();
            finishLine = new Label();
            SuspendLayout();
            // 
            // btnStart1
            // 
            btnStart1.Location = new Point(12, 12);
            btnStart1.Name = "btnStart1";
            btnStart1.Size = new Size(137, 61);
            btnStart1.TabIndex = 0;
            btnStart1.Text = "1. 하나씩 출발";
            btnStart1.UseVisualStyleBackColor = true;
            btnStart1.Click += btnStart1_Click;
            // 
            // btnStart2
            // 
            btnStart2.Location = new Point(12, 79);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(137, 61);
            btnStart2.TabIndex = 1;
            btnStart2.Text = "2. A와 B 먼저 출발";
            btnStart2.UseVisualStyleBackColor = true;
            btnStart2.Click += btnStart2_Click;
            // 
            // btnStartAll
            // 
            btnStartAll.Location = new Point(12, 146);
            btnStartAll.Name = "btnStartAll";
            btnStartAll.Size = new Size(137, 61);
            btnStartAll.TabIndex = 2;
            btnStartAll.Text = "3. 같이 출발";
            btnStartAll.UseVisualStyleBackColor = true;
            btnStartAll.Click += btnStartAll_Click;
            // 
            // btnStart4
            // 
            btnStart4.Location = new Point(12, 213);
            btnStart4.Name = "btnStart4";
            btnStart4.Size = new Size(137, 61);
            btnStart4.TabIndex = 3;
            btnStart4.Text = "4. 같이 출발\r\n(WhenAny)";
            btnStart4.UseVisualStyleBackColor = true;
            btnStart4.Click += btnStart4_Click;
            // 
            // lbLogs
            // 
            lbLogs.FormattingEnabled = true;
            lbLogs.ItemHeight = 15;
            lbLogs.Location = new Point(12, 305);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new Size(705, 124);
            lbLogs.TabIndex = 4;
            // 
            // bugA
            // 
            bugA.AutoSize = true;
            bugA.Font = new Font("맑은 고딕", 13F);
            bugA.Location = new Point(155, 28);
            bugA.Name = "bugA";
            bugA.Size = new Size(59, 25);
            bugA.TabIndex = 5;
            bugA.Text = "A. 🚴‍";
            bugA.Click += bugA_Click;
            // 
            // bugB
            // 
            bugB.AutoSize = true;
            bugB.Font = new Font("맑은 고딕", 13F);
            bugB.Location = new Point(155, 95);
            bugB.Name = "bugB";
            bugB.Size = new Size(53, 25);
            bugB.TabIndex = 6;
            bugB.Text = "B. 🏃‍";
            // 
            // bugC
            // 
            bugC.AutoSize = true;
            bugC.Font = new Font("맑은 고딕", 13F);
            bugC.Location = new Point(155, 162);
            bugC.Name = "bugC";
            bugC.Size = new Size(58, 25);
            bugC.TabIndex = 7;
            bugC.Text = "C. 🏊‍";
            bugC.Click += bugC_Click;
            // 
            // bugD
            // 
            bugD.AutoSize = true;
            bugD.Font = new Font("맑은 고딕", 13F);
            bugD.Location = new Point(155, 229);
            bugD.Name = "bugD";
            bugD.Size = new Size(60, 25);
            bugD.TabIndex = 8;
            bugD.Text = "D. 🏇";
            // 
            // finishLine
            // 
            finishLine.BackColor = SystemColors.HotTrack;
            finishLine.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
            finishLine.ForeColor = SystemColors.ButtonHighlight;
            finishLine.Location = new Point(585, 12);
            finishLine.Name = "finishLine";
            finishLine.Size = new Size(100, 262);
            finishLine.TabIndex = 9;
            finishLine.Text = "도착지";
            finishLine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(finishLine);
            Controls.Add(bugD);
            Controls.Add(bugC);
            Controls.Add(bugB);
            Controls.Add(bugA);
            Controls.Add(lbLogs);
            Controls.Add(btnStart4);
            Controls.Add(btnStartAll);
            Controls.Add(btnStart2);
            Controls.Add(btnStart1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart1;
        private Button btnStart2;
        private Button btnStartAll;
        private Button btnStart4;
        private ListBox lbLogs;
        private Label bugA;
        private Label bugB;
        private Label bugC;
        private Label bugD;
        private Label finishLine;
    }
}
