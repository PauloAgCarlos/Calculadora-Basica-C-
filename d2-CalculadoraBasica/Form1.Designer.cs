namespace d2_CalculadoraBasica
{
    partial class Form1
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
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultip = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(12, 74);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(40, 30);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.operacao_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(58, 74);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(40, 30);
            this.btnSubtrair.TabIndex = 1;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.operacao_Click);
            // 
            // btnMultip
            // 
            this.btnMultip.Location = new System.Drawing.Point(12, 110);
            this.btnMultip.Name = "btnMultip";
            this.btnMultip.Size = new System.Drawing.Size(40, 30);
            this.btnMultip.TabIndex = 2;
            this.btnMultip.Text = "x";
            this.btnMultip.UseVisualStyleBackColor = true;
            this.btnMultip.Click += new System.EventHandler(this.operacao_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(58, 110);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(40, 30);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = ":";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.operacao_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(12, 12);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(86, 20);
            this.text1.TabIndex = 4;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(12, 38);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(86, 20);
            this.text2.TabIndex = 5;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(115, 15);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(83, 125);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 158);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultip);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultip;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label labelResult;
    }
}

