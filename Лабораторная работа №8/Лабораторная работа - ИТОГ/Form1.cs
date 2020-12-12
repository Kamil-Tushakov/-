using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Лабораторная_работа___ИТОГ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileStream file = null;
        string Doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        float[,] mas;
        private void button1_Click(object sender, EventArgs e)
        {
            if (file != null)
            {
                file.Close();
            }
            int array1 = Convert.ToInt32(text1.Text);
            int array2 = Convert.ToInt32(text2.Text);
            string stroka = "";
            mas = new float[array1, array2];
            System.IO.File.Delete(Doc + @"\program.txt");
            file = new FileStream(Doc + @"\program.txt", FileMode.OpenOrCreate);
            Random rand = new Random();
            for (int i = 0; i < array1; i++)
            {
                for (int j = 0; j < array2; j++)
                {
                    mas[i, j] = rand.Next(100);
                    stroka += $"{mas[i, j].ToString()} ";
                }
                stroka += "\n";
                byte[] arr = Encoding.Default.GetBytes(stroka);
                file.Write(arr, 0, arr.Length);
                stroka = "";
            }

            if (file != null)
            {
                file.Close();
            }
        }
    }
}

