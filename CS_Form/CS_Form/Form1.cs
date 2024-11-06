using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        testLabel _testLabel;

        public Form1()
        {
            InitializeComponent();




            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, i, (i % 10) * 100, (i % 10) * 50, 50, 50);
                Controls.Add(testButton);


            }

            _testLabel = new testLabel("ラベルです。", 10, 300, 100, 500); Controls.Add(_testLabel);





        }

        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
    }
}

