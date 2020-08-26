namespace WindowsFormsDictionary
{
    partial class Oefening3
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
            this.cmbNederlands = new System.Windows.Forms.ComboBox();
            this.lblEngels = new System.Windows.Forms.Label();
            this.lblHungary = new System.Windows.Forms.Label();
            this.lblFrans = new System.Windows.Forms.Label();
            this.lblGermany = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbNederlands
            // 
            this.cmbNederlands.FormattingEnabled = true;
            this.cmbNederlands.Location = new System.Drawing.Point(12, 12);
            this.cmbNederlands.Name = "cmbNederlands";
            this.cmbNederlands.Size = new System.Drawing.Size(121, 21);
            this.cmbNederlands.TabIndex = 0;
            this.cmbNederlands.SelectedIndexChanged += new System.EventHandler(this.cmbNederlands_SelectedIndexChanged);
            // 
            // lblEngels
            // 
            this.lblEngels.AutoSize = true;
            this.lblEngels.Location = new System.Drawing.Point(150, 12);
            this.lblEngels.Name = "lblEngels";
            this.lblEngels.Size = new System.Drawing.Size(0, 13);
            this.lblEngels.TabIndex = 1;
            // 
            // lblHungary
            // 
            this.lblHungary.AutoSize = true;
            this.lblHungary.Location = new System.Drawing.Point(150, 39);
            this.lblHungary.Name = "lblHungary";
            this.lblHungary.Size = new System.Drawing.Size(0, 13);
            this.lblHungary.TabIndex = 2;
            // 
            // lblFrans
            // 
            this.lblFrans.AutoSize = true;
            this.lblFrans.Location = new System.Drawing.Point(150, 96);
            this.lblFrans.Name = "lblFrans";
            this.lblFrans.Size = new System.Drawing.Size(0, 13);
            this.lblFrans.TabIndex = 4;
            // 
            // lblGermany
            // 
            this.lblGermany.AutoSize = true;
            this.lblGermany.Location = new System.Drawing.Point(150, 69);
            this.lblGermany.Name = "lblGermany";
            this.lblGermany.Size = new System.Drawing.Size(0, 13);
            this.lblGermany.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 102);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Oefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 137);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.lblFrans);
            this.Controls.Add(this.lblGermany);
            this.Controls.Add(this.lblHungary);
            this.Controls.Add(this.lblEngels);
            this.Controls.Add(this.cmbNederlands);
            this.Name = "Oefening3";
            this.Text = "Oefening3";
            this.Load += new System.EventHandler(this.Oefening3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNederlands;
        private System.Windows.Forms.Label lblEngels;
        private System.Windows.Forms.Label lblHungary;
        private System.Windows.Forms.Label lblFrans;
        private System.Windows.Forms.Label lblGermany;
        private System.Windows.Forms.Button buttonAdd;
    }
}