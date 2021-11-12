
namespace WindowsFormsAppTest
{
    partial class TestingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanelQue = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStripBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusPointUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusQueProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.panelBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.statusStripBar.SuspendLayout();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(151)))));
            this.panelMain.Controls.Add(this.flowLayoutPanelQue);
            this.panelMain.Controls.Add(this.statusStripBar);
            this.panelMain.Controls.Add(this.panelBar);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 450);
            this.panelMain.TabIndex = 0;
            // 
            // flowLayoutPanelQue
            // 
            this.flowLayoutPanelQue.AutoScroll = true;
            this.flowLayoutPanelQue.AutoSize = true;
            this.flowLayoutPanelQue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(151)))));
            this.flowLayoutPanelQue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelQue.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanelQue.Name = "flowLayoutPanelQue";
            this.flowLayoutPanelQue.Size = new System.Drawing.Size(600, 398);
            this.flowLayoutPanelQue.TabIndex = 0;
            // 
            // statusStripBar
            // 
            this.statusStripBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(151)))));
            this.statusStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusPointUser,
            this.toolStripStatusQueProgress,
            this.toolStripProgressBarStatus});
            this.statusStripBar.Location = new System.Drawing.Point(0, 428);
            this.statusStripBar.Name = "statusStripBar";
            this.statusStripBar.Size = new System.Drawing.Size(600, 22);
            this.statusStripBar.SizingGrip = false;
            this.statusStripBar.TabIndex = 999;
            this.statusStripBar.Text = "statusStrip1";
            // 
            // toolStripStatusPointUser
            // 
            this.toolStripStatusPointUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(151)))));
            this.toolStripStatusPointUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusPointUser.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusPointUser.Name = "toolStripStatusPointUser";
            this.toolStripStatusPointUser.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusPointUser.Text = "Бали: 0/0 ;";
            // 
            // toolStripStatusQueProgress
            // 
            this.toolStripStatusQueProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(151)))));
            this.toolStripStatusQueProgress.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusQueProgress.Name = "toolStripStatusQueProgress";
            this.toolStripStatusQueProgress.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusQueProgress.Text = "Правильні відповіді: 0/0";
            // 
            // toolStripProgressBarStatus
            // 
            this.toolStripProgressBarStatus.Name = "toolStripProgressBarStatus";
            this.toolStripProgressBarStatus.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBarStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBar.Controls.Add(this.labelTitle);
            this.panelBar.Controls.Add(this.buttonClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(600, 30);
            this.panelBar.TabIndex = 999;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.panelBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.panelBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(76, 13);
            this.labelTitle.TabIndex = 999;
            this.labelTitle.Text = "Тестування";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Black;
            this.buttonClose.BackgroundImage = global::WindowsFormsAppTest.Properties.Resources.iconmonstr_x_mark_2_48;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(570, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 999;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.Close);
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseApplication);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.statusStripBar.ResumeLayout(false);
            this.statusStripBar.PerformLayout();
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPointUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusQueProgress;
        public System.Windows.Forms.Panel panelBar;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBarStatus;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQue;
        public System.Windows.Forms.StatusStrip statusStripBar;
    }
}