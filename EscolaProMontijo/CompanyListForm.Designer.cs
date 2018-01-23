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
            this.comboBoxListCompanies = new System.Windows.Forms.ComboBox();
            this.labelList = new System.Windows.Forms.Label();
            this.bindingSourceCompanies = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCompanies = new System.Windows.Forms.DataGridView();
            this.bindingSourceList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(377, 71);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 24);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // comboBoxListCompanies
            // 
            this.comboBoxListCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListCompanies.FormattingEnabled = true;
            this.comboBoxListCompanies.Location = new System.Drawing.Point(47, 71);
            this.comboBoxListCompanies.Name = "comboBoxListCompanies";
            this.comboBoxListCompanies.Size = new System.Drawing.Size(268, 24);
            this.comboBoxListCompanies.TabIndex = 1;
            this.comboBoxListCompanies.SelectedIndexChanged += new System.EventHandler(this.comboBoxListCompanies_SelectedIndexChanged);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(44, 41);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(31, 16);
            this.labelList.TabIndex = 2;
            this.labelList.Text = "List";
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
            this.dataGridViewCompanies.Size = new System.Drawing.Size(1292, 527);
            this.dataGridViewCompanies.TabIndex = 3;
            // 
            // CompanyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1362, 674);
            this.Controls.Add(this.dataGridViewCompanies);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.comboBoxListCompanies);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "CompanyListForm";
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
        private System.Windows.Forms.ComboBox comboBoxListCompanies;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.BindingSource bindingSourceCompanies;
        private System.Windows.Forms.DataGridView dataGridViewCompanies;
        private System.Windows.Forms.BindingSource bindingSourceList;
    }
}