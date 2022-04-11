namespace Calculator
{
    partial class FormCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonCloseBracket = new System.Windows.Forms.Button();
            this.buttonOpenBracket = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonUnar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMpluss = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxExpression.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExpression.Location = new System.Drawing.Point(86, 26);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(159, 21);
            this.textBoxExpression.TabIndex = 2;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult.Location = new System.Drawing.Point(86, 72);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(159, 23);
            this.textBoxResult.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonC);
            this.groupBox1.Controls.Add(this.buttonBackspace);
            this.groupBox1.Controls.Add(this.buttonCloseBracket);
            this.groupBox1.Controls.Add(this.buttonOpenBracket);
            this.groupBox1.Location = new System.Drawing.Point(15, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.ForeColor = System.Drawing.Color.Red;
            this.buttonC.Location = new System.Drawing.Point(93, 16);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(110, 36);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.ForeColor = System.Drawing.Color.Red;
            this.buttonBackspace.Location = new System.Drawing.Point(93, 58);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(110, 40);
            this.buttonBackspace.TabIndex = 2;
            this.buttonBackspace.Text = "Backspace";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            
            // 
            // buttonCloseBracket
            // 
            this.buttonCloseBracket.Location = new System.Drawing.Point(6, 58);
            this.buttonCloseBracket.Name = "buttonCloseBracket";
            this.buttonCloseBracket.Size = new System.Drawing.Size(34, 28);
            this.buttonCloseBracket.TabIndex = 1;
            this.buttonCloseBracket.Text = ")";
            this.buttonCloseBracket.UseVisualStyleBackColor = true;
            
            // 
            // buttonOpenBracket
            // 
            this.buttonOpenBracket.Location = new System.Drawing.Point(6, 24);
            this.buttonOpenBracket.Name = "buttonOpenBracket";
            this.buttonOpenBracket.Size = new System.Drawing.Size(36, 28);
            this.buttonOpenBracket.TabIndex = 0;
            this.buttonOpenBracket.Text = "(";
            this.buttonOpenBracket.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
     
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
 
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiv.ForeColor = System.Drawing.Color.Red;
            this.buttonDiv.Location = new System.Drawing.Point(153, 239);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(39, 39);
            this.buttonDiv.TabIndex = 7;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
         
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMult.ForeColor = System.Drawing.Color.Red;
            this.buttonMult.Location = new System.Drawing.Point(153, 284);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(39, 39);
            this.buttonMult.TabIndex = 8;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
          
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.ForeColor = System.Drawing.Color.Red;
            this.buttonMin.Location = new System.Drawing.Point(153, 329);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(39, 39);
            this.buttonMin.TabIndex = 9;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = true;
            
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.ForeColor = System.Drawing.Color.Red;
            this.buttonPlus.Location = new System.Drawing.Point(153, 374);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(39, 39);
            this.buttonPlus.TabIndex = 10;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 39);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(108, 329);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 39);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMod.ForeColor = System.Drawing.Color.Red;
            this.buttonMod.Location = new System.Drawing.Point(108, 374);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(39, 39);
            this.buttonMod.TabIndex = 13;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(63, 374);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(39, 39);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(63, 329);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 39);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
                        // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 284);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 39);
            this.button5.TabIndex = 16;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 329);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 39);
            this.button7.TabIndex = 18;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonUnar
            // 
            this.buttonUnar.Location = new System.Drawing.Point(15, 374);
            this.buttonUnar.Name = "buttonUnar";
            this.buttonUnar.Size = new System.Drawing.Size(39, 39);
            this.buttonUnar.TabIndex = 19;
            this.buttonUnar.Text = "+/-";
            this.buttonUnar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonMR
            // 
            this.buttonMR.ForeColor = System.Drawing.Color.Blue;
            this.buttonMR.Location = new System.Drawing.Point(206, 239);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(39, 39);
            this.buttonMR.TabIndex = 21;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            // 
            // buttonMpluss
            // 
            this.buttonMpluss.ForeColor = System.Drawing.Color.Blue;
            this.buttonMpluss.Location = new System.Drawing.Point(206, 284);
            this.buttonMpluss.Name = "buttonMpluss";
            this.buttonMpluss.Size = new System.Drawing.Size(39, 39);
            this.buttonMpluss.TabIndex = 22;
            this.buttonMpluss.Text = "M+";
            this.buttonMpluss.UseVisualStyleBackColor = true;
            // 
            // buttonMC
            // 
            this.buttonMC.ForeColor = System.Drawing.Color.Blue;
            this.buttonMC.Location = new System.Drawing.Point(206, 329);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(39, 39);
            this.buttonMC.TabIndex = 23;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.ForeColor = System.Drawing.Color.Red;
            this.buttonCalc.Location = new System.Drawing.Point(206, 374);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(39, 39);
            this.buttonCalc.TabIndex = 24;
            this.buttonCalc.Text = "=";
            this.buttonCalc.UseVisualStyleBackColor = true;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(292, 420);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMpluss);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonUnar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonCloseBracket;
        private System.Windows.Forms.Button buttonOpenBracket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonUnar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMpluss;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonCalc;
    }
}
