
namespace WindowsFormsAppTest
{
    partial class FormTesting
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.nameOfBuildProgramOnWinForm = new System.Windows.Forms.Label();
            this.demoProgramName = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.umbraText = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.lvl4Text = new System.Windows.Forms.Label();
            this.lvl3Text = new System.Windows.Forms.Label();
            this.vlv2Text = new System.Windows.Forms.Label();
            this.lvl1Text = new System.Windows.Forms.Label();
            this.button4lvl = new System.Windows.Forms.Button();
            this.button3lvl = new System.Windows.Forms.Button();
            this.button2lvl = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.button1lvl = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.titleName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(151)))));
            this.panelMain.Controls.Add(this.button3);
            this.panelMain.Controls.Add(this.button2);
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.demoProgramName);
            this.panelMain.Controls.Add(this.nameOfBuildProgramOnWinForm);
            this.panelMain.Controls.Add(this.countButton);
            this.panelMain.Controls.Add(this.lvl4Text);
            this.panelMain.Controls.Add(this.lvl3Text);
            this.panelMain.Controls.Add(this.button4lvl);
            this.panelMain.Controls.Add(this.button3lvl);
            this.panelMain.Controls.Add(this.button2lvl);
            this.panelMain.Controls.Add(this.button1lvl);
            this.panelMain.Controls.Add(this.panelBar);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.umbraText);
            this.panelMain.Controls.Add(this.countTextBox);
            this.panelMain.Controls.Add(this.vlv2Text);
            this.panelMain.Controls.Add(this.lvl1Text);
            this.panelMain.Controls.Add(this.welcomeText);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(530, 225);
            this.panelMain.TabIndex = 0;
            // 
            // nameOfBuildProgramOnWinForm
            // 
            this.nameOfBuildProgramOnWinForm.AutoSize = true;
            this.nameOfBuildProgramOnWinForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOfBuildProgramOnWinForm.Location = new System.Drawing.Point(363, 71);
            this.nameOfBuildProgramOnWinForm.Name = "nameOfBuildProgramOnWinForm";
            this.nameOfBuildProgramOnWinForm.Size = new System.Drawing.Size(59, 31);
            this.nameOfBuildProgramOnWinForm.TabIndex = 14;
            this.nameOfBuildProgramOnWinForm.Text = "Old";
            // 
            // demoProgramName
            // 
            this.demoProgramName.AutoSize = true;
            this.demoProgramName.BackColor = System.Drawing.Color.Transparent;
            this.demoProgramName.Font = new System.Drawing.Font("Vivaldi", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.demoProgramName.Location = new System.Drawing.Point(288, 105);
            this.demoProgramName.Name = "demoProgramName";
            this.demoProgramName.Size = new System.Drawing.Size(241, 68);
            this.demoProgramName.TabIndex = 13;
            this.demoProgramName.Text = "Testing";
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.countButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.Location = new System.Drawing.Point(194, 185);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(72, 23);
            this.countButton.TabIndex = 12;
            this.countButton.Text = "запитань";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.StartTesting);
            // 
            // umbraText
            // 
            this.umbraText.AutoSize = true;
            this.umbraText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umbraText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.umbraText.Location = new System.Drawing.Point(25, 190);
            this.umbraText.Name = "umbraText";
            this.umbraText.Size = new System.Drawing.Size(121, 13);
            this.umbraText.TabIndex = 11;
            this.umbraText.Text = "На власний розсуд";
            // 
            // countTextBox
            // 
            this.countTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTextBox.Location = new System.Drawing.Point(152, 187);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(36, 20);
            this.countTextBox.TabIndex = 10;
            this.countTextBox.Text = "50";
            this.countTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countTextBox.TextChanged += new System.EventHandler(this.ChekNotEmptyAndBlock);
            this.countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNotNumber);
            // 
            // lvl4Text
            // 
            this.lvl4Text.AutoSize = true;
            this.lvl4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl4Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvl4Text.Location = new System.Drawing.Point(40, 163);
            this.lvl4Text.Name = "lvl4Text";
            this.lvl4Text.Size = new System.Drawing.Size(84, 13);
            this.lvl4Text.TabIndex = 9;
            this.lvl4Text.Text = "Домінування";
            // 
            // lvl3Text
            // 
            this.lvl3Text.AutoSize = true;
            this.lvl3Text.BackColor = System.Drawing.Color.Transparent;
            this.lvl3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl3Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvl3Text.Location = new System.Drawing.Point(44, 134);
            this.lvl3Text.Name = "lvl3Text";
            this.lvl3Text.Size = new System.Drawing.Size(71, 13);
            this.lvl3Text.TabIndex = 8;
            this.lvl3Text.Text = "Прагнення";
            // 
            // vlv2Text
            // 
            this.vlv2Text.AutoSize = true;
            this.vlv2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vlv2Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vlv2Text.Location = new System.Drawing.Point(41, 105);
            this.vlv2Text.Name = "vlv2Text";
            this.vlv2Text.Size = new System.Drawing.Size(80, 13);
            this.vlv2Text.TabIndex = 7;
            this.vlv2Text.Text = "Впевненість";
            // 
            // lvl1Text
            // 
            this.lvl1Text.AutoSize = true;
            this.lvl1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl1Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvl1Text.Location = new System.Drawing.Point(32, 76);
            this.lvl1Text.Name = "lvl1Text";
            this.lvl1Text.Size = new System.Drawing.Size(95, 13);
            this.lvl1Text.TabIndex = 6;
            this.lvl1Text.Text = "Ознайомлення";
            // 
            // button4lvl
            // 
            this.button4lvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4lvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4lvl.Location = new System.Drawing.Point(130, 158);
            this.button4lvl.Name = "button4lvl";
            this.button4lvl.Size = new System.Drawing.Size(136, 23);
            this.button4lvl.TabIndex = 5;
            this.button4lvl.Text = "40 запитань";
            this.button4lvl.UseVisualStyleBackColor = false;
            this.button4lvl.Click += new System.EventHandler(this.StartTesting);
            // 
            // button3lvl
            // 
            this.button3lvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3lvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3lvl.Location = new System.Drawing.Point(130, 129);
            this.button3lvl.Name = "button3lvl";
            this.button3lvl.Size = new System.Drawing.Size(136, 23);
            this.button3lvl.TabIndex = 4;
            this.button3lvl.Text = "30 запитань";
            this.button3lvl.UseVisualStyleBackColor = false;
            this.button3lvl.Click += new System.EventHandler(this.StartTesting);
            // 
            // button2lvl
            // 
            this.button2lvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2lvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2lvl.Location = new System.Drawing.Point(130, 100);
            this.button2lvl.Name = "button2lvl";
            this.button2lvl.Size = new System.Drawing.Size(136, 23);
            this.button2lvl.TabIndex = 3;
            this.button2lvl.Text = "20 запитань";
            this.button2lvl.UseVisualStyleBackColor = false;
            this.button2lvl.Click += new System.EventHandler(this.StartTesting);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.welcomeText.Location = new System.Drawing.Point(7, 42);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(125, 13);
            this.welcomeText.TabIndex = 2;
            this.welcomeText.Text = "Кількість запитань:";
            // 
            // button1lvl
            // 
            this.button1lvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1lvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1lvl.Location = new System.Drawing.Point(130, 71);
            this.button1lvl.Name = "button1lvl";
            this.button1lvl.Size = new System.Drawing.Size(136, 23);
            this.button1lvl.TabIndex = 1;
            this.button1lvl.Text = "10 запитань";
            this.button1lvl.UseVisualStyleBackColor = false;
            this.button1lvl.Click += new System.EventHandler(this.StartTesting);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBar.Controls.Add(this.titleName);
            this.panelBar.Controls.Add(this.buttonClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(530, 30);
            this.panelBar.TabIndex = 0;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.panelBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.panelBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleName.ForeColor = System.Drawing.Color.White;
            this.titleName.Location = new System.Drawing.Point(-3, 0);
            this.titleName.Margin = new System.Windows.Forms.Padding(13, 10, 3, 0);
            this.titleName.Name = "titleName";
            this.titleName.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.titleName.Size = new System.Drawing.Size(160, 23);
            this.titleName.TabIndex = 1;
            this.titleName.Text = "Тестування: вибір опцій";
            this.titleName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.titleName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.titleName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(470, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 26);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(440, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 26);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(475, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 26);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WindowsFormsAppTest.Properties.Resources.iconmonstr_circle_5_240;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(389, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Black;
            this.buttonClose.BackgroundImage = global::WindowsFormsAppTest.Properties.Resources.iconmonstr_x_mark_2_48;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(500, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 225);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTesting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестування";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button2lvl;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button button1lvl;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label umbraText;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label lvl4Text;
        private System.Windows.Forms.Label lvl3Text;
        private System.Windows.Forms.Label vlv2Text;
        private System.Windows.Forms.Label lvl1Text;
        private System.Windows.Forms.Button button4lvl;
        private System.Windows.Forms.Button button3lvl;
        private System.Windows.Forms.Label demoProgramName;
        private System.Windows.Forms.Label nameOfBuildProgramOnWinForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

