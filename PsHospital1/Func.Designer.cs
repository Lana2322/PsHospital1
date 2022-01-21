namespace PsHospital1
{
    partial class Func
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
            this.WomanButton = new System.Windows.Forms.Button();
            this.DangerButton = new System.Windows.Forms.Button();
            this.AllButton = new System.Windows.Forms.Button();
            this.ComeButton = new System.Windows.Forms.Button();
            this.StatusButton = new System.Windows.Forms.Button();
            this.DiagnosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WomanButton
            // 
            this.WomanButton.Location = new System.Drawing.Point(12, 12);
            this.WomanButton.Name = "WomanButton";
            this.WomanButton.Size = new System.Drawing.Size(258, 26);
            this.WomanButton.TabIndex = 0;
            this.WomanButton.Text = "Соотношение пациенток";
            this.WomanButton.UseVisualStyleBackColor = true;
            this.WomanButton.Click += new System.EventHandler(this.WomanButton_Click);
            // 
            // DangerButton
            // 
            this.DangerButton.Location = new System.Drawing.Point(12, 41);
            this.DangerButton.Name = "DangerButton";
            this.DangerButton.Size = new System.Drawing.Size(258, 26);
            this.DangerButton.TabIndex = 1;
            this.DangerButton.Text = "Пациенты с уровнем угрозы";
            this.DangerButton.UseVisualStyleBackColor = true;
            this.DangerButton.Click += new System.EventHandler(this.DangerButton_Click);
            // 
            // AllButton
            // 
            this.AllButton.Location = new System.Drawing.Point(12, 70);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(258, 26);
            this.AllButton.TabIndex = 2;
            this.AllButton.Text = "Вставшие на учёт";
            this.AllButton.UseVisualStyleBackColor = true;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // ComeButton
            // 
            this.ComeButton.Location = new System.Drawing.Point(12, 99);
            this.ComeButton.Name = "ComeButton";
            this.ComeButton.Size = new System.Drawing.Size(258, 26);
            this.ComeButton.TabIndex = 3;
            this.ComeButton.Text = "Соотношение прибывших";
            this.ComeButton.UseVisualStyleBackColor = true;
            this.ComeButton.Click += new System.EventHandler(this.ComeButton_Click);
            // 
            // StatusButton
            // 
            this.StatusButton.Location = new System.Drawing.Point(12, 128);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(258, 26);
            this.StatusButton.TabIndex = 4;
            this.StatusButton.Text = "Доля статусов пациентов";
            this.StatusButton.UseVisualStyleBackColor = true;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // DiagnosButton
            // 
            this.DiagnosButton.Location = new System.Drawing.Point(12, 157);
            this.DiagnosButton.Name = "DiagnosButton";
            this.DiagnosButton.Size = new System.Drawing.Size(258, 26);
            this.DiagnosButton.TabIndex = 5;
            this.DiagnosButton.Text = "Распределение по диагнозам";
            this.DiagnosButton.UseVisualStyleBackColor = true;
            this.DiagnosButton.Click += new System.EventHandler(this.DiagnosButton_Click);
            // 
            // Func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 221);
            this.Controls.Add(this.DiagnosButton);
            this.Controls.Add(this.StatusButton);
            this.Controls.Add(this.ComeButton);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.DangerButton);
            this.Controls.Add(this.WomanButton);
            this.Name = "Func";
            this.Text = "Func";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WomanButton;
        private System.Windows.Forms.Button DangerButton;
        private System.Windows.Forms.Button AllButton;
        private System.Windows.Forms.Button ComeButton;
        private System.Windows.Forms.Button StatusButton;
        private System.Windows.Forms.Button DiagnosButton;
    }
}