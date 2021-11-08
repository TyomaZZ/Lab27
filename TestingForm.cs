using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace WindowsFormsAppTest
{
    public partial class TestingForm : Form
    {
        int maximumQue, points, completedQue, maximumPoints;
        int centerForm, centerPanel;
        bool drag = false;

        public TestingForm(int que)
        {
            InitializeComponent();
            labelTitle.Text = $"Тестування: {que} запитань";
            centerForm = Width;
            centerPanel = panelBar.Height;
            maximumQue = que;
            toolStripStatusQueProgress.Text = $"Бали: 0/{maximumQue} ;";
            toolStripProgressBarStatus.Maximum = maximumQue;
            toolStripProgressBarStatus.Step = 1;
            //toolStripStatusPointUser.Text = $"Правильні відповіді: 0/0";
            for (int i = 1; i < que + 1; i++)
            {
                ButtonTesting btn = new ButtonTesting(i);
                btn.Margin = new Padding(5, 5, 0, 0);
                if (que > 45)
                    btn.Width = 110;
                else
                    btn.Width = 114;
                btn.Height = 35;
                btn.BackColor = Color.LightGray;
                btn.Text = "Питання \n № " + btn.number;
                btn.Font = new Font(btn.Font, FontStyle.Bold);
                btn.Click += ButtonQue;
                flowLayoutPanelQue.Controls.Add(btn);
            }
        }

        private void ButtonQue(object sender, EventArgs e)
        {
            MessageBox.Show($"Питання № {((ButtonTesting)sender).number}");
        }

        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
