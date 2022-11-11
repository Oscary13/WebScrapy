namespace WebScarpy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_Resultados = new System.Windows.Forms.ListBox();
            this.richTextBox_ResultadoHtml = new System.Windows.Forms.RichTextBox();
            this.textBox_Url = new System.Windows.Forms.TextBox();
            this.textBox_regularExpresion = new System.Windows.Forms.TextBox();
            this.label_expresionregularT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CountMatchs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1037, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "VALIDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_Resultados
            // 
            this.listBox_Resultados.FormattingEnabled = true;
            this.listBox_Resultados.Location = new System.Drawing.Point(804, 114);
            this.listBox_Resultados.Name = "listBox_Resultados";
            this.listBox_Resultados.Size = new System.Drawing.Size(345, 485);
            this.listBox_Resultados.TabIndex = 1;
            // 
            // richTextBox_ResultadoHtml
            // 
            this.richTextBox_ResultadoHtml.Location = new System.Drawing.Point(37, 114);
            this.richTextBox_ResultadoHtml.Name = "richTextBox_ResultadoHtml";
            this.richTextBox_ResultadoHtml.Size = new System.Drawing.Size(761, 485);
            this.richTextBox_ResultadoHtml.TabIndex = 2;
            this.richTextBox_ResultadoHtml.Text = "";
            // 
            // textBox_Url
            // 
            this.textBox_Url.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Url.Location = new System.Drawing.Point(271, 72);
            this.textBox_Url.Name = "textBox_Url";
            this.textBox_Url.Size = new System.Drawing.Size(760, 29);
            this.textBox_Url.TabIndex = 3;
            // 
            // textBox_regularExpresion
            // 
            this.textBox_regularExpresion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_regularExpresion.Location = new System.Drawing.Point(271, 28);
            this.textBox_regularExpresion.Name = "textBox_regularExpresion";
            this.textBox_regularExpresion.Size = new System.Drawing.Size(549, 29);
            this.textBox_regularExpresion.TabIndex = 4;
            // 
            // label_expresionregularT
            // 
            this.label_expresionregularT.AutoSize = true;
            this.label_expresionregularT.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_expresionregularT.Location = new System.Drawing.Point(37, 33);
            this.label_expresionregularT.Name = "label_expresionregularT";
            this.label_expresionregularT.Size = new System.Drawing.Size(205, 21);
            this.label_expresionregularT.TabIndex = 5;
            this.label_expresionregularT.Text = "EXPRESION REGULAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "LINK DE LA PAGINA WEB:";
            // 
            // label_CountMatchs
            // 
            this.label_CountMatchs.AutoSize = true;
            this.label_CountMatchs.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CountMatchs.Location = new System.Drawing.Point(840, 28);
            this.label_CountMatchs.Name = "label_CountMatchs";
            this.label_CountMatchs.Size = new System.Drawing.Size(0, 21);
            this.label_CountMatchs.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 622);
            this.Controls.Add(this.label_CountMatchs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_expresionregularT);
            this.Controls.Add(this.textBox_regularExpresion);
            this.Controls.Add(this.textBox_Url);
            this.Controls.Add(this.richTextBox_ResultadoHtml);
            this.Controls.Add(this.listBox_Resultados);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_Resultados;
        private System.Windows.Forms.RichTextBox richTextBox_ResultadoHtml;
        private System.Windows.Forms.TextBox textBox_Url;
        private System.Windows.Forms.TextBox textBox_regularExpresion;
        private System.Windows.Forms.Label label_expresionregularT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_CountMatchs;
    }
}

