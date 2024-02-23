namespace Terwilliger_MortgageMania
{
    partial class MortgageCalculator
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
            this.AppPrincipal = new System.Windows.Forms.Label();
            this.AppTermInYears = new System.Windows.Forms.Label();
            this.TxtPrincipal = new System.Windows.Forms.TextBox();
            this.App15Year = new System.Windows.Forms.RadioButton();
            this.App30Year = new System.Windows.Forms.RadioButton();
            this.AppOther = new System.Windows.Forms.RadioButton();
            this.AppInterest = new System.Windows.Forms.Label();
            this.InterestDrop = new System.Windows.Forms.ComboBox();
            this.TxtOther = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.AppPayment = new System.Windows.Forms.Label();
            this.AppError = new System.Windows.Forms.Label();
            this.AppErrorBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppPrincipal
            // 
            this.AppPrincipal.AutoSize = true;
            this.AppPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppPrincipal.Location = new System.Drawing.Point(26, 40);
            this.AppPrincipal.Name = "AppPrincipal";
            this.AppPrincipal.Size = new System.Drawing.Size(82, 20);
            this.AppPrincipal.TabIndex = 0;
            this.AppPrincipal.Text = "Principal:";
            // 
            // AppTermInYears
            // 
            this.AppTermInYears.AutoSize = true;
            this.AppTermInYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTermInYears.Location = new System.Drawing.Point(26, 70);
            this.AppTermInYears.Name = "AppTermInYears";
            this.AppTermInYears.Size = new System.Drawing.Size(118, 20);
            this.AppTermInYears.TabIndex = 1;
            this.AppTermInYears.Text = "Term In years";
            // 
            // TxtPrincipal
            // 
            this.TxtPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrincipal.Location = new System.Drawing.Point(114, 40);
            this.TxtPrincipal.Name = "TxtPrincipal";
            this.TxtPrincipal.Size = new System.Drawing.Size(100, 23);
            this.TxtPrincipal.TabIndex = 2;
            // 
            // App15Year
            // 
            this.App15Year.AutoSize = true;
            this.App15Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App15Year.Location = new System.Drawing.Point(30, 110);
            this.App15Year.Name = "App15Year";
            this.App15Year.Size = new System.Drawing.Size(101, 24);
            this.App15Year.TabIndex = 4;
            this.App15Year.TabStop = true;
            this.App15Year.Text = "15 YEAR";
            this.App15Year.UseVisualStyleBackColor = true;
            // 
            // App30Year
            // 
            this.App30Year.AutoSize = true;
            this.App30Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App30Year.Location = new System.Drawing.Point(30, 140);
            this.App30Year.Name = "App30Year";
            this.App30Year.Size = new System.Drawing.Size(101, 24);
            this.App30Year.TabIndex = 5;
            this.App30Year.TabStop = true;
            this.App30Year.Text = "30 YEAR";
            this.App30Year.UseVisualStyleBackColor = true;
            // 
            // AppOther
            // 
            this.AppOther.AutoSize = true;
            this.AppOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppOther.Location = new System.Drawing.Point(30, 170);
            this.AppOther.Name = "AppOther";
            this.AppOther.Size = new System.Drawing.Size(87, 24);
            this.AppOther.TabIndex = 6;
            this.AppOther.TabStop = true;
            this.AppOther.Text = "Other...";
            this.AppOther.UseVisualStyleBackColor = true;
            this.AppOther.CheckedChanged += new System.EventHandler(this.AppOther_CheckedChanged);
            // 
            // AppInterest
            // 
            this.AppInterest.AutoSize = true;
            this.AppInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppInterest.Location = new System.Drawing.Point(26, 210);
            this.AppInterest.Name = "AppInterest";
            this.AppInterest.Size = new System.Drawing.Size(72, 20);
            this.AppInterest.TabIndex = 7;
            this.AppInterest.Text = "Interest";
            // 
            // InterestDrop
            // 
            this.InterestDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterestDrop.FormattingEnabled = true;
            this.InterestDrop.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.InterestDrop.Location = new System.Drawing.Point(114, 208);
            this.InterestDrop.Name = "InterestDrop";
            this.InterestDrop.Size = new System.Drawing.Size(42, 21);
            this.InterestDrop.TabIndex = 8;
            // 
            // TxtOther
            // 
            this.TxtOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOther.Location = new System.Drawing.Point(114, 170);
            this.TxtOther.Name = "TxtOther";
            this.TxtOther.Size = new System.Drawing.Size(100, 23);
            this.TxtOther.TabIndex = 9;
            this.TxtOther.Visible = false;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(30, 248);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(231, 59);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Calculate Payment";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(30, 329);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(101, 59);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(160, 329);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 59);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AppPayment
            // 
            this.AppPayment.AutoSize = true;
            this.AppPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppPayment.Location = new System.Drawing.Point(26, 407);
            this.AppPayment.Name = "AppPayment";
            this.AppPayment.Size = new System.Drawing.Size(0, 20);
            this.AppPayment.TabIndex = 13;
            // 
            // AppError
            // 
            this.AppError.Location = new System.Drawing.Point(0, 0);
            this.AppError.Name = "AppError";
            this.AppError.Size = new System.Drawing.Size(100, 23);
            this.AppError.TabIndex = 0;
            // 
            // AppErrorBox
            // 
            this.AppErrorBox.AutoSize = true;
            this.AppErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppErrorBox.Location = new System.Drawing.Point(12, 389);
            this.AppErrorBox.Name = "AppErrorBox";
            this.AppErrorBox.Size = new System.Drawing.Size(0, 13);
            this.AppErrorBox.TabIndex = 14;
            // 
            // MortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 452);
            this.Controls.Add(this.AppErrorBox);
            this.Controls.Add(this.AppError);
            this.Controls.Add(this.AppPayment);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.TxtOther);
            this.Controls.Add(this.InterestDrop);
            this.Controls.Add(this.AppInterest);
            this.Controls.Add(this.AppOther);
            this.Controls.Add(this.App30Year);
            this.Controls.Add(this.App15Year);
            this.Controls.Add(this.TxtPrincipal);
            this.Controls.Add(this.AppTermInYears);
            this.Controls.Add(this.AppPrincipal);
            this.Name = "MortgageCalculator";
            this.Text = "Jayme Terwilliger: Mortgage Calculator";
            this.Load += new System.EventHandler(this.MortgageCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppPrincipal;
        private System.Windows.Forms.Label AppTermInYears;
        private System.Windows.Forms.TextBox TxtPrincipal;
        private System.Windows.Forms.RadioButton App15Year;
        private System.Windows.Forms.RadioButton App30Year;
        private System.Windows.Forms.RadioButton AppOther;
        private System.Windows.Forms.Label AppInterest;
        private System.Windows.Forms.ComboBox InterestDrop;
        private System.Windows.Forms.TextBox TxtOther;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label AppPayment;
        private System.Windows.Forms.Label AppError;
        private System.Windows.Forms.Label AppErrorBox;
    }
}

