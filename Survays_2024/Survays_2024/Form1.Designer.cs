namespace Survays_2024
{
    partial class Form1
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkPapaAndWors = new System.Windows.Forms.CheckBox();
            this.chkPasta = new System.Windows.Forms.CheckBox();
            this.chkWatchTV = new System.Windows.Forms.CheckBox();
            this.chkPizza = new System.Windows.Forms.CheckBox();
            this.chkEatOut = new System.Windows.Forms.CheckBox();
            this.chkMovies = new System.Windows.Forms.CheckBox();
            this.chkRadio = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(243, 83);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(322, 26);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(243, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(322, 26);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(243, 165);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(202, 26);
            this.txtDOB.TabIndex = 2;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(243, 205);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(213, 26);
            this.txtContactNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name/s:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth(DD/MM/YYYY):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact Number:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(12, 681);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 34);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDOB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 255);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personal Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "_Surveys";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(518, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "FILL OUT SURVEY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 22);
            this.label8.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(565, 681);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Please choose what you like";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkOther);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.chkPapaAndWors);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.chkPasta);
            this.panel2.Controls.Add(this.chkWatchTV);
            this.panel2.Controls.Add(this.chkPizza);
            this.panel2.Controls.Add(this.chkEatOut);
            this.panel2.Controls.Add(this.chkMovies);
            this.panel2.Controls.Add(this.chkRadio);
            this.panel2.Location = new System.Drawing.Point(12, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 314);
            this.panel2.TabIndex = 17;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(243, 287);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(75, 24);
            this.chkOther.TabIndex = 25;
            this.chkOther.Text = "Other";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "What\'s your favourite food?";
            // 
            // chkPapaAndWors
            // 
            this.chkPapaAndWors.AutoSize = true;
            this.chkPapaAndWors.Location = new System.Drawing.Point(243, 257);
            this.chkPapaAndWors.Name = "chkPapaAndWors";
            this.chkPapaAndWors.Size = new System.Drawing.Size(135, 24);
            this.chkPapaAndWors.TabIndex = 24;
            this.chkPapaAndWors.Text = "Pap and Wors";
            this.chkPapaAndWors.UseVisualStyleBackColor = true;
            // 
            // chkPasta
            // 
            this.chkPasta.AutoSize = true;
            this.chkPasta.Location = new System.Drawing.Point(243, 227);
            this.chkPasta.Name = "chkPasta";
            this.chkPasta.Size = new System.Drawing.Size(76, 24);
            this.chkPasta.TabIndex = 23;
            this.chkPasta.Text = "Pasta";
            this.chkPasta.UseVisualStyleBackColor = true;
            // 
            // chkWatchTV
            // 
            this.chkWatchTV.AutoSize = true;
            this.chkWatchTV.Location = new System.Drawing.Point(243, 31);
            this.chkWatchTV.Name = "chkWatchTV";
            this.chkWatchTV.Size = new System.Drawing.Size(155, 24);
            this.chkWatchTV.TabIndex = 18;
            this.chkWatchTV.Text = "I like to watch TV";
            this.chkWatchTV.UseVisualStyleBackColor = true;
            this.chkWatchTV.CheckedChanged += new System.EventHandler(this.chkWatchTV_CheckedChanged);
            // 
            // chkPizza
            // 
            this.chkPizza.AutoSize = true;
            this.chkPizza.Location = new System.Drawing.Point(243, 197);
            this.chkPizza.Name = "chkPizza";
            this.chkPizza.Size = new System.Drawing.Size(73, 24);
            this.chkPizza.TabIndex = 22;
            this.chkPizza.Text = "Pizza";
            this.chkPizza.UseVisualStyleBackColor = true;
            // 
            // chkEatOut
            // 
            this.chkEatOut.AutoSize = true;
            this.chkEatOut.Location = new System.Drawing.Point(243, 61);
            this.chkEatOut.Name = "chkEatOut";
            this.chkEatOut.Size = new System.Drawing.Size(139, 24);
            this.chkEatOut.TabIndex = 19;
            this.chkEatOut.Text = "I like to eat out";
            this.chkEatOut.UseVisualStyleBackColor = true;
            // 
            // chkMovies
            // 
            this.chkMovies.AutoSize = true;
            this.chkMovies.Location = new System.Drawing.Point(243, 121);
            this.chkMovies.Name = "chkMovies";
            this.chkMovies.Size = new System.Drawing.Size(184, 24);
            this.chkMovies.TabIndex = 21;
            this.chkMovies.Text = "I like to watch movies";
            this.chkMovies.UseVisualStyleBackColor = true;
            // 
            // chkRadio
            // 
            this.chkRadio.AutoSize = true;
            this.chkRadio.Location = new System.Drawing.Point(243, 91);
            this.chkRadio.Name = "chkRadio";
            this.chkRadio.Size = new System.Drawing.Size(183, 24);
            this.chkRadio.TabIndex = 20;
            this.chkRadio.Text = "I like to listen to radio";
            this.chkRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 1022);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(275, 681);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(104, 34);
            this.btnNextPage.TabIndex = 19;
            this.btnNextPage.Text = "N&ext";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 719);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkWatchTV;
        private System.Windows.Forms.CheckBox chkEatOut;
        private System.Windows.Forms.CheckBox chkRadio;
        private System.Windows.Forms.CheckBox chkMovies;
        private System.Windows.Forms.CheckBox chkPizza;
        private System.Windows.Forms.CheckBox chkPasta;
        private System.Windows.Forms.CheckBox chkPapaAndWors;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNextPage;
    }
}

