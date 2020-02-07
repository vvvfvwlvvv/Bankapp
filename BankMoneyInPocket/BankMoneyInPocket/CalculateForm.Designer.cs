namespace BankMoneyInPocket
{
    partial class CalculateForm
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
            this.trackSum = new System.Windows.Forms.TrackBar();
            this.trackEveryMonth = new System.Windows.Forms.TrackBar();
            this.trackSrok = new System.Windows.Forms.TrackBar();
            this.tbEveryMonthPayment = new System.Windows.Forms.TextBox();
            this.tbSrok = new System.Windows.Forms.TextBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbWallet = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pIncome = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lStabIncome = new System.Windows.Forms.Label();
            this.lClassicIncome = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lOptimalincome = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bEqualsParam = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEveryMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSrok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallet)).BeginInit();
            this.pIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackSum
            // 
            this.trackSum.Location = new System.Drawing.Point(35, 98);
            this.trackSum.Maximum = 10000;
            this.trackSum.Minimum = 10;
            this.trackSum.Name = "trackSum";
            this.trackSum.Size = new System.Drawing.Size(373, 45);
            this.trackSum.TabIndex = 0;
            this.trackSum.Value = 10;
            this.trackSum.Scroll += new System.EventHandler(this.TrackSum_Scroll);
            // 
            // trackEveryMonth
            // 
            this.trackEveryMonth.Location = new System.Drawing.Point(35, 359);
            this.trackEveryMonth.Maximum = 500;
            this.trackEveryMonth.Name = "trackEveryMonth";
            this.trackEveryMonth.Size = new System.Drawing.Size(373, 45);
            this.trackEveryMonth.TabIndex = 1;
            this.trackEveryMonth.Scroll += new System.EventHandler(this.TrackEveryMonth_Scroll);
            // 
            // trackSrok
            // 
            this.trackSrok.Location = new System.Drawing.Point(35, 223);
            this.trackSrok.Maximum = 60;
            this.trackSrok.Minimum = 3;
            this.trackSrok.Name = "trackSrok";
            this.trackSrok.Size = new System.Drawing.Size(373, 45);
            this.trackSrok.TabIndex = 2;
            this.trackSrok.Value = 3;
            this.trackSrok.Scroll += new System.EventHandler(this.TrackSrok_Scroll);
            // 
            // tbEveryMonthPayment
            // 
            this.tbEveryMonthPayment.Location = new System.Drawing.Point(35, 315);
            this.tbEveryMonthPayment.Multiline = true;
            this.tbEveryMonthPayment.Name = "tbEveryMonthPayment";
            this.tbEveryMonthPayment.Size = new System.Drawing.Size(373, 38);
            this.tbEveryMonthPayment.TabIndex = 3;
            // 
            // tbSrok
            // 
            this.tbSrok.Location = new System.Drawing.Point(35, 179);
            this.tbSrok.Multiline = true;
            this.tbSrok.Name = "tbSrok";
            this.tbSrok.Size = new System.Drawing.Size(373, 38);
            this.tbSrok.TabIndex = 4;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(35, 54);
            this.tbSum.Multiline = true;
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(373, 38);
            this.tbSum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Срок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ежемесячное пополнение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(339, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Рассчитать доход";
            // 
            // pbWallet
            // 
            this.pbWallet.Location = new System.Drawing.Point(741, 13);
            this.pbWallet.Name = "pbWallet";
            this.pbWallet.Size = new System.Drawing.Size(50, 35);
            this.pbWallet.TabIndex = 11;
            this.pbWallet.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(536, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Деньги в каждый карман";
            // 
            // pIncome
            // 
            this.pIncome.Controls.Add(this.label7);
            this.pIncome.Controls.Add(this.label6);
            this.pIncome.Controls.Add(this.bEqualsParam);
            this.pIncome.Controls.Add(this.label16);
            this.pIncome.Controls.Add(this.lOptimalincome);
            this.pIncome.Controls.Add(this.label12);
            this.pIncome.Controls.Add(this.lClassicIncome);
            this.pIncome.Controls.Add(this.lStabIncome);
            this.pIncome.Controls.Add(this.label8);
            this.pIncome.Controls.Add(this.label5);
            this.pIncome.Location = new System.Drawing.Point(533, 64);
            this.pIncome.Name = "pIncome";
            this.pIncome.Size = new System.Drawing.Size(248, 355);
            this.pIncome.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Стабильный";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Доход по вкладу:";
            // 
            // lStabIncome
            // 
            this.lStabIncome.AutoSize = true;
            this.lStabIncome.Location = new System.Drawing.Point(23, 66);
            this.lStabIncome.Name = "lStabIncome";
            this.lStabIncome.Size = new System.Drawing.Size(13, 13);
            this.lStabIncome.TabIndex = 4;
            this.lStabIncome.Text = "0";
            // 
            // lClassicIncome
            // 
            this.lClassicIncome.AutoSize = true;
            this.lClassicIncome.Location = new System.Drawing.Point(23, 254);
            this.lClassicIncome.Name = "lClassicIncome";
            this.lClassicIncome.Size = new System.Drawing.Size(13, 13);
            this.lClassicIncome.TabIndex = 5;
            this.lClassicIncome.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(22, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Стандарт";
            // 
            // lOptimalincome
            // 
            this.lOptimalincome.AutoSize = true;
            this.lOptimalincome.Location = new System.Drawing.Point(23, 171);
            this.lOptimalincome.Name = "lOptimalincome";
            this.lOptimalincome.Size = new System.Drawing.Size(13, 13);
            this.lOptimalincome.TabIndex = 8;
            this.lOptimalincome.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(22, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Оптимальный";
            // 
            // bEqualsParam
            // 
            this.bEqualsParam.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bEqualsParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEqualsParam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEqualsParam.Location = new System.Drawing.Point(54, 295);
            this.bEqualsParam.Name = "bEqualsParam";
            this.bEqualsParam.Size = new System.Drawing.Size(163, 45);
            this.bEqualsParam.TabIndex = 11;
            this.bEqualsParam.Text = "Сравнить параметры";
            this.bEqualsParam.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Доход по вкладу:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Доход по вкладу:";
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pIncome);
            this.Controls.Add(this.pbWallet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.tbSrok);
            this.Controls.Add(this.tbEveryMonthPayment);
            this.Controls.Add(this.trackSrok);
            this.Controls.Add(this.trackEveryMonth);
            this.Controls.Add(this.trackSum);
            this.Name = "CalculateForm";
            this.Text = "CalculateForm";
            this.Load += new System.EventHandler(this.CalculateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEveryMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSrok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallet)).EndInit();
            this.pIncome.ResumeLayout(false);
            this.pIncome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackSum;
        private System.Windows.Forms.TrackBar trackEveryMonth;
        private System.Windows.Forms.TrackBar trackSrok;
        private System.Windows.Forms.TextBox tbEveryMonthPayment;
        private System.Windows.Forms.TextBox tbSrok;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbWallet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pIncome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bEqualsParam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lOptimalincome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lClassicIncome;
        private System.Windows.Forms.Label lStabIncome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}