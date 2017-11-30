namespace TrabalhoEMG
{
    partial class Exame
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comecar = new System.Windows.Forms.Button();
            this.labelHoraExame = new System.Windows.Forms.Label();
            this.labelDataExame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico
            // 
            chartArea4.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.grafico.Legends.Add(legend4);
            this.grafico.Location = new System.Drawing.Point(12, 43);
            this.grafico.Name = "grafico";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Primeiro Exame";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Segundo Exame";
            this.grafico.Series.Add(series7);
            this.grafico.Series.Add(series8);
            this.grafico.Size = new System.Drawing.Size(873, 376);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "grafico";
            // 
            // comecar
            // 
            this.comecar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comecar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comecar.Location = new System.Drawing.Point(12, 518);
            this.comecar.Name = "comecar";
            this.comecar.Size = new System.Drawing.Size(96, 36);
            this.comecar.TabIndex = 1;
            this.comecar.Text = "Começar";
            this.comecar.UseVisualStyleBackColor = true;
            this.comecar.Click += new System.EventHandler(this.comecar_Click);
            // 
            // labelHoraExame
            // 
            this.labelHoraExame.AutoSize = true;
            this.labelHoraExame.BackColor = System.Drawing.Color.White;
            this.labelHoraExame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraExame.Location = new System.Drawing.Point(9, 9);
            this.labelHoraExame.Name = "labelHoraExame";
            this.labelHoraExame.Size = new System.Drawing.Size(167, 18);
            this.labelHoraExame.TabIndex = 6;
            this.labelHoraExame.Text = "HoraMinutosSegundos";
            // 
            // labelDataExame
            // 
            this.labelDataExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataExame.AutoSize = true;
            this.labelDataExame.BackColor = System.Drawing.Color.White;
            this.labelDataExame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataExame.Location = new System.Drawing.Point(700, 9);
            this.labelDataExame.Name = "labelDataExame";
            this.labelDataExame.Size = new System.Drawing.Size(91, 18);
            this.labelDataExame.TabIndex = 7;
            this.labelDataExame.Text = "DiaMesAno";
            // 
            // Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoEMG.Properties.Resources.Vm1lKT;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 566);
            this.Controls.Add(this.labelDataExame);
            this.Controls.Add(this.labelHoraExame);
            this.Controls.Add(this.comecar);
            this.Controls.Add(this.grafico);
            this.Name = "Exame";
            this.Text = "Exame";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button comecar;
        private System.Windows.Forms.Label labelHoraExame;
        private System.Windows.Forms.Label labelDataExame;
    }
}