
namespace TrabalhandoArray
{
    partial class Arrays
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
            this.buttonAcao = new System.Windows.Forms.Button();
            this.labelTela = new System.Windows.Forms.Label();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAcao
            // 
            this.buttonAcao.Location = new System.Drawing.Point(209, 200);
            this.buttonAcao.Name = "buttonAcao";
            this.buttonAcao.Size = new System.Drawing.Size(75, 23);
            this.buttonAcao.TabIndex = 0;
            this.buttonAcao.Text = "Ação";
            this.buttonAcao.UseVisualStyleBackColor = true;
            this.buttonAcao.Click += new System.EventHandler(this.buttonAcao_Click);
            // 
            // labelTela
            // 
            this.labelTela.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTela.Location = new System.Drawing.Point(41, 50);
            this.labelTela.Name = "labelTela";
            this.labelTela.Size = new System.Drawing.Size(243, 133);
            this.labelTela.TabIndex = 1;
            this.labelTela.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 15;
            this.listBoxResultado.Location = new System.Drawing.Point(41, 200);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(144, 139);
            this.listBoxResultado.TabIndex = 2;
            // 
            // Arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 356);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.labelTela);
            this.Controls.Add(this.buttonAcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Arrays";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalhando Arrays";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAcao;
        private System.Windows.Forms.Label labelTela;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}

