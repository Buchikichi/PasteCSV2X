namespace PasteCSV2X
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CsvTextBox = new System.Windows.Forms.TextBox();
            this.ExcelTextBox = new System.Windows.Forms.TextBox();
            this.EnforceButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChooseCSVButton = new System.Windows.Forms.Button();
            this.ChooseExcelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(701, 7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Excel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CSV";
            // 
            // CsvTextBox
            // 
            this.CsvTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CsvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PasteCSV2X.Properties.Settings.Default, "CsvPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CsvTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.CsvTextBox.Location = new System.Drawing.Point(61, 52);
            this.CsvTextBox.Name = "CsvTextBox";
            this.CsvTextBox.Size = new System.Drawing.Size(675, 23);
            this.CsvTextBox.TabIndex = 1;
            this.CsvTextBox.Text = global::PasteCSV2X.Properties.Settings.Default.CsvPath;
            // 
            // ExcelTextBox
            // 
            this.ExcelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PasteCSV2X.Properties.Settings.Default, "ExcelPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ExcelTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ExcelTextBox.Location = new System.Drawing.Point(61, 16);
            this.ExcelTextBox.Name = "ExcelTextBox";
            this.ExcelTextBox.Size = new System.Drawing.Size(675, 23);
            this.ExcelTextBox.TabIndex = 1;
            this.ExcelTextBox.Text = global::PasteCSV2X.Properties.Settings.Default.ExcelPath;
            // 
            // EnforceButton
            // 
            this.EnforceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnforceButton.BackColor = System.Drawing.Color.PaleGreen;
            this.EnforceButton.Location = new System.Drawing.Point(615, 7);
            this.EnforceButton.Name = "EnforceButton";
            this.EnforceButton.Size = new System.Drawing.Size(80, 30);
            this.EnforceButton.TabIndex = 4;
            this.EnforceButton.Text = "Enforce";
            this.EnforceButton.UseVisualStyleBackColor = false;
            this.EnforceButton.Click += new System.EventHandler(this.EnforceButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EnforceButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 40);
            this.panel1.TabIndex = 5;
            // 
            // ChooseCSVButton
            // 
            this.ChooseCSVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseCSVButton.BackgroundImage = global::PasteCSV2X.Properties.Resources.FolderIcon;
            this.ChooseCSVButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChooseCSVButton.Location = new System.Drawing.Point(742, 48);
            this.ChooseCSVButton.Name = "ChooseCSVButton";
            this.ChooseCSVButton.Size = new System.Drawing.Size(30, 30);
            this.ChooseCSVButton.TabIndex = 2;
            this.ChooseCSVButton.UseVisualStyleBackColor = true;
            this.ChooseCSVButton.Click += new System.EventHandler(this.ChooseCSVButton_Click);
            // 
            // ChooseExcelButton
            // 
            this.ChooseExcelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseExcelButton.BackgroundImage = global::PasteCSV2X.Properties.Resources.ExcelIcon;
            this.ChooseExcelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChooseExcelButton.Location = new System.Drawing.Point(742, 12);
            this.ChooseExcelButton.Name = "ChooseExcelButton";
            this.ChooseExcelButton.Size = new System.Drawing.Size(30, 30);
            this.ChooseExcelButton.TabIndex = 2;
            this.ChooseExcelButton.UseVisualStyleBackColor = true;
            this.ChooseExcelButton.Click += new System.EventHandler(this.ChooseExcelButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(711, 133);
            this.textBox1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseCSVButton);
            this.Controls.Add(this.ChooseExcelButton);
            this.Controls.Add(this.CsvTextBox);
            this.Controls.Add(this.ExcelTextBox);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paste CSV to Excel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox ExcelTextBox;
        private System.Windows.Forms.Button ChooseExcelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CsvTextBox;
        private System.Windows.Forms.Button ChooseCSVButton;
        private System.Windows.Forms.Button EnforceButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

