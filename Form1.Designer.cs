namespace GeradorSorteio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGerar = new System.Windows.Forms.Button();
            this.Sorteados = new System.Windows.Forms.ListBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGerar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGerar.Location = new System.Drawing.Point(9, 161);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(75, 23);
            this.BtnGerar.TabIndex = 0;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = false;
            this.BtnGerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sorteados
            // 
            this.Sorteados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Sorteados.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sorteados.FormattingEnabled = true;
            this.Sorteados.ItemHeight = 15;
            this.Sorteados.Location = new System.Drawing.Point(198, 12);
            this.Sorteados.Name = "Sorteados";
            this.Sorteados.Size = new System.Drawing.Size(114, 169);
            this.Sorteados.TabIndex = 1;
            this.Sorteados.SelectedIndexChanged += new System.EventHandler(this.Sorteados_SelectedIndexChanged);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(105, 161);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Resetar";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe os intervalos:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(43, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "De ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(43, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "100";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Até ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(329, 233);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.Sorteados);
            this.Controls.Add(this.BtnGerar);
            this.Name = "Form1";
            this.Text = "Gerador de Sorteio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.ListBox Sorteados;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}
