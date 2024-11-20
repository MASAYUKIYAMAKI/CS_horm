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
  　　internal class testLabel : Label
    {
        
        
            public testLabel(String str, int x, int y, int width, int height)
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

