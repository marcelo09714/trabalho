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
            this.comecar = new System.Windows.Forms.Button();
            this.labelHoraExame = new System.Windows.Forms.Label();
            this.labelDataExame = new System.Windows.Forms.Label();
            this.botaoRetroceder = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.textBoxNomeExame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comecar
            // 
            this.comecar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comecar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comecar.Location = new System.Drawing.Point(12, 316);
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
            this.labelDataExame.Location = new System.Drawing.Point(450, 9);
            this.labelDataExame.Name = "labelDataExame";
            this.labelDataExame.Size = new System.Drawing.Size(91, 18);
            this.labelDataExame.TabIndex = 7;
            this.labelDataExame.Text = "DiaMesAno";
            // 
            // botaoRetroceder
            // 
            this.botaoRetroceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoRetroceder.BackColor = System.Drawing.Color.Transparent;
            this.botaoRetroceder.BackgroundImage = global::TrabalhoEMG.Properties.Resources._8bb42ed9;
            this.botaoRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoRetroceder.Location = new System.Drawing.Point(253, 317);
            this.botaoRetroceder.Name = "botaoRetroceder";
            this.botaoRetroceder.Size = new System.Drawing.Size(41, 36);
            this.botaoRetroceder.TabIndex = 10;
            this.botaoRetroceder.UseVisualStyleBackColor = false;
            this.botaoRetroceder.Click += new System.EventHandler(this.botaoRetroceder_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGravar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGravar.Location = new System.Drawing.Point(130, 316);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(96, 36);
            this.buttonGravar.TabIndex = 11;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // textBoxNomeExame
            // 
            this.textBoxNomeExame.Location = new System.Drawing.Point(412, 326);
            this.textBoxNomeExame.Name = "textBoxNomeExame";
            this.textBoxNomeExame.Size = new System.Drawing.Size(223, 20);
            this.textBoxNomeExame.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome Do Exame";
            // 
            // Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoEMG.Properties.Resources.Vm1lKT;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeExame);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.botaoRetroceder);
            this.Controls.Add(this.labelDataExame);
            this.Controls.Add(this.labelHoraExame);
            this.Controls.Add(this.comecar);
            this.Name = "Exame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button comecar;
        private System.Windows.Forms.Label labelHoraExame;
        private System.Windows.Forms.Label labelDataExame;
        private System.Windows.Forms.Button botaoRetroceder;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.TextBox textBoxNomeExame;
        private System.Windows.Forms.Label label1;
    }
}