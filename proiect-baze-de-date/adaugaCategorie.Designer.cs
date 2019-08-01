namespace proiect_baze_de_date
{
    partial class adaugaCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adaugaCategorie));
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCategorie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategorie
            // 
            this.txtCategorie.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorie.Location = new System.Drawing.Point(186, 24);
            this.txtCategorie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(283, 32);
            this.txtCategorie.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Categorie sport:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 153);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 50);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCategorie
            // 
            this.btnAddCategorie.Image = global::proiect_baze_de_date.Properties.Resources.if_data__add_83623;
            this.btnAddCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategorie.Location = new System.Drawing.Point(71, 153);
            this.btnAddCategorie.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddCategorie.Name = "btnAddCategorie";
            this.btnAddCategorie.Size = new System.Drawing.Size(127, 50);
            this.btnAddCategorie.TabIndex = 20;
            this.btnAddCategorie.Text = "Adauga";
            this.btnAddCategorie.UseVisualStyleBackColor = true;
            this.btnAddCategorie.Click += new System.EventHandler(this.btnAddComanda_Click);
            // 
            // adaugaCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiect_baze_de_date.Properties.Resources.ballet_1553359__340;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 217);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCategorie);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "adaugaCategorie";
            this.Text = "adaugaCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCategorie;
    }
}