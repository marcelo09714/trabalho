namespace TrabalhoEMG
{
    partial class ListaExames
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
            this.dataGridViewExames = new System.Windows.Forms.DataGridView();
            this.labelHoraListaExames = new System.Windows.Forms.Label();
            this.labelDataListaExames = new System.Windows.Forms.Label();
            this.buttonFazerExame = new System.Windows.Forms.Button();
            this.botaoRetroceder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExames)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExames
            // 
            this.dataGridViewExames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExames.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExames.Location = new System.Drawing.Point(13, 56);
            this.dataGridViewExames.Name = "dataGridViewExames";
            this.dataGridViewExames.Size = new System.Drawing.Size(622, 245);
            this.dataGridViewExames.TabIndex = 0;
            // 
            // labelHoraListaExames
            // 
            this.labelHoraListaExames.AutoSize = true;
            this.labelHoraListaExames.BackColor = System.Drawing.Color.White;
            this.labelHoraListaExames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraListaExames.Location = new System.Drawing.Point(12, 21);
            this.labelHoraListaExames.Name = "labelHoraListaExames";
            this.labelHoraListaExames.Size = new System.Drawing.Size(167, 18);
            this.labelHoraListaExames.TabIndex = 6;
            this.labelHoraListaExames.Text = "HoraMinutosSegundos";
            // 
            // labelDataListaExames
            // 
            this.labelDataListaExames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataListaExames.AutoSize = true;
            this.labelDataListaExames.BackColor = System.Drawing.Color.White;
            this.labelDataListaExames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataListaExames.Location = new System.Drawing.Point(450, 21);
            this.labelDataListaExames.Name = "labelDataListaExames";
            this.labelDataListaExames.Size = new System.Drawing.Size(91, 18);
            this.labelDataListaExames.TabIndex = 7;
            this.labelDataListaExames.Text = "DiaMesAno";
            // 
            // buttonFazerExame
            // 
            this.buttonFazerExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFazerExame.BackColor = System.Drawing.Color.Honeydew;
            this.buttonFazerExame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFazerExame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFazerExame.Location = new System.Drawing.Point(519, 322);
            this.buttonFazerExame.Name = "buttonFazerExame";
            this.buttonFazerExame.Size = new System.Drawing.Size(115, 30);
            this.buttonFazerExame.TabIndex = 8;
            this.buttonFazerExame.Text = "Fazer Exame";
            this.buttonFazerExame.UseVisualStyleBackColor = false;
            this.buttonFazerExame.Click += new System.EventHandler(this.botaoFazerExame_Click);
            // 
            // botaoRetroceder
            // 
            this.botaoRetroceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoRetroceder.BackColor = System.Drawing.Color.Transparent;
            this.botaoRetroceder.BackgroundImage = global::TrabalhoEMG.Properties.Resources._8bb42ed9;
            this.botaoRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoRetroceder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRetroceder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoRetroceder.Location = new System.Drawing.Point(15, 307);
            this.botaoRetroceder.Name = "botaoRetroceder";
            this.botaoRetroceder.Size = new System.Drawing.Size(48, 45);
            this.botaoRetroceder.TabIndex = 9;
            this.botaoRetroceder.UseVisualStyleBackColor = false;
            this.botaoRetroceder.Click += new System.EventHandler(this.botaoRetroceder_Click);
            // 
            // ListaExames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoEMG.Properties.Resources._11530_beautiful_abstract_backgrounds_design_elements_5000x3750_h;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 364);
            this.Controls.Add(this.botaoRetroceder);
            this.Controls.Add(this.buttonFazerExame);
            this.Controls.Add(this.labelDataListaExames);
            this.Controls.Add(this.labelHoraListaExames);
            this.Controls.Add(this.dataGridViewExames);
            this.Name = "ListaExames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaExames";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExames;
        private System.Windows.Forms.Label labelHoraListaExames;
        private System.Windows.Forms.Label labelDataListaExames;
        private System.Windows.Forms.Button buttonFazerExame;
        private System.Windows.Forms.Button botaoRetroceder;
    }
}