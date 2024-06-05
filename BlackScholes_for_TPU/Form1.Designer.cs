namespace BlackScholes_for_TPU
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PerformCalculation = new System.Windows.Forms.Button();
            this.stockPriceTextBox = new System.Windows.Forms.TextBox();
            this.strikePriceTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.volatilityTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // PerformCalculation
            // 
            this.PerformCalculation.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.PerformCalculation.Location = new System.Drawing.Point(658, 367);
            this.PerformCalculation.Name = "PerformCalculation";
            this.PerformCalculation.Size = new System.Drawing.Size(130, 71);
            this.PerformCalculation.TabIndex = 0;
            this.PerformCalculation.Text = "Запуск расчета";
            this.PerformCalculation.UseVisualStyleBackColor = true;
            this.PerformCalculation.Click += new System.EventHandler(this.PerformCalculation_Click);
            // 
            // stockPriceTextBox
            // 
            this.stockPriceTextBox.Location = new System.Drawing.Point(208, 47);
            this.stockPriceTextBox.Name = "stockPriceTextBox";
            this.stockPriceTextBox.Size = new System.Drawing.Size(142, 20);
            this.stockPriceTextBox.TabIndex = 1;
            this.stockPriceTextBox.TextChanged += new System.EventHandler(this.stockPriceTextBox_TextChanged);
            // 
            // strikePriceTextBox
            // 
            this.strikePriceTextBox.Location = new System.Drawing.Point(208, 95);
            this.strikePriceTextBox.Name = "strikePriceTextBox";
            this.strikePriceTextBox.Size = new System.Drawing.Size(142, 20);
            this.strikePriceTextBox.TabIndex = 2;
            this.strikePriceTextBox.TextChanged += new System.EventHandler(this.strikePriceTextBox_TextChanged);
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(208, 143);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(142, 20);
            this.interestRateTextBox.TabIndex = 3;
            this.interestRateTextBox.TextChanged += new System.EventHandler(this.interestRateTextBox_TextChanged);
            // 
            // volatilityTextBox
            // 
            this.volatilityTextBox.Location = new System.Drawing.Point(208, 193);
            this.volatilityTextBox.Name = "volatilityTextBox";
            this.volatilityTextBox.Size = new System.Drawing.Size(142, 20);
            this.volatilityTextBox.TabIndex = 4;
            this.volatilityTextBox.TextChanged += new System.EventHandler(this.volatilityTextBox_TextChanged);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(208, 245);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(142, 20);
            this.timeTextBox.TabIndex = 5;
            this.timeTextBox.TextChanged += new System.EventHandler(this.timeTextBox_TextChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(208, 294);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.ReadOnly = true;
            this.resultLabel.Size = new System.Drawing.Size(142, 20);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.TextChanged += new System.EventHandler(this.resultLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Цена акции";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(413, 48);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(345, 248);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Цена страйка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Волатильность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Время до истечения срока";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Цена колл-опциона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Отображает изменение стоимости опциона в зависимости от времени";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.volatilityTextBox);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.strikePriceTextBox);
            this.Controls.Add(this.stockPriceTextBox);
            this.Controls.Add(this.PerformCalculation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Расчет опциона Блэка-Шоулса";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PerformCalculation;
        private System.Windows.Forms.TextBox stockPriceTextBox;
        private System.Windows.Forms.TextBox strikePriceTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox volatilityTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

