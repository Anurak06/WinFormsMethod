﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMethod
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtResult.Text = Triangle(5);
            //txtResult.Text = Triangle("A", 9);
            //txtResult.Text = Triangle("B");
            txtResult.Text = Triangle("R");
        }
        string Triangle(int size)
        {
            string txt_resualt = ""; // ตัวแปรเก็บผลลัพธ์
            for (int i = 1; i <= size; i++) // เริ่มจาก 1 ไปถึง size
            {
                txt_resualt += new string('*', i); // สร้าง * ตามจำนวน i
                txt_resualt += Environment.NewLine; // เพิ่มบรรทัดใหม่
            }
            return txt_resualt; // คืนค่าผลลัพธ์
        }
        string Triangle(string letter, int size = 5)
        {
            string txt_result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += letter;
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }
        //string Triangle(string letter)
        //{
        //    string txt_result = "";
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            txt_result += letter;
        //        }
        //        txt_result += Environment.NewLine;
        //    }
        //    return txt_result;
        //}
        string Triangle()
        {
            string txt_result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += "*";
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }
    }
}
