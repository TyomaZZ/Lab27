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
        readonly TestingForm OwnerForm;
        readonly ButtonTesting OwnerButton;
        List<string> answerList;

        public QueVariableForm(TestingForm Father, ButtonTesting sender)
        {
            InitializeComponent();
            OwnerForm = Father;
            labelQueNumber.Text = $"Питання № {sender.number}:";
            Father.labelTitle.Text = "Тестування: Дайте відповідь на запитання";
            OwnerButton = sender;
            quest.Text = sender.queFull.Split('|')[0].Trim();
            answerList = new List<string>();
            int a = 0;
            foreach (string str in OwnerButton.queFull.Split('|'))
            {
                if (a > 2)
                    answerList.Add(str.Trim());
                a++;
            }
            foreach (Button btn in panelWithButton.Controls)
            {
                int b = Father.rnd.Next(answerList.Count);
                btn.Text = answerList[b];
                answerList.RemoveAt(b);
            }
        }

        private void QueVariableForm_Load(object sender, EventArgs e)
        {
            Left = OwnerForm.Left;
            Top = OwnerForm.Top + 30;
        }

        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Equals(OwnerButton.answer))
            {
                // virno
                OwnerForm.Truth(2, OwnerButton, ((Button)sender).Text);
                Close();
            }
            else
            {
                //nevirno
                OwnerForm.Wrong(2, OwnerButton);
                Close();
            }
        }
    }
}
