namespace proiect_baze_de_date
{
    partial class adaugaComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adaugaComanda));
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.dataPlasare = new System.Windows.Forms.DateTimePicker();
            this.cmbProdus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataLivrare = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddComanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantitate
            // 
            this.txtCantitate.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantitate.Location = new System.Drawing.Point(161, 148);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(252, 32);
            this.txtCantitate.TabIndex = 17;
            // 
            // dataPlasare
            // 
            this.dataPlasare.CustomFormat = "MMM-dd-yyyy";
            this.dataPlasare.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPlasare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataPlasare.Location = new System.Drawing.Point(161, 64);
            this.dataPlasare.MaxDate = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
            this.dataPlasare.Name = "dataPlasare";
            this.dataPlasare.Size = new System.Drawing.Size(252, 32);
            this.dataPlasare.TabIndex = 16;
            this.dataPlasare.Value = new System.DateTime(2018, 5, 8, 0, 0, 0, 0);
            // 
            // cmbProdus
            // 
            this.cmbProdus.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdus.FormattingEnabled = true;
            this.cmbProdus.Location = new System.Drawing.Point(161, 12);
            this.cmbProdus.Name = "cmbProdus";
            this.cmbProdus.Size = new System.Drawing.Size(252, 32);
            this.cmbProdus.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantitate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data Plasare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Produs:";
            // 
            // dataLivrare
            // 
            this.dataLivrare.CustomFormat = "MMM-dd-yyyy";
            this.dataLivrare.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLivrare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataLivrare.Location = new System.Drawing.Point(161, 110);
            this.dataLivrare.MaxDate = new System.DateTime(2019, 12, 13, 0, 0, 0, 0);
            this.dataLivrare.Name = "dataLivrare";
            this.dataLivrare.Size = new System.Drawing.Size(252, 32);
            this.dataLivrare.TabIndex = 21;
            this.dataLivrare.Value = new System.DateTime(2018, 5, 8, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data Livrare:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::proiect_baze_de_date.Properties.Resources.if_user_close_36968;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(267, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "renunta";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddComanda
            // 
            this.btnAddComanda.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComanda.Image = global::proiect_baze_de_date.Properties.Resources.if_data__add_83623;
            this.btnAddComanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddComanda.Location = new System.Drawing.Point(54, 299);
            this.btnAddComanda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddComanda.Name = "btnAddComanda";
            this.btnAddComanda.Size = new System.Drawing.Size(135, 40);
            this.btnAddComanda.TabIndex = 18;
            this.btnAddComanda.Text = "adauga";
            this.btnAddComanda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddComanda.UseVisualStyleBackColor = true;
            this.btnAddComanda.Click += new System.EventHandler(this.btnAddComanda_Click);
            // 
            // adaugaComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiect_baze_de_date.Properties.Resources.olympics_1613101_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 352);
            this.Controls.Add(this.dataLivrare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddComanda);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.dataPlasare);
            this.Controls.Add(this.cmbProdus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adaugaComanda";
            this.Text = "adaugaComanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.DateTimePicker dataPlasare;
        private System.Windows.Forms.ComboBox cmbProdus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddComanda;
        private System.Windows.Forms.DateTimePicker dataLivrare;
        private System.Windows.Forms.Label label5;
    }
}