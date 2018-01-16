namespace EscolaProMontijo
{
    partial class AddACompany
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
            this.buttonSaveCompany = new System.Windows.Forms.Button();
            this.textBoxNameCompany = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxEmailCompany = new System.Windows.Forms.TextBox();
            this.textBoxAddressCompany = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveCompany
            // 
            this.buttonSaveCompany.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCompany.Location = new System.Drawing.Point(413, 189);
            this.buttonSaveCompany.Name = "buttonSaveCompany";
            this.buttonSaveCompany.Size = new System.Drawing.Size(75, 27);
            this.buttonSaveCompany.TabIndex = 0;
            this.buttonSaveCompany.Text = "Save";
            this.buttonSaveCompany.UseVisualStyleBackColor = true;
            this.buttonSaveCompany.Click += new System.EventHandler(this.buttonSaveCompany_Click);
            // 
            // textBoxNameCompany
            // 
            this.textBoxNameCompany.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameCompany.Location = new System.Drawing.Point(50, 88);
            this.textBoxNameCompany.Name = "textBoxNameCompany";
            this.textBoxNameCompany.Size = new System.Drawing.Size(151, 26);
            this.textBoxNameCompany.TabIndex = 1;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.Location = new System.Drawing.Point(495, 88);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(150, 26);
            this.textBoxNumero.TabIndex = 2;
            // 
            // textBoxEmailCompany
            // 
            this.textBoxEmailCompany.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailCompany.Location = new System.Drawing.Point(269, 88);
            this.textBoxEmailCompany.Name = "textBoxEmailCompany";
            this.textBoxEmailCompany.Size = new System.Drawing.Size(150, 26);
            this.textBoxEmailCompany.TabIndex = 3;
            // 
            // textBoxAddressCompany
            // 
            this.textBoxAddressCompany.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddressCompany.Location = new System.Drawing.Point(720, 88);
            this.textBoxAddressCompany.Name = "textBoxAddressCompany";
            this.textBoxAddressCompany.Size = new System.Drawing.Size(150, 26);
            this.textBoxAddressCompany.TabIndex = 4;
            this.textBoxAddressCompany.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(47, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 18);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(266, 53);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 18);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(492, 53);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(60, 18);
            this.labelNumero.TabIndex = 7;
            this.labelNumero.Text = "Numero";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.Location = new System.Drawing.Point(717, 53);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(60, 18);
            this.labeladdress.TabIndex = 8;
            this.labeladdress.Text = "Address";
            // 
            // AddACompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(955, 306);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAddressCompany);
            this.Controls.Add(this.textBoxEmailCompany);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxNameCompany);
            this.Controls.Add(this.buttonSaveCompany);
            this.Name = "AddACompany";
            this.Text = "AddACompany";
            this.Load += new System.EventHandler(this.AddACompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveCompany;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxEmailCompany;
        private System.Windows.Forms.TextBox textBoxAddressCompany;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labeladdress;
    }
}