
namespace WindowsFormsAppTest
{
    partial class QueBoxForm
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.answerText = new System.Windows.Forms.Label();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.labelQueNumber.TabIndex = 1;
            this.labelQueNumber.Text = "Питання № 0:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.quest);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 294);
            this.flowLayoutPanel1.TabIndex = 3;
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
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(426, 336);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(135, 37);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Готово";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.AcceptButtonConfirm);
            // 
            // answerText
            // 
            this.answerText.AutoSize = true;
            this.answerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerText.ForeColor = System.Drawing.Color.White;
            this.answerText.Location = new System.Drawing.Point(28, 346);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(73, 17);
            this.answerText.TabIndex = 5;
            this.answerText.Text = "Відповідь:";
            // 
            // AnswerBox
            // 
            this.AnswerBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AnswerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerBox.ForeColor = System.Drawing.Color.White;
            this.AnswerBox.Location = new System.Drawing.Point(107, 346);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(116, 20);
            this.AnswerBox.TabIndex = 6;
            // 
            // QueBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(600, 398);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelQueNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QueBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueBoxForm";
            this.Load += new System.EventHandler(this.QueBoxForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQueNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label quest;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label answerText;
        private System.Windows.Forms.TextBox AnswerBox;
    }
}