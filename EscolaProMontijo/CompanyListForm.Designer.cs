namespace EscolaProMontijo
{
    partial class CompanyListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.bindingSourceCompanies = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCompanies = new System.Windows.Forms.DataGridView();
            this.bindingSourceList = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.labelSector = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(306, 49);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(115, 24);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Save changes";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // dataGridViewCompanies
            // 
            this.dataGridViewCompanies.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCompanies.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCompanies.Location = new System.Drawing.Point(47, 135);
            this.dataGridViewCompanies.Name = "dataGridViewCompanies";
            this.dataGridViewCompanies.Size = new System.Drawing.Size(1273, 527);
            this.dataGridViewCompanies.TabIndex = 3;
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(47, 49);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(234, 24);
            this.comboBoxSector.TabIndex = 5;
            this.comboBoxSector.SelectedIndexChanged += new System.EventHandler(this.comboBoxSector_SelectedIndexChanged);
            // 
            // labelSector
            // 
            this.labelSector.AutoSize = true;
            this.labelSector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSector.Location = new System.Drawing.Point(44, 30);
            this.labelSector.Name = "labelSector";
            this.labelSector.Size = new System.Drawing.Size(51, 16);
            this.labelSector.TabIndex = 16;
            this.labelSector.Text = "Sector";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(894, 79);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(172, 24);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete the company";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(674, 47);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(208, 26);
            this.comboBoxCompany.TabIndex = 18;
            this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(674, 79);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(208, 26);
            this.comboBoxEmail.TabIndex = 19;
            this.comboBoxEmail.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmail_SelectedIndexChanged);
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.Location = new System.Drawing.Point(601, 47);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(67, 16);
            this.labelCompany.TabIndex = 20;
            this.labelCompany.Text = "Company";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(628, 79);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(40, 16);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Email";
            // 
            // CompanyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1338, 674);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelSector);
            this.Controls.Add(this.comboBoxSector);
            this.Controls.Add(this.dataGridViewCompanies);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "CompanyListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyListForm";
            this.Load += new System.EventHandler(this.CompanyListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.BindingSource bindingSourceCompanies;
        private System.Windows.Forms.DataGridView dataGridViewCompanies;
        private System.Windows.Forms.BindingSource bindingSourceList;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.Label labelSector;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelEmail;
    }
}