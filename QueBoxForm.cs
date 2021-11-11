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
    public partial class QueBoxForm : Form
    {
        TestingForm Father;
        ButtonTesting button;

        public QueBoxForm(TestingForm Father, ButtonTesting sender)
        {
            InitializeComponent();
            this.Father = Father;
            labelQueNumber.Text = $"Питання № {sender.number}:";
            Father.labelTitle.Text = "Тестування: Дайте відповідь на запитання";
            button = sender;
            quest.Text = sender.queFull.Split('|')[0].Trim();
        }

        private void AcceptButtonConfirm(object sender, EventArgs e)
        {
            if (AnswerBox.Text.ToLower().Equals(button.answer.ToLower()))
            {
                Father.points += 3;
                Father.maximumPoints += 3;
                Father.completedQue++;
                Father.toolStripProgressBarStatus.Value++;
                button.BackColor = Color.DarkGreen;
                button.Enabled = false;
                // virno
                Close();
            }
            else
            {
                Father.maximumPoints += 3;
                Father.toolStripProgressBarStatus.Value++;
                button.BackColor = Color.DarkRed;
                button.Enabled = false;
                //nevirno
                Close();
            }
        }

        private void QueBoxForm_Load(object sender, EventArgs e)
        {
            Left = Father.Left;
            Top = Father.Top + 30;
        }
    }
}
