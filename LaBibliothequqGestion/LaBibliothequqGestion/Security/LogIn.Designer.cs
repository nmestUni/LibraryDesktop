namespace LaBibliothequqGestion.Security
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Upload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PswField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Upload.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Upload.Location = new System.Drawing.Point(132, 307);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(214, 49);
            this.Upload.TabIndex = 11;
            this.Upload.Text = "ავტორიზაცია";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(23, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "პაროლი";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "სახელი";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PswField
            // 
            this.PswField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PswField.Location = new System.Drawing.Point(23, 244);
            this.PswField.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.PswField.Name = "PswField";
            this.PswField.Size = new System.Drawing.Size(433, 22);
            this.PswField.TabIndex = 8;
            // 
            // NameField
            // 
            this.NameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameField.Location = new System.Drawing.Point(23, 148);
            this.NameField.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(433, 22);
            this.NameField.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "La Bibliotheque Gestion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reg
            // 
            this.reg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reg.Location = new System.Drawing.Point(132, 397);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(214, 49);
            this.reg.TabIndex = 13;
            this.reg.Text = "რეგისტრაცია";
            this.reg.UseVisualStyleBackColor = false;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.reg, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Upload, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.NameField, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.PswField, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 467);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ავტორიზაცია";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PswField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}