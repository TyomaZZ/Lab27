using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class FormTesting : Form
    {
        bool drag = false;
        int centerForm;
        int centerPanel;

        public FormTesting()
        {
            InitializeComponent();
            centerForm = Width;
            centerPanel = panelBar.Height;
        }

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
                this.Location = new Point(MousePosition.X - (centerForm / 2), MousePosition.Y - (centerPanel / 2));
        }

        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartTesting(object sender, EventArgs e)
        {
            int que = 0;
            switch (((Button)sender).Text.Split(' ')[0])
            {
                case "10":
                    que = 10;
                    break;
                case "20":
                    que = 20;
                    break;
                case "30":
                    que = 30;
                    break;
                case "40":
                    que = 40;
                    break;
                default:
                    que = Convert.ToInt32(countTextBox.Text);
                    break;
            }
            TestingForm frm = new TestingForm(que);
            frm.Show();
            Hide();
        }

        private void BlockNotNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ChekNotEmptyAndBlock(object sender, EventArgs e)
        {
            if (countTextBox.Text.Equals(""))
            {
                countButton.Enabled = false;
            }
            else
            {
                if (Convert.ToInt32(countTextBox.Text) > 1001)
                {
                    countTextBox.Text = "1000";
                }
                countButton.Enabled = true;
            }
        }
    }
}
