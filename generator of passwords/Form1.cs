﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generator_of_passwords
{
    public partial class Form1 : Form
    {
        private string FinalPassword;
        public Form1()
        {
            InitializeComponent();
            LangComboBox.SelectedIndex = 0;
            LangComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            radioButton2.Checked = true;
            label2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            textBox1.Visible = false;
            groupBox2.Visible = false;
            generateBut.Click += generateBut_Click;
        }
        private void LangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int langindext = LangComboBox.SelectedIndex + 1;
            switch (langindext)
            {
                case 1:
                    {
                        LenghtLabel.Text = "Длина желаемого пароля:";
                        NumbersBox.Text = "Цифры";
                        TextLittleBox.Text = "Строчные буквы";
                        TextBigBox.Text = "Заглавные буквы";
                        SpecialSymbolsBox.Text = "Специальные символы";
                        generateBut.Text = "Сгенерировать пароль";
                        label1.Text = "Сохранять пароли в файл?";
                        radioButton1.Text = "Да";
                        radioButton2.Text = "Нет";
                        radioButton3.Text = "Дефолт файл";
                        radioButton4.Text = "Свой путь:";
                        break;
                    }
                case 2:
                    {
                        LenghtLabel.Text = "Довжина бажаного паролю:";
                        NumbersBox.Text = "Цифри";
                        TextLittleBox.Text = "Малі літери";
                        TextBigBox.Text = "Великі літери";
                        SpecialSymbolsBox.Text = "Спеціальні символи";
                        generateBut.Text = "Згенерувати пароль";
                        label1.Text = "Зберігати паролі у файл?";
                        radioButton1.Text = "Так";
                        radioButton2.Text = "Ні";
                        radioButton3.Text = "Файл за замовчуванням";
                        radioButton4.Text = "Власний шлях:";

                        break;
                    }
                case 3:
                    {
                        LenghtLabel.Text = "Desired Password Length:";
                        NumbersBox.Text = "Numbers";
                        TextLittleBox.Text = "Lowercase Letters";
                        TextBigBox.Text = "Uppercase Letters";
                        SpecialSymbolsBox.Text = "Special Symbols";
                        generateBut.Text = "Generate Password";
                        label1.Text = "Save passwords to a file?";
                        radioButton1.Text = "Yes";
                        radioButton2.Text = "No";
                        radioButton3.Text = "Default file";
                        radioButton4.Text = "Custom path:";

                        break;
                    }
                case 4:
                    {
                        LenghtLabel.Text = "Longitud de la contraseña deseada:";
                        NumbersBox.Text = "Numeros";
                        TextLittleBox.Text = "Letras minusculas";
                        TextBigBox.Text = "Letras mayusculas";
                        SpecialSymbolsBox.Text = "Simbolos especiales";
                        generateBut.Text = "Generar contraseña";
                        label1.Text = "¿Guardar contraseñas en un archivo?";
                        radioButton1.Text = "Sí";
                        radioButton2.Text = "No";
                        radioButton3.Text = "Archivo predeterminado";
                        radioButton4.Text = "Ruta personalizada:";

                        break;
                    }
            }
        }

        private void generateBut_Click(object sender, EventArgs e)
        {
            int checkall = 0;
            List<int> ItemList = new List<int>();
            if (NumbersBox.Checked)
            {
                ItemList.AddRange(new List<int> { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 });
                checkall++;
            }
            if (TextLittleBox.Checked)
            {
                ItemList.AddRange(new List<int> { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122 });
                checkall++;
            }
            if (TextBigBox.Checked)
            {
                ItemList.AddRange(new List<int> { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 });
                checkall++;
            }
            if (SpecialSymbolsBox.Checked)
            {
                ItemList.AddRange(new List<int> { 36, 37, 94, 38, 40, 41, 45, 95, 61, 43, 91, 93, 123, 125, 59, 58, 44, 46, 47, 92, 124, 39, 34, 60, 62, 63 });
                checkall++;
            }
            if (checkall < 1)
            {
                int langindext = LangComboBox.SelectedIndex + 1;
                switch (langindext)
                {
                    case 1:
                        {
                            MessageBox.Show("Вы должны отметить хотя бы один пункт для создания пароля.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("Ви повинні відмітити принаймні один пункт для створення пароля.", "Помилка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case 3:
                        {
                            MessageBox.Show("You must check at least one item to create a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case 4:
                        {
                            MessageBox.Show("Debe marcar al menos un elemento para crear una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                }

            }
            Random random = new Random();
            for (int i = 0; i < ItemList.Count; i++)
            {
                int randomIndex = random.Next(i, ItemList.Count);
                int temp = ItemList[i];
                ItemList[i] = ItemList[randomIndex];
                ItemList[randomIndex] = temp;
            }

            int arraySize = Convert.ToInt32(numericUpDown1.Value);
            int[] password = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                try
                {
                    int randomInt = random.Next(1, ItemList.Count);
                    password[i] = ItemList[randomInt];
                }
                catch { }
                Debug.Write(password[i] + " ");
            }
            FinalPassword = ConvertAsciiCodesToString(password);
            if (radioButton1.Checked)
            {
                label2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                if (radioButton3.Checked)
                {
                    string filePath = @"D:\Учеба\КРОК\4 курс\качество и тест пз\generator of passwords\generator of passwords\passwords.txt";

                    if (File.Exists(filePath))
                    {
                        File.WriteAllText(filePath, FinalPassword + "\n");
                    }
                    else
                    {
                        try
                        {
                            File.CreateText(filePath);
                            Debug.WriteLine("Файл успешно создан.");
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Ошибка при создании файла: {ex.Message}");
                        }
                    }
                }
                else if (radioButton4.Checked)
                {
                    textBox1.Visible = true;
                    if (File.Exists(textBox1.Text))
                    {
                        File.WriteAllText(textBox1.Text, FinalPassword + "\n");
                    }
                    else
                    {
                        try
                        {
                            File.CreateText(textBox1.Text);
                            Debug.WriteLine("Файл успешно создан.");
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Ошибка при создании файла: {ex.Message}");
                        }
                    }
                }
            }
            outTextBox.Text = FinalPassword;

            ItemList.Clear();
        }
        static string ConvertAsciiCodesToString(int[] asciiCodes)
        {
            StringBuilder resultStringBuilder = new StringBuilder();

            foreach (int code in asciiCodes)
            {
                char character = Convert.ToChar(code);
                resultStringBuilder.Append(character);
            }

            return resultStringBuilder.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                groupBox2.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                string filePath = @"D:\Учеба\КРОК\4 курс\качество и тест пз\generator of passwords\generator of passwords\passwords.txt";
                if (!string.IsNullOrEmpty(FinalPassword))
                {
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            using (StreamWriter sw = File.AppendText(filePath))
                            {
                                sw.WriteLine(FinalPassword);
                                Debug.WriteLine("Пароль успешно добавлен в файл.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Ошибка при добавлении пароля в файл: {ex.Message}");
                        }
                    }
                    else
                    {
                        try
                        {
                            File.CreateText(filePath);
                            Debug.WriteLine("Файл успешно создан.");
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Ошибка при создании файла: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {   if (!string.IsNullOrEmpty(FinalPassword))
                {


                    textBox1.Visible = true;
                    if (File.Exists(textBox1.Text))
                    {
                        try
                        {
                            using (StreamWriter sw = File.AppendText(textBox1.Text))
                            {
                                sw.WriteLine(FinalPassword);
                                Debug.WriteLine("Пароль успешно добавлен в файл.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Ошибка при добавлении пароля в файл: {ex.Message}");
                        }
                    }
                    else
                    {
                        try
                        {
                            File.CreateText(textBox1.Text);
                            Debug.WriteLine("Файл успешно создан.");
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Ошибка при создании файла: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}

