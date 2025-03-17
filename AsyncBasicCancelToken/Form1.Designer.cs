namespace AsyncBasicCancelToken
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
            lblIdx = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(128, 72);
            btnStart.TabIndex = 0;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(146, 12);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(128, 72);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "취소";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // lblIdx
            // 
            lblIdx.AutoSize = true;
            lblIdx.Location = new Point(280, 41);
            lblIdx.Name = "lblIdx";
            lblIdx.Size = new Size(39, 15);
            lblIdx.TabIndex = 2;
            lblIdx.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 259);
            Controls.Add(lblIdx);
            Controls.Add(btnCancle);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnCancle;
        private Label lblIdx;
    }
}
