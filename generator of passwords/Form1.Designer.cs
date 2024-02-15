
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(305, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 15);
            label1.TabIndex = 9;
            label1.Text = "Сохранять пароли в файл?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(305, 152);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(166, 15);
            label2.TabIndex = 12;
            label2.Text = "Выберите куда их сохранять:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(306, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(166, 23);
            textBox1.TabIndex = 15;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(6, 7);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(99, 19);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Дефолт файл";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(6, 31);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(83, 19);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.Text = "Свой путь:";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox2.Location = new System.Drawing.Point(305, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(131, 55);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(16, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(39, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Да";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(72, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(45, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Нет";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox1.Location = new System.Drawing.Point(305, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(128, 35);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 361);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

