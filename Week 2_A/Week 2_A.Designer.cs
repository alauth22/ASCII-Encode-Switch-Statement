
namespace Week_2_A
{
    partial class frmDecimal_ASCII_Calc
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblTypeNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblActualAnswer = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(468, 48);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(132, 31);
            this.txtNumber.TabIndex = 0;
            // 
            // lblTypeNumber
            // 
            this.lblTypeNumber.Location = new System.Drawing.Point(28, 41);
            this.lblTypeNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTypeNumber.Name = "lblTypeNumber";
            this.lblTypeNumber.Size = new System.Drawing.Size(428, 44);
            this.lblTypeNumber.TabIndex = 1;
            this.lblTypeNumber.Text = "Please type a number you want to convert:";
            this.lblTypeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(348, 85);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(118, 56);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer:";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActualAnswer
            // 
            this.lblActualAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActualAnswer.Location = new System.Drawing.Point(468, 99);
            this.lblActualAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblActualAnswer.Name = "lblActualAnswer";
            this.lblActualAnswer.Size = new System.Drawing.Size(134, 42);
            this.lblActualAnswer.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(104, 179);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(150, 71);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(316, 179);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 71);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(526, 179);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 71);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDecimal_ASCII_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 298);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblActualAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblTypeNumber);
            this.Controls.Add(this.txtNumber);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmDecimal_ASCII_Calc";
            this.Text = "Decimal_ASCII Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblTypeNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblActualAnswer;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}

