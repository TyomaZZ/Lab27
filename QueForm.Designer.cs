
namespace WindowsFormsAppTest
{
    partial class QueForm
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
            this.quest = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQueNumber
            // 
            this.labelQueNumber.AutoSize = true;
            this.labelQueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQueNumber.ForeColor = System.Drawing.Color.White;
            this.labelQueNumber.Location = new System.Drawing.Point(13, 13);
            this.labelQueNumber.Name = "labelQueNumber";
            this.labelQueNumber.Size = new System.Drawing.Size(111, 17);
            this.labelQueNumber.TabIndex = 999;
            this.labelQueNumber.Text = "Питання № 0:";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.quest);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(546, 286);
            this.flowLayoutPanel1.TabIndex = 999;
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.Location = new System.Drawing.Point(32, 358);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(115, 28);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Так";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.Location = new System.Drawing.Point(454, 358);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(113, 28);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Ні";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // QueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(600, 398);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelQueNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueForm";
            this.Load += new System.EventHandler(this.QueForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQueNumber;
        private System.Windows.Forms.Label quest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}