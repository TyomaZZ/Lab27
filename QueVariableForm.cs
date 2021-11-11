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
    public partial class QueVariableForm : Form
    {
        TestingForm Father;
        ButtonTesting button;
        List<string> list;

        public QueVariableForm(TestingForm Father, ButtonTesting sender)
        {
            InitializeComponent();
            this.Father = Father;
            labelQueNumber.Text = $"Питання № {sender.number}:";
            Father.labelTitle.Text = "Тестування: Дайте відповідь на запитання";
            button = sender;
            quest.Text = sender.queFull.Split('|')[0].Trim();
            list = new List<string>();
            int a = 0;
            foreach (string str in button.queFull.Split('|'))
            {
                if (a > 2)
                    list.Add(str);
                a++;
            }
            int b = Father.rnd.Next(list.Count);
            Var1.Text = list[b];
            list.RemoveAt(b);
            b = Father.rnd.Next(list.Count);
            Var2.Text = list[b];
            list.RemoveAt(b);
            b = Father.rnd.Next(list.Count);
            Var3.Text =list[b];
            list.RemoveAt(b);
            b = Father.rnd.Next(list.Count);
            Var4.Text =list[b];
            list.RemoveAt(b);
        }

        private void QueVariableForm_Load(object sender, EventArgs e)
        {
            Left = Father.Left;
            Top = Father.Top + 30;
        }

        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Equals(button.answer))
            {
                Father.points += 2;
                Father.maximumPoints += 2;
                Father.completedQue++;
                Father.toolStripProgressBarStatus.Value++;
                button.BackColor = Color.DarkGreen;
                button.Enabled = false;
                // virno
                Close();
            }
            else
            {
                Father.maximumPoints += 2;
                Father.toolStripProgressBarStatus.Value++;
                button.BackColor = Color.DarkRed;
                button.Enabled = false;
                //nevirno
                Close();
            }
        }
    }
}
