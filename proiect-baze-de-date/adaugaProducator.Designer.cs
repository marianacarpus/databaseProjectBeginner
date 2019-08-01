namespace proiect_baze_de_date
{
    partial class adaugaProducator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adaugaProducator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducator = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddProducator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Website:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // txtProducator
            // 
            this.txtProducator.Location = new System.Drawing.Point(174, 30);
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.Size = new System.Drawing.Size(302, 28);
            this.txtProducator.TabIndex = 7;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(174, 76);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(302, 28);
            this.txtWebsite.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(174, 127);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(302, 28);
            this.txtTelefon.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::proiect_baze_de_date.Properties.Resources.if_user_close_36968;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(333, 417);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 52);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddProducator
            // 
            this.btnAddProducator.Image = global::proiect_baze_de_date.Properties.Resources.if_data__add_83623;
            this.btnAddProducator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProducator.Location = new System.Drawing.Point(160, 417);
            this.btnAddProducator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProducator.Name = "btnAddProducator";
            this.btnAddProducator.Size = new System.Drawing.Size(129, 52);
            this.btnAddProducator.TabIndex = 2;
            this.btnAddProducator.Text = "Adauga";
            this.btnAddProducator.UseVisualStyleBackColor = true;
            this.btnAddProducator.Click += new System.EventHandler(this.btnAddProducator_Click);
            // 
            // adaugaProducator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiect_baze_de_date.Properties.Resources.power_sports_1015688_960_720;
            this.ClientSize = new System.Drawing.Size(661, 471);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtProducator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProducator);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adaugaProducator";
            this.Text = "adaugaProducator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddProducator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProducator;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtTelefon;
    }
}