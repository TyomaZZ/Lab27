using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public class ButtonTesting : Button
    {


        public int number, 
            type; // type 1 - так/ні. type 2 - вписати відповідь. type 3 - вибрати з 4 варіантів.
        public string queFull; 
        public bool isTrue; // type 1
        public string answer; // type 2
        

        public ButtonTesting(int number)
        {
            this.number = number;
            Click += ClickC;
        }

        private void ClickC(object sender, EventArgs e)
        {
            if (queFull.Split('|')[1].Trim().Equals("1"))
            {
                type = 1;
                if (queFull.Split('|')[2].Trim().Equals("0"))
                    isTrue = false;
                else
                    isTrue = true;

                return;
            }
            if (queFull.Split('|')[1].Trim().Equals("2"))
            {
                type = 2;
                answer = queFull.Split('|')[2].Trim();
                return;
            }
            if (queFull.Split('|')[1].Trim().Equals("3"))
            {
                type = 3;
                answer = queFull.Split('|')[2].Trim();
                return;
            }

        }
    }
}
