namespace VadAUTO
{
    partial class ProbramareMasina
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeText = new System.Windows.Forms.TextBox();
            this.prenumeText = new System.Windows.Forms.TextBox();
            this.automobilText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.programeazaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Automobil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // numeText
            // 
            this.numeText.Location = new System.Drawing.Point(210, 56);
            this.numeText.Name = "numeText";
            this.numeText.Size = new System.Drawing.Size(217, 26);
            this.numeText.TabIndex = 4;
            // 
            // prenumeText
            // 
            this.prenumeText.Location = new System.Drawing.Point(210, 85);
            this.prenumeText.Name = "prenumeText";
            this.prenumeText.Size = new System.Drawing.Size(217, 26);
            this.prenumeText.TabIndex = 5;
            // 
            // automobilText
            // 
            this.automobilText.Location = new System.Drawing.Point(210, 114);
            this.automobilText.Name = "automobilText";
            this.automobilText.Size = new System.Drawing.Size(217, 26);
            this.automobilText.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // programeazaButton
            // 
            this.programeazaButton.BackColor = System.Drawing.Color.Khaki;
            this.programeazaButton.FlatAppearance.BorderSize = 0;
            this.programeazaButton.Location = new System.Drawing.Point(121, 212);
            this.programeazaButton.Name = "programeazaButton";
            this.programeazaButton.Size = new System.Drawing.Size(200, 48);
            this.programeazaButton.TabIndex = 8;
            this.programeazaButton.Text = "Programeaza";
            this.programeazaButton.UseVisualStyleBackColor = false;
            this.programeazaButton.Click += new System.EventHandler(this.programeazaButton_Click);
            // 
            // ProbramareMasina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.programeazaButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.automobilText);
            this.Controls.Add(this.prenumeText);
            this.Controls.Add(this.numeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProbramareMasina";
            this.Size = new System.Drawing.Size(952, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numeText;
        private System.Windows.Forms.TextBox prenumeText;
        private System.Windows.Forms.TextBox automobilText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button programeazaButton;
    }
}
