namespace BankMoneyInPocket
{
    partial class ComparisonIncome
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.bPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(12, 12);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(599, 284);
            this.dgView.TabIndex = 0;
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            // 
            // bPDF
            // 
            this.bPDF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bPDF.Location = new System.Drawing.Point(241, 319);
            this.bPDF.Name = "bPDF";
            this.bPDF.Size = new System.Drawing.Size(156, 35);
            this.bPDF.TabIndex = 1;
            this.bPDF.Text = "Сформировать выписку";
            this.bPDF.UseVisualStyleBackColor = false;
            this.bPDF.Click += new System.EventHandler(this.bPDF_Click);
            // 
            // ComparisonIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(623, 366);
            this.Controls.Add(this.bPDF);
            this.Controls.Add(this.dgView);
            this.Name = "ComparisonIncome";
            this.Text = "ComparisonIncome";
            this.Load += new System.EventHandler(this.ComparisonIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button bPDF;
    }
}