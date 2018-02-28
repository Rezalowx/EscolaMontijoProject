namespace EscolaProMontijo
{
    partial class ModifyASignature
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSignature = new System.Windows.Forms.TextBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.buttonDeleteSignature = new System.Windows.Forms.Button();
            this.checkBoxDefaultSignature = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Signature";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(131, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 16);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // textBoxSignature
            // 
            this.textBoxSignature.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignature.Location = new System.Drawing.Point(134, 220);
            this.textBoxSignature.Multiline = true;
            this.textBoxSignature.Name = "textBoxSignature";
            this.textBoxSignature.Size = new System.Drawing.Size(558, 140);
            this.textBoxSignature.TabIndex = 10;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(565, 375);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(127, 24);
            this.buttonSaveChanges.TabIndex = 7;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // comboBoxName
            // 
            this.comboBoxName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(134, 106);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(228, 24);
            this.comboBoxName.TabIndex = 14;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // buttonDeleteSignature
            // 
            this.buttonDeleteSignature.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSignature.Location = new System.Drawing.Point(134, 375);
            this.buttonDeleteSignature.Name = "buttonDeleteSignature";
            this.buttonDeleteSignature.Size = new System.Drawing.Size(127, 24);
            this.buttonDeleteSignature.TabIndex = 15;
            this.buttonDeleteSignature.Text = "Delete signature";
            this.buttonDeleteSignature.UseVisualStyleBackColor = true;
            this.buttonDeleteSignature.Click += new System.EventHandler(this.buttonDeleteSignature_Click);
            // 
            // checkBoxDefaultSignature
            // 
            this.checkBoxDefaultSignature.AutoSize = true;
            this.checkBoxDefaultSignature.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDefaultSignature.Location = new System.Drawing.Point(419, 379);
            this.checkBoxDefaultSignature.Name = "checkBoxDefaultSignature";
            this.checkBoxDefaultSignature.Size = new System.Drawing.Size(140, 20);
            this.checkBoxDefaultSignature.TabIndex = 16;
            this.checkBoxDefaultSignature.Text = "Default signature";
            this.checkBoxDefaultSignature.UseVisualStyleBackColor = true;
            // 
            // ModifyASignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 446);
            this.Controls.Add(this.checkBoxDefaultSignature);
            this.Controls.Add(this.buttonDeleteSignature);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSignature);
            this.Controls.Add(this.buttonSaveChanges);
            this.Name = "ModifyASignature";
            this.Text = "ModifyASignature";
            this.Load += new System.EventHandler(this.ModifyASignature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSignature;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button buttonDeleteSignature;
        private System.Windows.Forms.CheckBox checkBoxDefaultSignature;
    }
}