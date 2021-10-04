
namespace binaryIDE2._0
{
    partial class two
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
            this.button12 = new System.Windows.Forms.Button();
            this.inputTaker2 = new System.Windows.Forms.RichTextBox();
            this.sike2 = new System.Windows.Forms.Label();
            this.darkButton2 = new System.Windows.Forms.Button();
            this.ans2 = new System.Windows.Forms.Label();
            this.II = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(341, 173);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(112, 34);
            this.button12.TabIndex = 12;
            this.button12.Text = "Switch";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // inputTaker2
            // 
            this.inputTaker2.Location = new System.Drawing.Point(11, 20);
            this.inputTaker2.Name = "inputTaker2";
            this.inputTaker2.Size = new System.Drawing.Size(239, 134);
            this.inputTaker2.TabIndex = 11;
            this.inputTaker2.Text = "Type your binary here :D";
            this.inputTaker2.TextChanged += new System.EventHandler(this.inputTaker2_TextChanged);
            // 
            // sike2
            // 
            this.sike2.AutoSize = true;
            this.sike2.Location = new System.Drawing.Point(222, 178);
            this.sike2.Name = "sike2";
            this.sike2.Size = new System.Drawing.Size(0, 25);
            this.sike2.TabIndex = 10;
            this.sike2.Click += new System.EventHandler(this.sike2_Click);
            // 
            // darkButton2
            // 
            this.darkButton2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.darkButton2.Location = new System.Drawing.Point(475, 160);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Size = new System.Drawing.Size(127, 61);
            this.darkButton2.TabIndex = 9;
            this.darkButton2.Text = "Click here for dark mode";
            this.darkButton2.UseVisualStyleBackColor = false;
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(286, 23);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(0, 25);
            this.ans2.TabIndex = 8;
            this.ans2.Click += new System.EventHandler(this.ans2_Click);
            // 
            // II
            // 
            this.II.AutoSize = true;
            this.II.Location = new System.Drawing.Point(256, 61);
            this.II.Name = "II";
            this.II.Size = new System.Drawing.Size(24, 25);
            this.II.TabIndex = 7;
            this.II.Text = "=";
            this.II.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // two
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 241);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.inputTaker2);
            this.Controls.Add(this.sike2);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.II);
            this.Name = "two";
            this.Text = "BinaryIDE (binary to text)";
            this.Load += new System.EventHandler(this.two_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.RichTextBox inputTaker2;
        private System.Windows.Forms.Label sike2;
        private System.Windows.Forms.Button darkButton2;
        private System.Windows.Forms.Label ans2;
        private System.Windows.Forms.Label II;
    }
}