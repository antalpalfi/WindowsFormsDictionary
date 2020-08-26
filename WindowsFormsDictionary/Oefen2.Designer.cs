namespace WindowsFormsDictionary
{
    partial class Oefen2
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
            this.cmbNederland = new System.Windows.Forms.ComboBox();
            this.lblEngels = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbNederland
            // 
            this.cmbNederland.FormattingEnabled = true;
            this.cmbNederland.Location = new System.Drawing.Point(12, 12);
            this.cmbNederland.Name = "cmbNederland";
            this.cmbNederland.Size = new System.Drawing.Size(121, 21);
            this.cmbNederland.TabIndex = 0;
            this.cmbNederland.SelectedIndexChanged += new System.EventHandler(this.cmbNederland_SelectedIndexChanged);
            // 
            // lblEngels
            // 
            this.lblEngels.AutoSize = true;
            this.lblEngels.Location = new System.Drawing.Point(12, 36);
            this.lblEngels.Name = "lblEngels";
            this.lblEngels.Size = new System.Drawing.Size(0, 13);
            this.lblEngels.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(165, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(165, 41);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Oefen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 172);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEngels);
            this.Controls.Add(this.cmbNederland);
            this.Name = "Oefen2";
            this.Text = "Oefen2";
            this.Load += new System.EventHandler(this.Oefen2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNederland;
        private System.Windows.Forms.Label lblEngels;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}