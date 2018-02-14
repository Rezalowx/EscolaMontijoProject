namespace EscolaProMontijo
{
    partial class sector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSector = new System.Windows.Forms.DataGridView();
            this.bindingSourceSector = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.textBoxSector = new System.Windows.Forms.TextBox();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSector)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSector
            // 
            this.dataGridViewSector.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSector.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSector.Location = new System.Drawing.Point(63, 145);
            this.dataGridViewSector.Name = "dataGridViewSector";
            this.dataGridViewSector.Size = new System.Drawing.Size(702, 389);
            this.dataGridViewSector.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(638, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(278, 62);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(111, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Add";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(278, 115);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 24);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(60, 43);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(92, 16);
            this.labelAdd.TabIndex = 4;
            this.labelAdd.Text = "Add a sector";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.Location = new System.Drawing.Point(60, 96);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(108, 16);
            this.labelDelete.TabIndex = 5;
            this.labelDelete.Text = "Delete a sector";
            // 
            // textBoxSector
            // 
            this.textBoxSector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSector.Location = new System.Drawing.Point(63, 62);
            this.textBoxSector.Name = "textBoxSector";
            this.textBoxSector.Size = new System.Drawing.Size(197, 23);
            this.textBoxSector.TabIndex = 6;
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(63, 115);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(197, 24);
            this.comboBoxSector.TabIndex = 7;
            // 
            // sector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 581);
            this.Controls.Add(this.comboBoxSector);
            this.Controls.Add(this.textBoxSector);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSector);
            this.Name = "sector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "sector";
            this.Load += new System.EventHandler(this.sector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSector;
        private System.Windows.Forms.BindingSource bindingSourceSector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.TextBox textBoxSector;
        private System.Windows.Forms.ComboBox comboBoxSector;
    }
}