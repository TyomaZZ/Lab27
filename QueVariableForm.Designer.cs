
namespace WindowsFormsAppTest
{
    partial class QueVariableForm
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
            this.labelQueNumber = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.quest = new System.Windows.Forms.Label();
            this.Var1 = new System.Windows.Forms.Button();
            this.Var3 = new System.Windows.Forms.Button();
            this.Var2 = new System.Windows.Forms.Button();
            this.Var4 = new System.Windows.Forms.Button();
            this.panelWithButton = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelWithButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQueNumber
            // 
            this.labelQueNumber.AutoSize = true;
            this.labelQueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQueNumber.ForeColor = System.Drawing.Color.White;
            this.labelQueNumber.Location = new System.Drawing.Point(12, 9);
            this.labelQueNumber.Name = "labelQueNumber";
            this.labelQueNumber.Size = new System.Drawing.Size(111, 17);
            this.labelQueNumber.TabIndex = 2;
            this.labelQueNumber.Text = "Питання № 0:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.quest);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(573, 262);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // quest
            // 
            this.quest.AutoSize = true;
            this.quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quest.ForeColor = System.Drawing.Color.White;
            this.quest.Location = new System.Drawing.Point(3, 0);
            this.quest.Name = "quest";
            this.quest.Size = new System.Drawing.Size(86, 24);
            this.quest.TabIndex = 1;
            this.quest.Text = "Питання";
            this.quest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Var1
            // 
            this.Var1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(106)))), ((int)(((byte)(247)))));
            this.Var1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Var1.Location = new System.Drawing.Point(3, 3);
            this.Var1.Name = "Var1";
            this.Var1.Size = new System.Drawing.Size(276, 40);
            this.Var1.TabIndex = 5;
            this.Var1.Text = "Варіант 1";
            this.Var1.UseVisualStyleBackColor = false;
            this.Var1.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // Var3
            // 
            this.Var3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(106)))), ((int)(((byte)(247)))));
            this.Var3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Var3.Location = new System.Drawing.Point(3, 46);
            this.Var3.Name = "Var3";
            this.Var3.Size = new System.Drawing.Size(276, 40);
            this.Var3.TabIndex = 6;
            this.Var3.Text = "Варіант 3";
            this.Var3.UseVisualStyleBackColor = false;
            this.Var3.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // Var2
            // 
            this.Var2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(106)))), ((int)(((byte)(247)))));
            this.Var2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Var2.Location = new System.Drawing.Point(294, 3);
            this.Var2.Name = "Var2";
            this.Var2.Size = new System.Drawing.Size(276, 40);
            this.Var2.TabIndex = 7;
            this.Var2.Text = "Варіант 2";
            this.Var2.UseVisualStyleBackColor = false;
            this.Var2.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // Var4
            // 
            this.Var4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(106)))), ((int)(((byte)(247)))));
            this.Var4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Var4.Location = new System.Drawing.Point(294, 46);
            this.Var4.Name = "Var4";
            this.Var4.Size = new System.Drawing.Size(276, 40);
            this.Var4.TabIndex = 8;
            this.Var4.Text = "Варіант 4";
            this.Var4.UseVisualStyleBackColor = false;
            this.Var4.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // panelWithButton
            // 
            this.panelWithButton.Controls.Add(this.Var1);
            this.panelWithButton.Controls.Add(this.Var4);
            this.panelWithButton.Controls.Add(this.Var3);
            this.panelWithButton.Controls.Add(this.Var2);
            this.panelWithButton.Location = new System.Drawing.Point(15, 297);
            this.panelWithButton.Name = "panelWithButton";
            this.panelWithButton.Size = new System.Drawing.Size(573, 89);
            this.panelWithButton.TabIndex = 9;
            // 
            // QueVariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(600, 398);
            this.Controls.Add(this.panelWithButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelQueNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QueVariableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueVariableForm";
            this.Load += new System.EventHandler(this.QueVariableForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelWithButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQueNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label quest;
        private System.Windows.Forms.Button Var1;
        private System.Windows.Forms.Button Var3;
        private System.Windows.Forms.Button Var2;
        private System.Windows.Forms.Button Var4;
        private System.Windows.Forms.Panel panelWithButton;
    }
}