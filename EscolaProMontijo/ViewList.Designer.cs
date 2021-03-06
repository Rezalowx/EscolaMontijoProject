﻿namespace EscolaProMontijo
{
    partial class ViewList
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
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.labelChooseAList = new System.Windows.Forms.Label();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.bindingSourceList = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDeleteList = new System.Windows.Forms.Button();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.buttonDeleteCompany = new System.Windows.Forms.Button();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxList
            // 
            this.comboBoxList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Location = new System.Drawing.Point(56, 60);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(335, 24);
            this.comboBoxList.TabIndex = 0;
            this.comboBoxList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelChooseAList
            // 
            this.labelChooseAList.AutoSize = true;
            this.labelChooseAList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseAList.Location = new System.Drawing.Point(53, 41);
            this.labelChooseAList.Name = "labelChooseAList";
            this.labelChooseAList.Size = new System.Drawing.Size(90, 16);
            this.labelChooseAList.TabIndex = 1;
            this.labelChooseAList.Text = "Choose a list";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(56, 154);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(1248, 506);
            this.dataGridViewList.TabIndex = 2;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellContentClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(418, 60);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(126, 24);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Save changes";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDeleteList
            // 
            this.buttonDeleteList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteList.Location = new System.Drawing.Point(572, 61);
            this.buttonDeleteList.Name = "buttonDeleteList";
            this.buttonDeleteList.Size = new System.Drawing.Size(113, 23);
            this.buttonDeleteList.TabIndex = 4;
            this.buttonDeleteList.Text = "Delete the list";
            this.buttonDeleteList.UseVisualStyleBackColor = true;
            this.buttonDeleteList.Click += new System.EventHandler(this.buttonDeleteList_Click);
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(56, 115);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(179, 24);
            this.comboBoxCompany.TabIndex = 5;
            this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.Location = new System.Drawing.Point(53, 96);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(130, 16);
            this.labelCompany.TabIndex = 6;
            this.labelCompany.Text = "Choose a Company";
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCompany.Location = new System.Drawing.Point(250, 115);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(61, 24);
            this.buttonAddCompany.TabIndex = 7;
            this.buttonAddCompany.Text = "Add";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            this.buttonAddCompany.Click += new System.EventHandler(this.buttonAddCompany_Click);
            // 
            // buttonDeleteCompany
            // 
            this.buttonDeleteCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCompany.Location = new System.Drawing.Point(329, 115);
            this.buttonDeleteCompany.Name = "buttonDeleteCompany";
            this.buttonDeleteCompany.Size = new System.Drawing.Size(62, 24);
            this.buttonDeleteCompany.TabIndex = 8;
            this.buttonDeleteCompany.Text = "Delete";
            this.buttonDeleteCompany.UseVisualStyleBackColor = true;
            this.buttonDeleteCompany.Click += new System.EventHandler(this.buttonDeleteCompany_Click);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(418, 115);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(209, 24);
            this.comboBoxEmail.TabIndex = 9;
            this.comboBoxEmail.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(415, 96);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 16);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email :";
            this.labelEmail.Visible = false;
            // 
            // ViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1330, 682);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.buttonDeleteCompany);
            this.Controls.Add(this.buttonAddCompany);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.buttonDeleteList);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.labelChooseAList);
            this.Controls.Add(this.comboBoxList);
            this.Name = "ViewList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewList";
            this.Load += new System.EventHandler(this.ViewList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.Label labelChooseAList;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.BindingSource bindingSourceList;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDeleteList;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.Button buttonDeleteCompany;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Label labelEmail;
    }
}