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
    public partial class QueForm : Form
    {
        TestingForm Father;
        ButtonTesting button;
        public QueForm(TestingForm Father, ButtonTesting sender)
        {
            InitializeComponent();
            this.Father = Father;
            labelQueNumber.Text = $"Питання № {sender.number}:";
            Father.labelTitle.Text = "Тестування: Дайте відповідь на запитання";
            button = sender;
                if (sender.isTrue)
                {
                    btnYes.Click += btnYesClick;
                    btnNo.Click += btnNoClick;
                }
                else
                {
                    btnNo.Click += btnYesClick;
                    btnYes.Click += btnNoClick;
                }
            quest.Text = sender.queFull.Split('|')[0].Trim();
        }

        private void btnYesClick(object sender, EventArgs e)
        {
            Father.points++;
            Father.maximumPoints++;
            Father.completedQue++;
            Father.toolStripProgressBarStatus.Value++;
            button.BackColor = Color.DarkGreen;
            button.Enabled = false;
            // virno
            Close();
        }

        private void btnNoClick(object sender, EventArgs e)
        {
            Father.maximumPoints++;
            Father.toolStripProgressBarStatus.Value++;
            button.BackColor = Color.DarkRed;
            button.Enabled = false;
            //nevirno
            Close();
        }

        private void QueForm_Load(object sender, EventArgs e)
        {
            Left = Father.Left;
            Top = Father.Top + 30;
        }
    }
}
