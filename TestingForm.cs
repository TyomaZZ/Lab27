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
        public int maximumQue, points, completedQue, maximumPoints, correctQue;
        bool drag = false;
        readonly public Random rnd = new Random();

        public TestingForm(int que)
        {
            InitializeComponent();
            labelTitle.Text = $"Тестування: {que} запитань";
            maximumQue = que;
            toolStripStatusQueProgress.Text = $"Бали: 0/{maximumQue} ;";
            toolStripProgressBarStatus.Maximum = maximumQue;
            toolStripProgressBarStatus.Step = 1;
            GenerateQuestion(que);
        }

        private void GenerateQuestion(int queCount)
        {
            flowLayoutPanelQue.Controls.Clear();
            for (int i = 1; i < queCount + 1; i++)
            {
                ButtonTesting btn = new ButtonTesting(i)
                {
                    Margin = new Padding(5, 5, 0, 0),
                    Height = 110,
                    BackColor = Color.FromArgb(130, 100, 250),
                    Font = new Font(Font.FontFamily, 8, FontStyle.Bold),
                    ForeColor = Color.Black,
                    TabIndex = i
                };
                if (queCount > 15)
                    btn.Width = 110;
                else
                    btn.Width = 114;
                btn.Text = "Питання № " + btn.number;
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
            if (toolStripProgressBarStatus.Value == toolStripProgressBarStatus.Maximum)
            {
                new Result(this, maximumQue, correctQue, points, maximumPoints).ShowDialog();
            }
            if (flowLayoutPanelQue.Controls.GetChildIndex((Control)sender) < flowLayoutPanelQue.Controls.Count - 1)
            {
                    flowLayoutPanelQue.Controls[(flowLayoutPanelQue.Controls.GetChildIndex((Control)sender) + 1)].Focus();
            }
        }

        public void Truth(int count, ButtonTesting button, string answer)
        {
            points += count;
            maximumPoints += count;
            completedQue++;
            correctQue++;
            toolStripProgressBarStatus.Value++;
            button.BackColor = Color.DarkGreen;
            button.Enabled = false;
            button.Text += $"\n\nВи відповіли: \n{answer}";
        }

        public void Wrong(int count, ButtonTesting button)
        {
            maximumPoints += count;
            toolStripProgressBarStatus.Value++;
            button.BackColor = Color.DarkRed;
            button.Enabled = false;
            if (button.type == 1)
            {
                if (button.isTrue)
                    button.Text += $"\n\nПравильна відповідь: \nТак";
                else
                    button.Text += $"\n\nПравильна відповідь: \nНі";
            }
            else
            {
                button.Text += $"\nПравильна відповідь: \n{button.answer}";
            }
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
