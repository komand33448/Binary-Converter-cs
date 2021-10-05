
namespace binaryIDE2._0
{
    partial class one
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
            this.II = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.darkButton = new System.Windows.Forms.Button();
            this.sike = new System.Windows.Forms.Label();
            this.inputTaker = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // II
            // 
            this.II.AutoSize = true;
            this.II.Location = new System.Drawing.Point(257, 67);
            this.II.Name = "II";
            this.II.Size = new System.Drawing.Size(24, 25);
            this.II.TabIndex = 1;
            this.II.Text = "=";
            this.II.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.II.Click += new System.EventHandler(this.II_Click);
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(287, 29);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(0, 25);
            this.ans.TabIndex = 2;
            // 
            // darkButton
            // 
            this.darkButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.darkButton.Location = new System.Drawing.Point(476, 166);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(127, 61);
            this.darkButton.TabIndex = 3;
            this.darkButton.Text = "Click here for dark mode";
            this.darkButton.UseVisualStyleBackColor = false;
            this.darkButton.Click += new System.EventHandler(this.darkButton_Click);
            // 
            // sike
            // 
            this.sike.AutoSize = true;
            this.sike.Location = new System.Drawing.Point(223, 184);
            this.sike.Name = "sike";
            this.sike.Size = new System.Drawing.Size(0, 25);
            this.sike.TabIndex = 4;
            this.sike.Click += new System.EventHandler(this.sike_Click);
            // 
            // inputTaker
            // 
            this.inputTaker.Location = new System.Drawing.Point(12, 26);
            this.inputTaker.Name = "inputTaker";
            this.inputTaker.Size = new System.Drawing.Size(239, 134);
            this.inputTaker.TabIndex = 5;
            this.inputTaker.Text = "Type your digits here :D";
            this.inputTaker.TextChanged += new System.EventHandler(this.inputTaker_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Switch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputTaker);
            this.Controls.Add(this.sike);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.II);
            this.Name = "one";
            this.Text = "BinaryIDE (text to binary)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label II;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button darkButton;
        private System.Windows.Forms.Label sike;
        private System.Windows.Forms.RichTextBox inputTaker;
        private System.Windows.Forms.Button button1;
    }
}

