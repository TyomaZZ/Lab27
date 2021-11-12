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
        readonly TestingForm OwnerForm;
        readonly ButtonTesting buttonOwner;
        public QueForm(TestingForm Father, ButtonTesting buttonQuestion)
        {
            InitializeComponent();
            this.OwnerForm = Father;
            labelQueNumber.Text = $"Питання № {buttonQuestion.number}:";
            OwnerForm.labelTitle.Text = "Тестування: Дайте відповідь на запитання";
            buttonOwner = buttonQuestion;
                if (buttonQuestion.isTrue)
                {
                    btnYes.Click += btnYesClick;
                    btnNo.Click += btnNoClick;
                }
                else
                {
                    btnNo.Click += btnYesClick;
                    btnYes.Click += btnNoClick;
                }
            quest.Text = buttonQuestion.queFull.Split('|')[0].Trim();
        }

        private void btnYesClick(object sender, EventArgs e)
        {
            // virno
            OwnerForm.Truth(1, buttonOwner, ((Button)sender).Text);
            Close();
        }

        private void btnNoClick(object sender, EventArgs e)
        {
            //nevirno
            OwnerForm.Wrong(1, buttonOwner);
            Close();
        }

        private void QueForm_Load(object sender, EventArgs e)
        {
            Left = OwnerForm.Left;
            Top = OwnerForm.Top + 30;
        }
    }
}
