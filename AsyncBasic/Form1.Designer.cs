namespace AsyncBasic
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
            btnWalking = new Button();
            lblWalking = new Label();
            lblPhone = new Label();
            btnPhone = new Button();
            lblTalking = new Label();
            btnTalking = new Button();
            lbAll = new ListBox();
            btnAll = new Button();
            SuspendLayout();
            // 
            // btnWalking
            // 
            btnWalking.Location = new Point(12, 12);
            btnWalking.Name = "btnWalking";
            btnWalking.Size = new Size(114, 68);
            btnWalking.TabIndex = 0;
            btnWalking.Text = "걷기";
            btnWalking.UseVisualStyleBackColor = true;
            btnWalking.Click += btnWalking_Click;
            // 
            // lblWalking
            // 
            lblWalking.AutoSize = true;
            lblWalking.Location = new Point(132, 39);
            lblWalking.Name = "lblWalking";
            lblWalking.Size = new Size(39, 15);
            lblWalking.TabIndex = 1;
            lblWalking.Text = "label1";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(132, 113);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(39, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "label1";
            // 
            // btnPhone
            // 
            btnPhone.Location = new Point(12, 86);
            btnPhone.Name = "btnPhone";
            btnPhone.Size = new Size(114, 68);
            btnPhone.TabIndex = 2;
            btnPhone.Text = "핸드폰";
            btnPhone.UseVisualStyleBackColor = true;
            btnPhone.Click += btnPhone_Click;
            // 
            // lblTalking
            // 
            lblTalking.AutoSize = true;
            lblTalking.Location = new Point(132, 187);
            lblTalking.Name = "lblTalking";
            lblTalking.Size = new Size(39, 15);
            lblTalking.TabIndex = 5;
            lblTalking.Text = "label1";
            // 
            // btnTalking
            // 
            btnTalking.Location = new Point(12, 160);
            btnTalking.Name = "btnTalking";
            btnTalking.Size = new Size(114, 68);
            btnTalking.TabIndex = 4;
            btnTalking.Text = "말하기";
            btnTalking.UseVisualStyleBackColor = true;
            btnTalking.Click += btnTalking_Click;
            // 
            // lbAll
            // 
            lbAll.FormattingEnabled = true;
            lbAll.ItemHeight = 15;
            lbAll.Location = new Point(336, 12);
            lbAll.Name = "lbAll";
            lbAll.Size = new Size(120, 244);
            lbAll.TabIndex = 6;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(240, 12);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(90, 68);
            btnAll.TabIndex = 7;
            btnAll.Text = "전체";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 267);
            Controls.Add(btnAll);
            Controls.Add(lbAll);
            Controls.Add(lblTalking);
            Controls.Add(btnTalking);
            Controls.Add(lblPhone);
            Controls.Add(btnPhone);
            Controls.Add(lblWalking);
            Controls.Add(btnWalking);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWalking;
        private Label lblWalking;
        private Label lblPhone;
        private Button btnPhone;
        private Label lblTalking;
        private Button btnTalking;
        private ListBox lbAll;
        private Button btnAll;
    }
}
