namespace WindowsFormsDictionary
{
    partial class Menu
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
            this.buttonOef1 = new System.Windows.Forms.Button();
            this.buttonOef2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOef1
            // 
            this.buttonOef1.Location = new System.Drawing.Point(58, 12);
            this.buttonOef1.Name = "buttonOef1";
            this.buttonOef1.Size = new System.Drawing.Size(75, 23);
            this.buttonOef1.TabIndex = 0;
            this.buttonOef1.Text = "Ofenig1";
            this.buttonOef1.UseVisualStyleBackColor = true;
            this.buttonOef1.Click += new System.EventHandler(this.buttonOef1_Click);
            // 
            // buttonOef2
            // 
            this.buttonOef2.Location = new System.Drawing.Point(58, 41);
            this.buttonOef2.Name = "buttonOef2";
            this.buttonOef2.Size = new System.Drawing.Size(75, 23);
            this.buttonOef2.TabIndex = 1;
            this.buttonOef2.Text = "Oefening2";
            this.buttonOef2.UseVisualStyleBackColor = true;
            this.buttonOef2.Click += new System.EventHandler(this.buttonOef2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Oefening3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 196);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonOef2);
            this.Controls.Add(this.buttonOef1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOef1;
        private System.Windows.Forms.Button buttonOef2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}