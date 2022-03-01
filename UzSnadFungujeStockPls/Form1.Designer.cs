
namespace UzSnadFungujeStockPls
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetData = new System.Windows.Forms.Button();
            this.TBSymbol = new System.Windows.Forms.TextBox();
            this.labSymTB = new System.Windows.Forms.Label();
            this.labStockPrice = new System.Windows.Forms.Label();
            this.labStockName = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labStockProfit = new System.Windows.Forms.Label();
            this.labTodaysProfit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetData
            // 
            this.GetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GetData.Location = new System.Drawing.Point(185, 23);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(151, 39);
            this.GetData.TabIndex = 0;
            this.GetData.Text = "Vyhledej";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // TBSymbol
            // 
            this.TBSymbol.Location = new System.Drawing.Point(52, 42);
            this.TBSymbol.Name = "TBSymbol";
            this.TBSymbol.Size = new System.Drawing.Size(110, 20);
            this.TBSymbol.TabIndex = 1;
            // 
            // labSymTB
            // 
            this.labSymTB.AutoSize = true;
            this.labSymTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSymTB.Location = new System.Drawing.Point(49, 23);
            this.labSymTB.Name = "labSymTB";
            this.labSymTB.Size = new System.Drawing.Size(113, 16);
            this.labSymTB.TabIndex = 2;
            this.labSymTB.Text = "Stock\'s symbol";
            // 
            // labStockPrice
            // 
            this.labStockPrice.AutoSize = true;
            this.labStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labStockPrice.Location = new System.Drawing.Point(85, 127);
            this.labStockPrice.Name = "labStockPrice";
            this.labStockPrice.Size = new System.Drawing.Size(46, 18);
            this.labStockPrice.TabIndex = 3;
            this.labStockPrice.Text = "Price:";
            // 
            // labStockName
            // 
            this.labStockName.AutoSize = true;
            this.labStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labStockName.Location = new System.Drawing.Point(79, 109);
            this.labStockName.Name = "labStockName";
            this.labStockName.Size = new System.Drawing.Size(52, 18);
            this.labStockName.TabIndex = 4;
            this.labStockName.Text = "Name:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labName.Location = new System.Drawing.Point(146, 109);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 18);
            this.labName.TabIndex = 5;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPrice.Location = new System.Drawing.Point(146, 127);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(16, 18);
            this.labPrice.TabIndex = 6;
            this.labPrice.Text = "0";
            // 
            // labStockProfit
            // 
            this.labStockProfit.AutoSize = true;
            this.labStockProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labStockProfit.Location = new System.Drawing.Point(28, 145);
            this.labStockProfit.Name = "labStockProfit";
            this.labStockProfit.Size = new System.Drawing.Size(103, 18);
            this.labStockProfit.TabIndex = 7;
            this.labStockProfit.Text = "Today\'s Profit:";
            // 
            // labTodaysProfit
            // 
            this.labTodaysProfit.AutoSize = true;
            this.labTodaysProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTodaysProfit.Location = new System.Drawing.Point(146, 145);
            this.labTodaysProfit.Name = "labTodaysProfit";
            this.labTodaysProfit.Size = new System.Drawing.Size(16, 18);
            this.labTodaysProfit.TabIndex = 8;
            this.labTodaysProfit.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 366);
            this.Controls.Add(this.labTodaysProfit);
            this.Controls.Add(this.labStockProfit);
            this.Controls.Add(this.labStockName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labStockPrice);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labSymTB);
            this.Controls.Add(this.TBSymbol);
            this.Controls.Add(this.GetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.TextBox TBSymbol;
        private System.Windows.Forms.Label labSymTB;
        private System.Windows.Forms.Label labStockPrice;
        private System.Windows.Forms.Label labStockName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labStockProfit;
        private System.Windows.Forms.Label labTodaysProfit;
    }
}

