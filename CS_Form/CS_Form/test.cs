using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;

namespace CS_Form
{
    class testLabele : Label
    {
        
        
            public testLabele(String str, int x, int y, int width, int height)
            {


            Text = str;

                Location = new Point(x, y);

                Size = new Size(width, height);
            }

            public void Onclick(object sender, EventArgs s)
            {
                MessageBox.Show(Text);
            }
        
    }

}

