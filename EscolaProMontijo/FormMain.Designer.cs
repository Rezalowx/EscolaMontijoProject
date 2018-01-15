namespace EscolaProMontijo
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.bt_Send = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxSignature = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseList = new System.Windows.Forms.ComboBox();
            this.textBoxTextMail = new System.Windows.Forms.TextBox();
            this.labelSignature = new System.Windows.Forms.Label();
            this.labelChooseList = new System.Windows.Forms.Label();
            this.labelTextMail = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addACompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAListToolStripMenuCreateList = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListsToolStripMenuViewLists = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuAddACompany = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCreateASignature = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCompanyTo = new System.Windows.Forms.Label();
            this.labelSector = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSourceList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewList
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(39, 361);
            this.dataGridViewList.Name = "dataGridViewList";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewList.Size = new System.Drawing.Size(933, 342);
            this.dataGridViewList.TabIndex = 0;
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.SystemColors.Window;
            this.bt_Send.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send.Location = new System.Drawing.Point(838, 236);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(134, 41);
            this.bt_Send.TabIndex = 1;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = false;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(1181, 526);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 2;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(1022, 526);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 3;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(1022, 439);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(234, 24);
            this.comboBoxSector.TabIndex = 4;
            this.comboBoxSector.SelectedIndexChanged += new System.EventHandler(this.comboBoxSector_SelectedIndexChanged);
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(1022, 482);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(234, 24);
            this.comboBoxCompany.TabIndex = 5;
            // 
            // comboBoxSignature
            // 
            this.comboBoxSignature.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSignature.FormattingEnabled = true;
            this.comboBoxSignature.Location = new System.Drawing.Point(838, 199);
            this.comboBoxSignature.Name = "comboBoxSignature";
            this.comboBoxSignature.Size = new System.Drawing.Size(134, 24);
            this.comboBoxSignature.TabIndex = 6;
            // 
            // comboBoxChooseList
            // 
            this.comboBoxChooseList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseList.FormattingEnabled = true;
            this.comboBoxChooseList.Location = new System.Drawing.Point(292, 331);
            this.comboBoxChooseList.Name = "comboBoxChooseList";
            this.comboBoxChooseList.Size = new System.Drawing.Size(246, 24);
            this.comboBoxChooseList.TabIndex = 7;
            this.comboBoxChooseList.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseList_SelectedIndexChanged);
            // 
            // textBoxTextMail
            // 
            this.textBoxTextMail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextMail.Location = new System.Drawing.Point(39, 107);
            this.textBoxTextMail.Multiline = true;
            this.textBoxTextMail.Name = "textBoxTextMail";
            this.textBoxTextMail.Size = new System.Drawing.Size(775, 170);
            this.textBoxTextMail.TabIndex = 8;
            // 
            // labelSignature
            // 
            this.labelSignature.AutoSize = true;
            this.labelSignature.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignature.Location = new System.Drawing.Point(835, 180);
            this.labelSignature.Name = "labelSignature";
            this.labelSignature.Size = new System.Drawing.Size(80, 16);
            this.labelSignature.TabIndex = 9;
            this.labelSignature.Text = "Signature :";
            // 
            // labelChooseList
            // 
            this.labelChooseList.AutoSize = true;
            this.labelChooseList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseList.Location = new System.Drawing.Point(289, 303);
            this.labelChooseList.Name = "labelChooseList";
            this.labelChooseList.Size = new System.Drawing.Size(99, 16);
            this.labelChooseList.TabIndex = 10;
            this.labelChooseList.Text = "Choose a list :";
            this.labelChooseList.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTextMail
            // 
            this.labelTextMail.AutoSize = true;
            this.labelTextMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextMail.Location = new System.Drawing.Point(36, 71);
            this.labelTextMail.Name = "labelTextMail";
            this.labelTextMail.Size = new System.Drawing.Size(49, 16);
            this.labelTextMail.TabIndex = 11;
            this.labelTextMail.Text = "Email :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.addAListToolStripMenuCreateList,
            this.viewListsToolStripMenuViewLists,
            this.ToolStripMenuAddACompany,
            this.ToolStripMenuCreateASignature});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addACompanyToolStripMenuItem,
            this.viewListsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // addACompanyToolStripMenuItem
            // 
            this.addACompanyToolStripMenuItem.Name = "addACompanyToolStripMenuItem";
            this.addACompanyToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addACompanyToolStripMenuItem.Text = "User documentation";
            // 
            // viewListsToolStripMenuItem
            // 
            this.viewListsToolStripMenuItem.Name = "viewListsToolStripMenuItem";
            this.viewListsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewListsToolStripMenuItem.Text = "Release notes";
            // 
            // addAListToolStripMenuCreateList
            // 
            this.addAListToolStripMenuCreateList.Name = "addAListToolStripMenuCreateList";
            this.addAListToolStripMenuCreateList.Size = new System.Drawing.Size(80, 20);
            this.addAListToolStripMenuCreateList.Text = "Create a list";
            this.addAListToolStripMenuCreateList.Click += new System.EventHandler(this.addAListToolStripMenuCreateList_Click);
            // 
            // viewListsToolStripMenuViewLists
            // 
            this.viewListsToolStripMenuViewLists.Name = "viewListsToolStripMenuViewLists";
            this.viewListsToolStripMenuViewLists.Size = new System.Drawing.Size(67, 20);
            this.viewListsToolStripMenuViewLists.Text = "View lists";
            // 
            // ToolStripMenuAddACompany
            // 
            this.ToolStripMenuAddACompany.Name = "ToolStripMenuAddACompany";
            this.ToolStripMenuAddACompany.Size = new System.Drawing.Size(103, 20);
            this.ToolStripMenuAddACompany.Text = "Add a company";
            // 
            // ToolStripMenuCreateASignature
            // 
            this.ToolStripMenuCreateASignature.Name = "ToolStripMenuCreateASignature";
            this.ToolStripMenuCreateASignature.Size = new System.Drawing.Size(114, 20);
            this.ToolStripMenuCreateASignature.Text = "Create a signature";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1075, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // labelCompanyTo
            // 
            this.labelCompanyTo.AutoSize = true;
            this.labelCompanyTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyTo.Location = new System.Drawing.Point(1019, 401);
            this.labelCompanyTo.Name = "labelCompanyTo";
            this.labelCompanyTo.Size = new System.Drawing.Size(176, 16);
            this.labelCompanyTo.TabIndex = 14;
            this.labelCompanyTo.Text = "Company to add or delete";
            // 
            // labelSector
            // 
            this.labelSector.AutoSize = true;
            this.labelSector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSector.Location = new System.Drawing.Point(1262, 442);
            this.labelSector.Name = "labelSector";
            this.labelSector.Size = new System.Drawing.Size(51, 16);
            this.labelSector.TabIndex = 15;
            this.labelSector.Text = "Sector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1262, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Company";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 707);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSector);
            this.Controls.Add(this.labelCompanyTo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTextMail);
            this.Controls.Add(this.labelChooseList);
            this.Controls.Add(this.labelSignature);
            this.Controls.Add(this.textBoxTextMail);
            this.Controls.Add(this.comboBoxChooseList);
            this.Controls.Add(this.comboBoxSignature);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.comboBoxSector);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxSignature;
        private System.Windows.Forms.ComboBox comboBoxChooseList;
        private System.Windows.Forms.TextBox textBoxTextMail;
        private System.Windows.Forms.Label labelSignature;
        private System.Windows.Forms.Label labelChooseList;
        private System.Windows.Forms.Label labelTextMail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCompanyTo;
        private System.Windows.Forms.Label labelSector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addACompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAListToolStripMenuCreateList;
        private System.Windows.Forms.ToolStripMenuItem viewListsToolStripMenuViewLists;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuAddACompany;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuCreateASignature;
        private System.Windows.Forms.BindingSource bindingSourceList;
    }
}

