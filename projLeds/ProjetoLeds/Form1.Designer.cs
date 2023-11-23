namespace ProjetoLeds
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkLed1 = new System.Windows.Forms.CheckBox();
            this.btnLed1 = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLed = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnLed2 = new System.Windows.Forms.Button();
            this.chkLed2 = new System.Windows.Forms.CheckBox();
            this.btnLed4 = new System.Windows.Forms.Button();
            this.chkLed4 = new System.Windows.Forms.CheckBox();
            this.btnLed3 = new System.Windows.Forms.Button();
            this.chkLed3 = new System.Windows.Forms.CheckBox();
            this.btnLed6 = new System.Windows.Forms.Button();
            this.chkLed6 = new System.Windows.Forms.CheckBox();
            this.btnLed5 = new System.Windows.Forms.Button();
            this.chkLed5 = new System.Windows.Forms.CheckBox();
            this.btnLed7 = new System.Windows.Forms.Button();
            this.chkLed7 = new System.Windows.Forms.CheckBox();
            this.btnLed8 = new System.Windows.Forms.Button();
            this.chkLed8 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkLed1
            // 
            this.chkLed1.AutoSize = true;
            this.chkLed1.Enabled = false;
            this.chkLed1.Location = new System.Drawing.Point(294, 53);
            this.chkLed1.Name = "chkLed1";
            this.chkLed1.Size = new System.Drawing.Size(15, 14);
            this.chkLed1.TabIndex = 0;
            this.chkLed1.UseVisualStyleBackColor = true;
            // 
            // btnLed1
            // 
            this.btnLed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLed1.Location = new System.Drawing.Point(285, 73);
            this.btnLed1.Name = "btnLed1";
            this.btnLed1.Size = new System.Drawing.Size(33, 23);
            this.btnLed1.TabIndex = 1;
            this.btnLed1.UseVisualStyleBackColor = false;
            this.btnLed1.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(163, 172);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(62, 23);
            this.btnEstado.TabIndex = 16;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "LED:";
            // 
            // txtLed
            // 
            this.txtLed.Location = new System.Drawing.Point(95, 175);
            this.txtLed.Name = "txtLed";
            this.txtLed.Size = new System.Drawing.Size(54, 20);
            this.txtLed.TabIndex = 18;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Enabled = false;
            this.chkEstado.Location = new System.Drawing.Point(244, 177);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 19;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnLed2
            // 
            this.btnLed2.Location = new System.Drawing.Point(246, 73);
            this.btnLed2.Name = "btnLed2";
            this.btnLed2.Size = new System.Drawing.Size(33, 23);
            this.btnLed2.TabIndex = 21;
            this.btnLed2.UseVisualStyleBackColor = true;
            this.btnLed2.Click += new System.EventHandler(this.btnLed2_Click);
            // 
            // chkLed2
            // 
            this.chkLed2.AutoSize = true;
            this.chkLed2.Enabled = false;
            this.chkLed2.Location = new System.Drawing.Point(255, 53);
            this.chkLed2.Name = "chkLed2";
            this.chkLed2.Size = new System.Drawing.Size(15, 14);
            this.chkLed2.TabIndex = 20;
            this.chkLed2.UseVisualStyleBackColor = true;
            // 
            // btnLed4
            // 
            this.btnLed4.Location = new System.Drawing.Point(168, 73);
            this.btnLed4.Name = "btnLed4";
            this.btnLed4.Size = new System.Drawing.Size(33, 23);
            this.btnLed4.TabIndex = 25;
            this.btnLed4.UseVisualStyleBackColor = true;
            this.btnLed4.Click += new System.EventHandler(this.btnLed4_Click);
            // 
            // chkLed4
            // 
            this.chkLed4.AutoSize = true;
            this.chkLed4.Enabled = false;
            this.chkLed4.Location = new System.Drawing.Point(177, 53);
            this.chkLed4.Name = "chkLed4";
            this.chkLed4.Size = new System.Drawing.Size(15, 14);
            this.chkLed4.TabIndex = 24;
            this.chkLed4.UseVisualStyleBackColor = true;
            // 
            // btnLed3
            // 
            this.btnLed3.Location = new System.Drawing.Point(207, 73);
            this.btnLed3.Name = "btnLed3";
            this.btnLed3.Size = new System.Drawing.Size(33, 23);
            this.btnLed3.TabIndex = 23;
            this.btnLed3.UseVisualStyleBackColor = true;
            this.btnLed3.Click += new System.EventHandler(this.btnLed3_Click);
            // 
            // chkLed3
            // 
            this.chkLed3.AutoSize = true;
            this.chkLed3.Enabled = false;
            this.chkLed3.Location = new System.Drawing.Point(216, 53);
            this.chkLed3.Name = "chkLed3";
            this.chkLed3.Size = new System.Drawing.Size(15, 14);
            this.chkLed3.TabIndex = 22;
            this.chkLed3.UseVisualStyleBackColor = true;
            // 
            // btnLed6
            // 
            this.btnLed6.Location = new System.Drawing.Point(90, 73);
            this.btnLed6.Name = "btnLed6";
            this.btnLed6.Size = new System.Drawing.Size(33, 23);
            this.btnLed6.TabIndex = 29;
            this.btnLed6.UseVisualStyleBackColor = true;
            this.btnLed6.Click += new System.EventHandler(this.btnLed6_Click);
            // 
            // chkLed6
            // 
            this.chkLed6.AutoSize = true;
            this.chkLed6.Enabled = false;
            this.chkLed6.Location = new System.Drawing.Point(99, 53);
            this.chkLed6.Name = "chkLed6";
            this.chkLed6.Size = new System.Drawing.Size(15, 14);
            this.chkLed6.TabIndex = 28;
            this.chkLed6.UseVisualStyleBackColor = true;
            // 
            // btnLed5
            // 
            this.btnLed5.Location = new System.Drawing.Point(129, 73);
            this.btnLed5.Name = "btnLed5";
            this.btnLed5.Size = new System.Drawing.Size(33, 23);
            this.btnLed5.TabIndex = 27;
            this.btnLed5.UseVisualStyleBackColor = true;
            this.btnLed5.Click += new System.EventHandler(this.btnLed5_Click);
            // 
            // chkLed5
            // 
            this.chkLed5.AutoSize = true;
            this.chkLed5.Enabled = false;
            this.chkLed5.Location = new System.Drawing.Point(138, 53);
            this.chkLed5.Name = "chkLed5";
            this.chkLed5.Size = new System.Drawing.Size(15, 14);
            this.chkLed5.TabIndex = 26;
            this.chkLed5.UseVisualStyleBackColor = true;
            // 
            // btnLed7
            // 
            this.btnLed7.Location = new System.Drawing.Point(51, 73);
            this.btnLed7.Name = "btnLed7";
            this.btnLed7.Size = new System.Drawing.Size(33, 23);
            this.btnLed7.TabIndex = 31;
            this.btnLed7.UseVisualStyleBackColor = true;
            this.btnLed7.Click += new System.EventHandler(this.btnLed7_Click);
            // 
            // chkLed7
            // 
            this.chkLed7.AutoSize = true;
            this.chkLed7.Enabled = false;
            this.chkLed7.Location = new System.Drawing.Point(60, 53);
            this.chkLed7.Name = "chkLed7";
            this.chkLed7.Size = new System.Drawing.Size(15, 14);
            this.chkLed7.TabIndex = 30;
            this.chkLed7.UseVisualStyleBackColor = true;
            // 
            // btnLed8
            // 
            this.btnLed8.Location = new System.Drawing.Point(12, 73);
            this.btnLed8.Name = "btnLed8";
            this.btnLed8.Size = new System.Drawing.Size(33, 23);
            this.btnLed8.TabIndex = 33;
            this.btnLed8.UseVisualStyleBackColor = true;
            this.btnLed8.Click += new System.EventHandler(this.btnLed8_Click);
            // 
            // chkLed8
            // 
            this.chkLed8.AutoSize = true;
            this.chkLed8.Enabled = false;
            this.chkLed8.Location = new System.Drawing.Point(21, 53);
            this.chkLed8.Name = "chkLed8";
            this.chkLed8.Size = new System.Drawing.Size(15, 14);
            this.chkLed8.TabIndex = 32;
            this.chkLed8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::ProjetoLeds.Properties.Resources.istockphoto_905432958_170667a;
            this.ClientSize = new System.Drawing.Size(331, 266);
            this.Controls.Add(this.btnLed8);
            this.Controls.Add(this.chkLed8);
            this.Controls.Add(this.btnLed7);
            this.Controls.Add(this.chkLed7);
            this.Controls.Add(this.btnLed6);
            this.Controls.Add(this.chkLed6);
            this.Controls.Add(this.btnLed5);
            this.Controls.Add(this.chkLed5);
            this.Controls.Add(this.btnLed4);
            this.Controls.Add(this.chkLed4);
            this.Controls.Add(this.btnLed3);
            this.Controls.Add(this.chkLed3);
            this.Controls.Add(this.btnLed2);
            this.Controls.Add(this.chkLed2);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txtLed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnLed1);
            this.Controls.Add(this.chkLed1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PROJETO LEDS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLed1;
        private System.Windows.Forms.Button btnLed1;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLed;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnLed2;
        private System.Windows.Forms.CheckBox chkLed2;
        private System.Windows.Forms.Button btnLed4;
        private System.Windows.Forms.CheckBox chkLed4;
        private System.Windows.Forms.Button btnLed3;
        private System.Windows.Forms.CheckBox chkLed3;
        private System.Windows.Forms.Button btnLed6;
        private System.Windows.Forms.CheckBox chkLed6;
        private System.Windows.Forms.Button btnLed5;
        private System.Windows.Forms.CheckBox chkLed5;
        private System.Windows.Forms.Button btnLed7;
        private System.Windows.Forms.CheckBox chkLed7;
        private System.Windows.Forms.Button btnLed8;
        private System.Windows.Forms.CheckBox chkLed8;
    }
}

