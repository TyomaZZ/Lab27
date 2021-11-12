
namespace WindowsFormsAppTest
{
    partial class Result
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountQue = new System.Windows.Forms.Label();
            this.labelCorrectQue = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.buttonWatchResult = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonWatchResult);
            this.panel1.Controls.Add(this.buttonRepeat);
            this.panel1.Controls.Add(this.buttonCloseApp);
            this.panel1.Controls.Add(this.labelPoint);
            this.panel1.Controls.Add(this.labelCorrectQue);
            this.panel1.Controls.Add(this.labelCountQue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 292);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результат";
            // 
            // labelCountQue
            // 
            this.labelCountQue.AutoSize = true;
            this.labelCountQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountQue.ForeColor = System.Drawing.Color.White;
            this.labelCountQue.Location = new System.Drawing.Point(29, 57);
            this.labelCountQue.Name = "labelCountQue";
            this.labelCountQue.Size = new System.Drawing.Size(116, 13);
            this.labelCountQue.TabIndex = 1;
            this.labelCountQue.Text = "Всього запитань: ";
            // 
            // labelCorrectQue
            // 
            this.labelCorrectQue.AutoSize = true;
            this.labelCorrectQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorrectQue.ForeColor = System.Drawing.Color.White;
            this.labelCorrectQue.Location = new System.Drawing.Point(29, 70);
            this.labelCorrectQue.Name = "labelCorrectQue";
            this.labelCorrectQue.Size = new System.Drawing.Size(166, 13);
            this.labelCorrectQue.TabIndex = 2;
            this.labelCorrectQue.Text = "Надано вірних відповідей: ";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint.ForeColor = System.Drawing.Color.White;
            this.labelPoint.Location = new System.Drawing.Point(29, 83);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(127, 13);
            this.labelPoint.TabIndex = 3;
            this.labelPoint.Text = "Отримано балів: із  ";
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(112)))), ((int)(((byte)(237)))));
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseApp.Location = new System.Drawing.Point(12, 252);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(376, 30);
            this.buttonCloseApp.TabIndex = 4;
            this.buttonCloseApp.Text = "Закрити тестування";
            this.buttonCloseApp.UseVisualStyleBackColor = false;
            this.buttonCloseApp.Click += new System.EventHandler(this.CloseApp);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(112)))), ((int)(((byte)(237)))));
            this.buttonRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRepeat.Location = new System.Drawing.Point(12, 216);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(376, 30);
            this.buttonRepeat.TabIndex = 5;
            this.buttonRepeat.Text = "Спробувати ще раз";
            this.buttonRepeat.UseVisualStyleBackColor = false;
            this.buttonRepeat.Click += new System.EventHandler(this.RepeatTesting);
            // 
            // buttonWatchResult
            // 
            this.buttonWatchResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(112)))), ((int)(((byte)(237)))));
            this.buttonWatchResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWatchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWatchResult.Location = new System.Drawing.Point(12, 180);
            this.buttonWatchResult.Name = "buttonWatchResult";
            this.buttonWatchResult.Size = new System.Drawing.Size(376, 30);
            this.buttonWatchResult.TabIndex = 6;
            this.buttonWatchResult.Text = "Переглянути відповіді";
            this.buttonWatchResult.UseVisualStyleBackColor = false;
            this.buttonWatchResult.Click += new System.EventHandler(this.buttonWatchResult_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 294);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonWatchResult;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelCorrectQue;
        private System.Windows.Forms.Label labelCountQue;
        private System.Windows.Forms.Label label1;
    }
}