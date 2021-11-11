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
        public int maximumQue, points, completedQue, maximumPoints;
        bool drag = false;
        readonly public Random rnd = new Random();

        public TestingForm(int que)
        {
            Que.OnStart();
            InitializeComponent();
            labelTitle.Text = $"Тестування: {que} запитань";
            maximumQue = que;
            toolStripStatusQueProgress.Text = $"Бали: 0/{maximumQue} ;";
            toolStripProgressBarStatus.Maximum = maximumQue;
            toolStripProgressBarStatus.Step = 1;
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
                btn.Text = "Питання № " + btn.number;
                btn.Font = new Font(btn.Font, FontStyle.Bold);
                btn.Click += ButtonQue;
                flowLayoutPanelQue.Controls.Add(btn);
                
            }
            foreach (ButtonTesting btns in flowLayoutPanelQue.Controls)
            {
                if (Que.listQue.Count == 0)
                {
                    Que.OnStart();
                }
                int k = rnd.Next(Que.listQue.Count);
                btns.queFull = Que.listQue[k];
                Que.listQue.RemoveAt(k);
            }
        }

        private void ButtonQue(object sender, EventArgs e)
        {
            if (((ButtonTesting)sender).type == 1)
                new QueForm(this, (ButtonTesting)sender).ShowDialog();
            if (((ButtonTesting)sender).type == 2)
                new QueBoxForm(this, (ButtonTesting)sender).ShowDialog();
            if (((ButtonTesting)sender).type == 3)
                new QueVariableForm(this, (ButtonTesting)sender).ShowDialog();

            labelTitle.Text = $"Тестування: {maximumQue} запитань";
            toolStripStatusPointUser.Text = $"Правильні відповіді: {completedQue}/{maximumQue}";
            toolStripStatusQueProgress.Text = $"Бали: {points}/{maximumPoints} ;";
            ((ButtonTesting)sender).Text += $"\n{((ButtonTesting)sender).answer}";
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
                this.Location = new Point(MousePosition.X - (Width / 2), MousePosition.Y - (panelBar.Height / 2));
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
