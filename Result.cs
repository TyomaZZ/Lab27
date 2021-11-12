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
    public partial class Result : Form
    {
        readonly TestingForm OwnerForm;

        public Result(TestingForm Father, int maxQue, int correctQue, int point, int pointMax)
        {
            InitializeComponent();
            OwnerForm = Father;
            labelCountQue.Text = $"Всього запитань: {maxQue}";
            labelCorrectQue.Text = $"Надано вірних відповідей: {correctQue}";
            labelPoint.Text = $"Отримано балів: {point} із {pointMax}  ";
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RepeatTesting(object sender, EventArgs e)
        {
            OwnerForm.Hide();
            new FormTesting().Show();
            Close();
        }

        private void buttonWatchResult_Click(object sender, EventArgs e)
        {
            Button btn = new Button()
            {
                Font = new Font(Font, FontStyle.Bold),
                ForeColor = Color.White,
            };
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Dock = DockStyle.Right;
            btn.Height = 30;
            btn.Width = 100;
            btn.Text = "Почати заново";
            btn.Font = new Font(btn.Font, FontStyle.Underline);
            btn.Click += RepeatTesting;
            OwnerForm.panelBar.Controls.Add(btn);
            Close();
        }
    }
}
