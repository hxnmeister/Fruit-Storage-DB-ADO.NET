namespace Домашня_робота
{
    partial class Form1
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
            this.FaVDataGridView = new System.Windows.Forms.DataGridView();
            this.OptionsComboBox = new System.Windows.Forms.ComboBox();
            this.ExecuteCMDButton = new System.Windows.Forms.Button();
            this.DBTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ParametersTextBox = new System.Windows.Forms.TextBox();
            this.ParametersTextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FaVDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FaVDataGridView
            // 
            this.FaVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FaVDataGridView.Location = new System.Drawing.Point(12, 12);
            this.FaVDataGridView.Name = "FaVDataGridView";
            this.FaVDataGridView.ReadOnly = true;
            this.FaVDataGridView.Size = new System.Drawing.Size(776, 351);
            this.FaVDataGridView.TabIndex = 0;
            // 
            // OptionsComboBox
            // 
            this.OptionsComboBox.Enabled = false;
            this.OptionsComboBox.FormattingEnabled = true;
            this.OptionsComboBox.Items.AddRange(new object[] {
            "Відображення всієї інформації з таблиці овочів та фруктів",
            "Відображення всіх назв овочів та фруктів",
            "Відображення всіх кольорів",
            "Показати максимальну калорійність",
            "Показати мінімальну калорійність",
            "Показати середню калорійність",
            "Показати кількість овочів",
            "Показати кількість фруктів",
            "Показати кількість овочів та фруктів заданого кольору",
            "Показати кількість овочів та фруктів кожного кольору",
            "Показати овочі та фрукти з калорійністю нижче вказаної",
            "Показати овочі та фрукти з калорійністю вище вказаної",
            "Показати овочі та фрукти з калорійністю у вказаному діапазоні",
            "Показати всі овочі та фрукти, у яких колір жовтий або червоний."});
            this.OptionsComboBox.Location = new System.Drawing.Point(12, 369);
            this.OptionsComboBox.Name = "OptionsComboBox";
            this.OptionsComboBox.Size = new System.Drawing.Size(776, 21);
            this.OptionsComboBox.TabIndex = 1;
            this.OptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.OptionsComboBox_SelectedIndexChanged);
            // 
            // ExecuteCMDButton
            // 
            this.ExecuteCMDButton.Enabled = false;
            this.ExecuteCMDButton.Location = new System.Drawing.Point(713, 396);
            this.ExecuteCMDButton.Name = "ExecuteCMDButton";
            this.ExecuteCMDButton.Size = new System.Drawing.Size(75, 42);
            this.ExecuteCMDButton.TabIndex = 2;
            this.ExecuteCMDButton.Text = "Виконати Запит";
            this.ExecuteCMDButton.UseVisualStyleBackColor = true;
            this.ExecuteCMDButton.Click += new System.EventHandler(this.ExecuteCMDButton_Click);
            // 
            // DBTypeComboBox
            // 
            this.DBTypeComboBox.FormattingEnabled = true;
            this.DBTypeComboBox.Location = new System.Drawing.Point(12, 396);
            this.DBTypeComboBox.Name = "DBTypeComboBox";
            this.DBTypeComboBox.Size = new System.Drawing.Size(388, 21);
            this.DBTypeComboBox.TabIndex = 3;
            this.DBTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.DBTypeComboBox_SelectedIndexChanged);
            // 
            // ParametersTextBox
            // 
            this.ParametersTextBox.Enabled = false;
            this.ParametersTextBox.Location = new System.Drawing.Point(406, 396);
            this.ParametersTextBox.Name = "ParametersTextBox";
            this.ParametersTextBox.Size = new System.Drawing.Size(301, 20);
            this.ParametersTextBox.TabIndex = 4;
            // 
            // ParametersTextBox1
            // 
            this.ParametersTextBox1.Location = new System.Drawing.Point(406, 423);
            this.ParametersTextBox1.Name = "ParametersTextBox1";
            this.ParametersTextBox1.Size = new System.Drawing.Size(301, 20);
            this.ParametersTextBox1.TabIndex = 5;
            this.ParametersTextBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParametersTextBox1);
            this.Controls.Add(this.ParametersTextBox);
            this.Controls.Add(this.DBTypeComboBox);
            this.Controls.Add(this.ExecuteCMDButton);
            this.Controls.Add(this.OptionsComboBox);
            this.Controls.Add(this.FaVDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FaVDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FaVDataGridView;
        private System.Windows.Forms.ComboBox OptionsComboBox;
        private System.Windows.Forms.Button ExecuteCMDButton;
        private System.Windows.Forms.ComboBox DBTypeComboBox;
        private System.Windows.Forms.TextBox ParametersTextBox;
        private System.Windows.Forms.TextBox ParametersTextBox1;
    }
}

