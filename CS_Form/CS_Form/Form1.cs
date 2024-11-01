using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(i,(i%5)*50,(i%5) * 50, 50, 50);
                Controls.Add(testButton);

                for (int j = 0; i < 10; i++)
                {
                    TestButton testButton2 = new TestButton(i, (i % 10) * 100, (i % 10) * 50, 50, 50);
                    Controls.Add(testButton2);

                }
            }

            

           
}
        }
    }

