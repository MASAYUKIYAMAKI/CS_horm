﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    class TestTextBox:TextBox
    {

        public TestTextBox(String str, int x, int y, int width, int height)
        {


            Text = str;

            Location = new Point(x, y);

            Size = new Size(width, height);




        }



        public string TextUpdate(string str)
        {

            string kara = Text;

            Text = str;

            return kara;
        }

    }
}
