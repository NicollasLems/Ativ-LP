namespace WindowsFormsApp1
{
    partial class frmfatoral
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
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(95, 283);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(75, 23);
            this.btnwhile.TabIndex = 0;
            this.btnwhile.Text = "While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndo
            // 
            this.btndo.Location = new System.Drawing.Point(215, 283);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(75, 23);
            this.btndo.TabIndex = 1;
            this.btndo.Text = "Do";
            this.btndo.UseVisualStyleBackColor = true;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(337, 283);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(75, 23);
            this.btnfor.TabIndex = 2;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(161, 312);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(282, 312);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(25, 72);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(92, 13);
            this.lblnum.TabIndex = 5;
            this.lblnum.Text = "Digite um número:";
            this.lblnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(123, 65);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(142, 20);
            this.txtnum.TabIndex = 6;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(25, 116);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(58, 13);
            this.lblresult.TabIndex = 7;
            this.lblresult.Text = "Resultado:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(123, 113);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(142, 79);
            this.txtresult.TabIndex = 8;
            this.txtresult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmfatoral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnwhile);
            this.Name = "frmfatoral";
            this.Text = "Fatoral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresult;
    }
}

