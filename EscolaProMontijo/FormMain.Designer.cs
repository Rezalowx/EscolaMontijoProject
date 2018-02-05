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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.addListsToolStripMenuViewLists = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuAddACompany = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteACompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCreateASignature = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxEscola = new System.Windows.Forms.PictureBox();
            this.labelCompanyTo = new System.Windows.Forms.Label();
            this.labelSector = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.bindingSourceList = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxSubjectMail = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxBrowse = new System.Windows.Forms.TextBox();
            this.createASignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewList
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewList.Location = new System.Drawing.Point(39, 371);
            this.dataGridViewList.Name = "dataGridViewList";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewList.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewList.Size = new System.Drawing.Size(933, 438);
            this.dataGridViewList.TabIndex = 0;
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.SystemColors.Window;
            this.bt_Send.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send.Location = new System.Drawing.Point(838, 259);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(134, 41);
            this.bt_Send.TabIndex = 1;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = false;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(1210, 604);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 2;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(1051, 604);
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
            this.comboBoxSector.Location = new System.Drawing.Point(1051, 512);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(234, 24);
            this.comboBoxSector.TabIndex = 4;
            this.comboBoxSector.SelectedIndexChanged += new System.EventHandler(this.comboBoxSector_SelectedIndexChanged);
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(1051, 554);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(234, 24);
            this.comboBoxCompany.TabIndex = 5;
            this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
            // 
            // comboBoxSignature
            // 
            this.comboBoxSignature.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSignature.FormattingEnabled = true;
            this.comboBoxSignature.Location = new System.Drawing.Point(838, 229);
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
            this.textBoxTextMail.Size = new System.Drawing.Size(775, 193);
            this.textBoxTextMail.TabIndex = 8;
            // 
            // labelSignature
            // 
            this.labelSignature.AutoSize = true;
            this.labelSignature.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignature.Location = new System.Drawing.Point(835, 210);
            this.labelSignature.Name = "labelSignature";
            this.labelSignature.Size = new System.Drawing.Size(80, 16);
            this.labelSignature.TabIndex = 9;
            this.labelSignature.Text = "Signature :";
            // 
            // labelChooseList
            // 
            this.labelChooseList.AutoSize = true;
            this.labelChooseList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseList.Location = new System.Drawing.Point(289, 312);
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
            this.labelTextMail.Size = new System.Drawing.Size(66, 16);
            this.labelTextMail.TabIndex = 11;
            this.labelTextMail.Text = "Subject :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.addListsToolStripMenuViewLists,
            this.ToolStripMenuAddACompany,
            this.ToolStripMenuCreateASignature});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 24);
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
            // addListsToolStripMenuViewLists
            // 
            this.addListsToolStripMenuViewLists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewListsToolStripMenuItem1,
            this.viewListsToolStripMenuItem2});
            this.addListsToolStripMenuViewLists.Name = "addListsToolStripMenuViewLists";
            this.addListsToolStripMenuViewLists.Size = new System.Drawing.Size(42, 20);
            this.addListsToolStripMenuViewLists.Text = "Lists";
            // 
            // viewListsToolStripMenuItem1
            // 
            this.viewListsToolStripMenuItem1.Name = "viewListsToolStripMenuItem1";
            this.viewListsToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.viewListsToolStripMenuItem1.Text = "Create a list";
            this.viewListsToolStripMenuItem1.Click += new System.EventHandler(this.CreateListsToolStripMenuItem1_Click);
            // 
            // viewListsToolStripMenuItem2
            // 
            this.viewListsToolStripMenuItem2.Name = "viewListsToolStripMenuItem2";
            this.viewListsToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.viewListsToolStripMenuItem2.Text = "View lists";
            this.viewListsToolStripMenuItem2.Click += new System.EventHandler(this.viewListsToolStripMenuItem2_Click);
            // 
            // ToolStripMenuAddACompany
            // 
            this.ToolStripMenuAddACompany.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.viewCompaniesToolStripMenuItem,
            this.deleteACompanyToolStripMenuItem});
            this.ToolStripMenuAddACompany.Name = "ToolStripMenuAddACompany";
            this.ToolStripMenuAddACompany.Size = new System.Drawing.Size(79, 20);
            this.ToolStripMenuAddACompany.Text = "Companies";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modifyToolStripMenuItem.Text = "Add a company";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.addACompanyToolStripMenuItem_Click);
            // 
            // viewCompaniesToolStripMenuItem
            // 
            this.viewCompaniesToolStripMenuItem.Name = "viewCompaniesToolStripMenuItem";
            this.viewCompaniesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewCompaniesToolStripMenuItem.Text = "View companies";
            this.viewCompaniesToolStripMenuItem.Click += new System.EventHandler(this.viewCompaniesToolStripMenuItem_Click);
            // 
            // deleteACompanyToolStripMenuItem
            // 
            this.deleteACompanyToolStripMenuItem.Name = "deleteACompanyToolStripMenuItem";
            this.deleteACompanyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteACompanyToolStripMenuItem.Text = "Delete a company";
            this.deleteACompanyToolStripMenuItem.Click += new System.EventHandler(this.deleteACompanyToolStripMenuItem_Click);
            // 
            // ToolStripMenuCreateASignature
            // 
            this.ToolStripMenuCreateASignature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createASignatureToolStripMenuItem,
            this.modifyToolStripMenuItem1});
            this.ToolStripMenuCreateASignature.Name = "ToolStripMenuCreateASignature";
            this.ToolStripMenuCreateASignature.Size = new System.Drawing.Size(69, 20);
            this.ToolStripMenuCreateASignature.Text = "Signature";
            // 
            // pictureBoxEscola
            // 
            this.pictureBoxEscola.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxEscola.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEscola.Image")));
            this.pictureBoxEscola.Location = new System.Drawing.Point(1075, 27);
            this.pictureBoxEscola.Name = "pictureBoxEscola";
            this.pictureBoxEscola.Size = new System.Drawing.Size(254, 250);
            this.pictureBoxEscola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEscola.TabIndex = 13;
            this.pictureBoxEscola.TabStop = false;
            this.pictureBoxEscola.WaitOnLoad = true;
            // 
            // labelCompanyTo
            // 
            this.labelCompanyTo.AutoSize = true;
            this.labelCompanyTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyTo.Location = new System.Drawing.Point(1048, 469);
            this.labelCompanyTo.Name = "labelCompanyTo";
            this.labelCompanyTo.Size = new System.Drawing.Size(176, 16);
            this.labelCompanyTo.TabIndex = 14;
            this.labelCompanyTo.Text = "Company to add or delete";
            // 
            // labelSector
            // 
            this.labelSector.AutoSize = true;
            this.labelSector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSector.Location = new System.Drawing.Point(1291, 515);
            this.labelSector.Name = "labelSector";
            this.labelSector.Size = new System.Drawing.Size(51, 16);
            this.labelSector.TabIndex = 15;
            this.labelSector.Text = "Sector";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.Location = new System.Drawing.Point(1291, 557);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(67, 16);
            this.labelCompany.TabIndex = 16;
            this.labelCompany.Text = "Company";
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(1051, 669);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(234, 24);
            this.comboBoxEmail.TabIndex = 17;
            this.comboBoxEmail.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(1291, 670);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(40, 16);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "Email";
            this.labelEmail.Visible = false;
            // 
            // textBoxSubjectMail
            // 
            this.textBoxSubjectMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectMail.Location = new System.Drawing.Point(108, 68);
            this.textBoxSubjectMail.Name = "textBoxSubjectMail";
            this.textBoxSubjectMail.Size = new System.Drawing.Size(253, 23);
            this.textBoxSubjectMail.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBrowse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(734, 78);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(80, 23);
            this.buttonBrowse.TabIndex = 20;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxBrowse
            // 
            this.textBoxBrowse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrowse.Location = new System.Drawing.Point(472, 41);
            this.textBoxBrowse.Multiline = true;
            this.textBoxBrowse.Name = "textBoxBrowse";
            this.textBoxBrowse.Size = new System.Drawing.Size(256, 60);
            this.textBoxBrowse.TabIndex = 21;
            // 
            // createASignatureToolStripMenuItem
            // 
            this.createASignatureToolStripMenuItem.Name = "createASignatureToolStripMenuItem";
            this.createASignatureToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.createASignatureToolStripMenuItem.Text = "Create a signature";
            this.createASignatureToolStripMenuItem.Click += new System.EventHandler(this.createASignatureToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.modifyToolStripMenuItem1.Text = "Modify...";
            this.modifyToolStripMenuItem1.Click += new System.EventHandler(this.modifyToolStripMenuItem1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 882);
            this.Controls.Add(this.textBoxBrowse);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxSubjectMail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.labelSector);
            this.Controls.Add(this.labelCompanyTo);
            this.Controls.Add(this.pictureBoxEscola);
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
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscola)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxEscola;
        private System.Windows.Forms.Label labelCompanyTo;
        private System.Windows.Forms.Label labelSector;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addACompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addListsToolStripMenuViewLists;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuAddACompany;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuCreateASignature;
        private System.Windows.Forms.BindingSource bindingSourceList;
        private System.Windows.Forms.ToolStripMenuItem viewListsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewCompaniesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteACompanyToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxSubjectMail;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxBrowse;
        private System.Windows.Forms.ToolStripMenuItem createASignatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
    }
}

