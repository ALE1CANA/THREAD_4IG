namespace THREAD_4IG
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
            domainUpDown1 = new DomainUpDown();
            button1 = new Button();
            lbltempo = new Label();
            SuspendLayout();
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(259, 171);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 0;
            domainUpDown1.Text = "10";
            // 
            // button1
            // 
            button1.Location = new Point(490, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "AVVIA";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbltempo
            // 
            lbltempo.AutoSize = true;
            lbltempo.Location = new Point(412, 80);
            lbltempo.Name = "lbltempo";
            lbltempo.Size = new Size(13, 15);
            lbltempo.TabIndex = 2;
            lbltempo.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbltempo);
            Controls.Add(button1);
            Controls.Add(domainUpDown1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown domainUpDown1;
        private Button button1;
        private Label lbltempo;
    }
}
