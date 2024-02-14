
namespace generator_of_passwords
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            outTextBox = new System.Windows.Forms.TextBox();
            generateBut = new System.Windows.Forms.Button();
            LangComboBox = new System.Windows.Forms.ComboBox();
            NumbersBox = new System.Windows.Forms.CheckBox();
            TextLittleBox = new System.Windows.Forms.CheckBox();
            TextBigBox = new System.Windows.Forms.CheckBox();
            SpecialSymbolsBox = new System.Windows.Forms.CheckBox();
            LenghtLabel = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // outTextBox
            // 
            outTextBox.Location = new System.Drawing.Point(143, 59);
            outTextBox.Name = "outTextBox";
            outTextBox.ReadOnly = true;
            outTextBox.Size = new System.Drawing.Size(200, 23);
            outTextBox.TabIndex = 0;
            // 
            // generateBut
            // 
            generateBut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            generateBut.Location = new System.Drawing.Point(143, 287);
            generateBut.Name = "generateBut";
            generateBut.Size = new System.Drawing.Size(200, 50);
            generateBut.TabIndex = 1;
            generateBut.Text = "Сгенерировать пароль";
            generateBut.UseVisualStyleBackColor = true;
            generateBut.Click += generateBut_Click;
            // 
            // LangComboBox
            // 
            LangComboBox.FormattingEnabled = true;
            LangComboBox.Items.AddRange(new object[] { "Русский ", "Українська", "English", "Espanol" });
            LangComboBox.Location = new System.Drawing.Point(361, 12);
            LangComboBox.Name = "LangComboBox";
            LangComboBox.Size = new System.Drawing.Size(111, 23);
            LangComboBox.TabIndex = 2;
            LangComboBox.SelectedIndexChanged += LangComboBox_SelectedIndexChanged;
            // 
            // NumbersBox
            // 
            NumbersBox.AutoSize = true;
            NumbersBox.Location = new System.Drawing.Point(20, 152);
            NumbersBox.Name = "NumbersBox";
            NumbersBox.Size = new System.Drawing.Size(83, 19);
            NumbersBox.TabIndex = 3;
            NumbersBox.Text = "checkBox1";
            NumbersBox.UseVisualStyleBackColor = true;
            // 
            // TextLittleBox
            // 
            TextLittleBox.AutoSize = true;
            TextLittleBox.Location = new System.Drawing.Point(20, 177);
            TextLittleBox.Name = "TextLittleBox";
            TextLittleBox.Size = new System.Drawing.Size(83, 19);
            TextLittleBox.TabIndex = 4;
            TextLittleBox.Text = "checkBox2";
            TextLittleBox.UseVisualStyleBackColor = true;
            // 
            // TextBigBox
            // 
            TextBigBox.AutoSize = true;
            TextBigBox.Location = new System.Drawing.Point(20, 202);
            TextBigBox.Name = "TextBigBox";
            TextBigBox.Size = new System.Drawing.Size(83, 19);
            TextBigBox.TabIndex = 5;
            TextBigBox.Text = "checkBox3";
            TextBigBox.UseVisualStyleBackColor = true;
            // 
            // SpecialSymbolsBox
            // 
            SpecialSymbolsBox.AutoSize = true;
            SpecialSymbolsBox.Location = new System.Drawing.Point(20, 227);
            SpecialSymbolsBox.Name = "SpecialSymbolsBox";
            SpecialSymbolsBox.Size = new System.Drawing.Size(83, 19);
            SpecialSymbolsBox.TabIndex = 6;
            SpecialSymbolsBox.Text = "checkBox4";
            SpecialSymbolsBox.UseVisualStyleBackColor = true;
            // 
            // LenghtLabel
            // 
            LenghtLabel.AutoSize = true;
            LenghtLabel.Location = new System.Drawing.Point(20, 105);
            LenghtLabel.Name = "LenghtLabel";
            LenghtLabel.Size = new System.Drawing.Size(153, 15);
            LenghtLabel.TabIndex = 7;
            LenghtLabel.Text = "Длина желаемого пароля:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(66, 123);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(50, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 361);
            Controls.Add(numericUpDown1);
            Controls.Add(LenghtLabel);
            Controls.Add(SpecialSymbolsBox);
            Controls.Add(TextBigBox);
            Controls.Add(TextLittleBox);
            Controls.Add(NumbersBox);
            Controls.Add(LangComboBox);
            Controls.Add(generateBut);
            Controls.Add(outTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox outTextBox;
        private System.Windows.Forms.Button generateBut;
        private System.Windows.Forms.ComboBox LangComboBox;
        private System.Windows.Forms.CheckBox NumbersBox;
        private System.Windows.Forms.CheckBox TextLittleBox;
        private System.Windows.Forms.CheckBox TextBigBox;
        private System.Windows.Forms.CheckBox SpecialSymbolsBox;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

