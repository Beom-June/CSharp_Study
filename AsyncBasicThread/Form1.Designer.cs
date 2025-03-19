namespace AsyncBasicThread
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
            btnCopyMain = new Button();
            btnCopyBack = new Button();
            lblMain = new Label();
            progressMain = new ProgressBar();
            SuspendLayout();
            // 
            // btnCopyMain
            // 
            btnCopyMain.Location = new Point(12, 12);
            btnCopyMain.Name = "btnCopyMain";
            btnCopyMain.Size = new Size(136, 69);
            btnCopyMain.TabIndex = 0;
            btnCopyMain.Text = "파일 복사 \r\n비동기 \r\n(동일 스레드)\r\n";
            btnCopyMain.UseVisualStyleBackColor = true;
            btnCopyMain.Click += btnCopyMain_Click;
            // 
            // btnCopyBack
            // 
            btnCopyBack.Location = new Point(204, 12);
            btnCopyBack.Name = "btnCopyBack";
            btnCopyBack.Size = new Size(136, 69);
            btnCopyBack.TabIndex = 1;
            btnCopyBack.Text = "파일 복사 \r\n비동기 \r\n(백그라운드 스레드)\r\n";
            btnCopyBack.UseVisualStyleBackColor = true;
            btnCopyBack.Click += progresssMain_Click;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Location = new Point(158, 141);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(39, 15);
            lblMain.TabIndex = 2;
            lblMain.Text = "label1";
            // 
            // progressMain
            // 
            progressMain.Location = new Point(12, 87);
            progressMain.Name = "progressMain";
            progressMain.Size = new Size(328, 51);
            progressMain.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 175);
            Controls.Add(progressMain);
            Controls.Add(lblMain);
            Controls.Add(btnCopyBack);
            Controls.Add(btnCopyMain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCopyMain;
        private Button btnCopyBack;
        private Label lblMain;
        private ProgressBar progressMain;
    }
}
