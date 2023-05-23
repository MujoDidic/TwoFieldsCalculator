
namespace TwoFieldsCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Calculate = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.totalName = new System.Windows.Forms.Label();
            this.totalVisible = new System.Windows.Forms.Label();
            this.numOneBox = new System.Windows.Forms.TextBox();
            this.numTwoBox = new System.Windows.Forms.TextBox();
            this.mathOp = new System.Windows.Forms.GroupBox();
            this.rBtnAddition = new System.Windows.Forms.RadioButton();
            this.rBtnSubtraction = new System.Windows.Forms.RadioButton();
            this.rBtnMultiply = new System.Windows.Forms.RadioButton();
            this.rBtnDivide = new System.Windows.Forms.RadioButton();
            this.mathOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Location = new System.Drawing.Point(12, 122);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(122, 27);
            this.Btn_Calculate.TabIndex = 0;
            this.Btn_Calculate.Text = "Calculate";
            this.Btn_Calculate.UseVisualStyleBackColor = true;
            this.Btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(250, 122);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(122, 27);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // totalName
            // 
            this.totalName.AutoSize = true;
            this.totalName.Location = new System.Drawing.Point(12, 106);
            this.totalName.Name = "totalName";
            this.totalName.Size = new System.Drawing.Size(40, 13);
            this.totalName.TabIndex = 2;
            this.totalName.Text = "Total : ";
            // 
            // totalVisible
            // 
            this.totalVisible.AutoSize = true;
            this.totalVisible.Location = new System.Drawing.Point(48, 106);
            this.totalVisible.Name = "totalVisible";
            this.totalVisible.Size = new System.Drawing.Size(13, 13);
            this.totalVisible.TabIndex = 3;
            this.totalVisible.Text = "0";
            // 
            // numOneBox
            // 
            this.numOneBox.Location = new System.Drawing.Point(12, 12);
            this.numOneBox.Name = "numOneBox";
            this.numOneBox.Size = new System.Drawing.Size(180, 20);
            this.numOneBox.TabIndex = 4;
            this.numOneBox.Text = "0";
            this.numOneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numTwoBox
            // 
            this.numTwoBox.Location = new System.Drawing.Point(12, 44);
            this.numTwoBox.Name = "numTwoBox";
            this.numTwoBox.Size = new System.Drawing.Size(182, 20);
            this.numTwoBox.TabIndex = 5;
            this.numTwoBox.Text = "0";
            this.numTwoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mathOp
            // 
            this.mathOp.Controls.Add(this.rBtnDivide);
            this.mathOp.Controls.Add(this.rBtnMultiply);
            this.mathOp.Controls.Add(this.rBtnSubtraction);
            this.mathOp.Controls.Add(this.rBtnAddition);
            this.mathOp.Location = new System.Drawing.Point(250, 12);
            this.mathOp.Name = "mathOp";
            this.mathOp.Size = new System.Drawing.Size(122, 104);
            this.mathOp.TabIndex = 6;
            this.mathOp.TabStop = false;
            this.mathOp.Text = "Operations";
            // 
            // rBtnAddition
            // 
            this.rBtnAddition.AutoSize = true;
            this.rBtnAddition.Location = new System.Drawing.Point(6, 12);
            this.rBtnAddition.Name = "rBtnAddition";
            this.rBtnAddition.Size = new System.Drawing.Size(63, 17);
            this.rBtnAddition.TabIndex = 0;
            this.rBtnAddition.TabStop = true;
            this.rBtnAddition.Text = "Addition";
            this.rBtnAddition.UseVisualStyleBackColor = true;
            // 
            // rBtnSubtraction
            // 
            this.rBtnSubtraction.AutoSize = true;
            this.rBtnSubtraction.Location = new System.Drawing.Point(6, 35);
            this.rBtnSubtraction.Name = "rBtnSubtraction";
            this.rBtnSubtraction.Size = new System.Drawing.Size(79, 17);
            this.rBtnSubtraction.TabIndex = 1;
            this.rBtnSubtraction.TabStop = true;
            this.rBtnSubtraction.Text = "Subtraction";
            this.rBtnSubtraction.UseVisualStyleBackColor = true;
            // 
            // rBtnMultiply
            // 
            this.rBtnMultiply.AutoSize = true;
            this.rBtnMultiply.Location = new System.Drawing.Point(6, 58);
            this.rBtnMultiply.Name = "rBtnMultiply";
            this.rBtnMultiply.Size = new System.Drawing.Size(60, 17);
            this.rBtnMultiply.TabIndex = 2;
            this.rBtnMultiply.TabStop = true;
            this.rBtnMultiply.Text = "Multiply";
            this.rBtnMultiply.UseVisualStyleBackColor = true;
            // 
            // rBtnDivide
            // 
            this.rBtnDivide.AutoSize = true;
            this.rBtnDivide.Location = new System.Drawing.Point(6, 81);
            this.rBtnDivide.Name = "rBtnDivide";
            this.rBtnDivide.Size = new System.Drawing.Size(55, 17);
            this.rBtnDivide.TabIndex = 3;
            this.rBtnDivide.TabStop = true;
            this.rBtnDivide.Text = "Divide";
            this.rBtnDivide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.mathOp);
            this.Controls.Add(this.numTwoBox);
            this.Controls.Add(this.numOneBox);
            this.Controls.Add(this.totalVisible);
            this.Controls.Add(this.totalName);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Calculate);
            this.Name = "Form1";
            this.Text = "Two Field Calculator";
            this.mathOp.ResumeLayout(false);
            this.mathOp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Calculate;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label totalName;
        private System.Windows.Forms.Label totalVisible;
        private System.Windows.Forms.TextBox numOneBox;
        private System.Windows.Forms.TextBox numTwoBox;
        private System.Windows.Forms.GroupBox mathOp;
        private System.Windows.Forms.RadioButton rBtnDivide;
        private System.Windows.Forms.RadioButton rBtnMultiply;
        private System.Windows.Forms.RadioButton rBtnSubtraction;
        private System.Windows.Forms.RadioButton rBtnAddition;
    }
}

