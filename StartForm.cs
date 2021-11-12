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
        int maxQue = 41;
        //Зафіксований максимум 4100 запитань, при запиті в 5000 запитань(900 запитань не завантажилось/кнопки не прогрузилися), унікальність в 41 запитання

        public FormTesting()
        {
            InitializeComponent();
        }

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
                this.Location = new Point(MousePosition.X - (Width / 2), MousePosition.Y - (panelBar.Height / 2));
        }

        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void StartTesting(object sender, EventArgs e)
        {
            int queCount;
            switch (((Button)sender).Text.Split(' ')[0])
            {
                case "10":
                    queCount = 10;
                    break;
                case "20":
                    queCount = 20;
                    break;
                case "30":
                    queCount = 30;
                    break;
                case "40":
                    queCount = 40;
                    break;
                default:
                    queCount = Convert.ToInt32(countTextBox.Text);
                    break;
            }
            new TestingForm(queCount).Show();
            Hide();
        }

        private void BlockNotNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) & !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ChekNotEmptyAndBlock(object sender, EventArgs e)
        {
            if (countTextBox.Text.Equals(""))
                countButton.Enabled = false;
            else
            {
                if (Convert.ToInt32(countTextBox.Text) > maxQue + 1)
                    countTextBox.Text = maxQue.ToString();
                countButton.Enabled = true;
            }
        }
    }
}
