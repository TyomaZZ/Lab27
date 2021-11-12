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
        readonly TestingForm OwnerForm;
        readonly ButtonTesting OwnerButton;

        public QueBoxForm(TestingForm Father, ButtonTesting sender)
        {
            InitializeComponent();
            OwnerForm = Father;
            labelQueNumber.Text = $"Питання № {sender.number}:";
            Father.labelTitle.Text = "Тестування: Дайте відповідь на запитання";
            OwnerButton = sender;
            quest.Text = sender.queFull.Split('|')[0].Trim();
        }

        private void AcceptButtonConfirm(object sender, EventArgs e)
        {
            if (AnswerBox.Text.ToLower().Equals(OwnerButton.answer.ToLower()))
            {
                // virno
                OwnerForm.Truth(3, OwnerButton, AnswerBox.Text);
                Close();
            }
            else
            {
                //nevirno
                OwnerForm.Wrong(3, OwnerButton);
                Close();
            }
        }

        private void QueBoxForm_Load(object sender, EventArgs e)
        {
            Left = OwnerForm.Left;
            Top = OwnerForm.Top + 30;
        }
    }
}
