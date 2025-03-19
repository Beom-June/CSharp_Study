namespace AsyncBasicCancelToken2
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
            btnStart = new Button();
            btnCancle = new Button();
            prg1 = new ProgressBar();
            prg2 = new ProgressBar();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            prg4 = new ProgressBar();
            prg3 = new ProgressBar();
            lbl6 = new Label();
            lbl5 = new Label();
            prg6 = new ProgressBar();
            prg5 = new ProgressBar();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(152, 88);
            btnStart.TabIndex = 0;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(185, 12);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(152, 88);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "취소";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // prg1
            // 
            prg1.Location = new Point(12, 106);
            prg1.Name = "prg1";
            prg1.Size = new Size(433, 50);
            prg1.TabIndex = 2;
            prg1.Click += prg1_Click;
            // 
            // prg2
            // 
            prg2.Location = new Point(12, 162);
            prg2.Name = "prg2";
            prg2.Size = new Size(433, 50);
            prg2.TabIndex = 3;
            prg2.Click += prg2_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl1.Location = new Point(451, 117);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(43, 25);
            lbl1.TabIndex = 4;
            lbl1.Text = "lbl1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl2.Location = new Point(451, 176);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(43, 25);
            lbl2.TabIndex = 5;
            lbl2.Text = "lbl2";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl4.Location = new Point(451, 293);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(43, 25);
            lbl4.TabIndex = 9;
            lbl4.Text = "lbl4";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl3.Location = new Point(451, 234);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(43, 25);
            lbl3.TabIndex = 8;
            lbl3.Text = "lbl3";
            // 
            // prg4
            // 
            prg4.Location = new Point(12, 279);
            prg4.Name = "prg4";
            prg4.Size = new Size(433, 50);
            prg4.TabIndex = 7;
            // 
            // prg3
            // 
            prg3.Location = new Point(12, 223);
            prg3.Name = "prg3";
            prg3.Size = new Size(433, 50);
            prg3.TabIndex = 6;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl6.Location = new Point(451, 406);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(43, 25);
            lbl6.TabIndex = 13;
            lbl6.Text = "lbl6";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl5.Location = new Point(451, 347);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(43, 25);
            lbl5.TabIndex = 12;
            lbl5.Text = "lbl5";
            // 
            // prg6
            // 
            prg6.Location = new Point(12, 392);
            prg6.Name = "prg6";
            prg6.Size = new Size(433, 50);
            prg6.TabIndex = 11;
            // 
            // prg5
            // 
            prg5.Location = new Point(12, 336);
            prg5.Name = "prg5";
            prg5.Size = new Size(433, 50);
            prg5.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 469);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(prg6);
            Controls.Add(prg5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(prg4);
            Controls.Add(prg3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(prg2);
            Controls.Add(prg1);
            Controls.Add(btnCancle);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnCancle;
        private ProgressBar prg1;
        private ProgressBar prg2;
        private Label lbl1;
        private Label lbl2;
        private Label lbl4;
        private Label lbl3;
        private ProgressBar prg4;
        private ProgressBar prg3;
        private Label lbl6;
        private Label lbl5;
        private ProgressBar prg6;
        private ProgressBar prg5;
    }
}
