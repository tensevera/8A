namespace Shunting_yard_algorithm
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
            this.tbVstup = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbVstup
            // 
            this.tbVstup.Location = new System.Drawing.Point(63, 12);
            this.tbVstup.Name = "tbVstup";
            this.tbVstup.Size = new System.Drawing.Size(220, 23);
            this.tbVstup.TabIndex = 0;
            this.tbVstup.Text = "VSTUP";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(289, 11);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbVstup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVstup;
        private System.Windows.Forms.Button btStart;
    }
}

