namespace AlgorithmsView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SortingComboBox = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.SortingPanel = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CompareLabel = new System.Windows.Forms.Label();
            this.SwopLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.SettingsPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.SortingComboBox);
            this.SettingsPanel.Controls.Add(this.SortButton);
            this.SettingsPanel.Controls.Add(this.CountLabel);
            this.SettingsPanel.Controls.Add(this.GenerateButton);
            this.SettingsPanel.Controls.Add(this.SizeTextBox);
            this.SettingsPanel.Location = new System.Drawing.Point(4, 4);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(193, 119);
            this.SettingsPanel.TabIndex = 0;
            // 
            // SortingComboBox
            // 
            this.SortingComboBox.FormattingEnabled = true;
            this.SortingComboBox.Location = new System.Drawing.Point(9, 60);
            this.SortingComboBox.Name = "SortingComboBox";
            this.SortingComboBox.Size = new System.Drawing.Size(173, 21);
            this.SortingComboBox.TabIndex = 2;
            this.SortingComboBox.Text = "Пузырек";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(8, 87);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(170, 23);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(9, 9);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(174, 13);
            this.CountLabel.TabIndex = 3;
            this.CountLabel.Text = "Введите колличество элементов";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(90, 34);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(93, 20);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(9, 34);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(75, 20);
            this.SizeTextBox.TabIndex = 0;
            // 
            // SortingPanel
            // 
            this.SortingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortingPanel.Location = new System.Drawing.Point(196, 4);
            this.SortingPanel.Name = "SortingPanel";
            this.SortingPanel.Size = new System.Drawing.Size(1701, 434);
            this.SortingPanel.TabIndex = 1;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(8, 20);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(46, 13);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Время: ";
            // 
            // CompareLabel
            // 
            this.CompareLabel.AutoSize = true;
            this.CompareLabel.Location = new System.Drawing.Point(8, 54);
            this.CompareLabel.Name = "CompareLabel";
            this.CompareLabel.Size = new System.Drawing.Size(104, 13);
            this.CompareLabel.TabIndex = 3;
            this.CompareLabel.Text = "Кол-во сравнений: ";
            // 
            // SwopLabel
            // 
            this.SwopLabel.AutoSize = true;
            this.SwopLabel.Location = new System.Drawing.Point(9, 84);
            this.SwopLabel.Name = "SwopLabel";
            this.SwopLabel.Size = new System.Drawing.Size(121, 13);
            this.SwopLabel.TabIndex = 4;
            this.SwopLabel.Text = "Кол-во перестановок: ";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.SwopLabel);
            this.InfoPanel.Controls.Add(this.TimeLabel);
            this.InfoPanel.Controls.Add(this.CompareLabel);
            this.InfoPanel.Location = new System.Drawing.Point(4, 121);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(193, 119);
            this.InfoPanel.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 258);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 180);
            this.textBox1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(4, 258);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 180);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SortingPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Panel SortingPanel;
        private System.Windows.Forms.ComboBox SortingComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CompareLabel;
        private System.Windows.Forms.Label SwopLabel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

