﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        testLabel _testLabel;

        TestTextBox _testBox;

        public Form1()
        {
            InitializeComponent();

            string[] strs = new string[10]
            {
           
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "10",
              };




            for (int i = 0; i < 10; i++)
            {
                string id = strs[i];
                TestButton testButton = new TestButton(this, id, (i % 10) * 100, (i % 10) * 50, 50, 50);
                Controls.Add(testButton);


            }

            _testLabel = new testLabel("ラベルです。", 10, 300, 100, 500); Controls.Add(_testLabel);

            int[]ints = new int[1];

            Controls.Add(_testLabel);

            _testBox = new TestTextBox("テキストボックスです",101, 400, 500, 100);

            int[]ints2 = new int[1];
            Controls.Add(_testBox);


           
        }

        public void LabelTextUpdate(string str)
        {

            _testLabel.TextUpdate(str);

            string[] strs = null;

            if (strs == null)
            {

                strs = new string[0];
          
              
            }
            else
            { 

                strs = new string[strs.Length];
            }
        }

    }

            


        

               
    }





