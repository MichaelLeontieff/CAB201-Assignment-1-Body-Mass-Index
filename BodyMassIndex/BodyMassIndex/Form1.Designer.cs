namespace BodyMassIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeightInput = new System.Windows.Forms.TextBox();
            this.txtHeightInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbAnotherCalc = new System.Windows.Forms.GroupBox();
            this.rbCalcNo = new System.Windows.Forms.RadioButton();
            this.rbCalcYes = new System.Windows.Forms.RadioButton();
            this.gbAnotherCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Mass Index Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight (kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height (m)";
            // 
            // txtWeightInput
            // 
            this.txtWeightInput.Location = new System.Drawing.Point(29, 101);
            this.txtWeightInput.Name = "txtWeightInput";
            this.txtWeightInput.Size = new System.Drawing.Size(84, 20);
            this.txtWeightInput.TabIndex = 3;
            // 
            // txtHeightInput
            // 
            this.txtHeightInput.Location = new System.Drawing.Point(172, 101);
            this.txtHeightInput.Name = "txtHeightInput";
            this.txtHeightInput.Size = new System.Drawing.Size(84, 20);
            this.txtHeightInput.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(105, 141);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 58);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbAnotherCalc
            // 
            this.gbAnotherCalc.Controls.Add(this.rbCalcNo);
            this.gbAnotherCalc.Controls.Add(this.rbCalcYes);
            this.gbAnotherCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnotherCalc.Location = new System.Drawing.Point(29, 213);
            this.gbAnotherCalc.Name = "gbAnotherCalc";
            this.gbAnotherCalc.Size = new System.Drawing.Size(227, 80);
            this.gbAnotherCalc.TabIndex = 6;
            this.gbAnotherCalc.TabStop = false;
            this.gbAnotherCalc.Text = "Another Calculation?";
            this.gbAnotherCalc.Visible = false;
            // 
            // rbCalcNo
            // 
            this.rbCalcNo.AutoSize = true;
            this.rbCalcNo.Location = new System.Drawing.Point(143, 38);
            this.rbCalcNo.Name = "rbCalcNo";
            this.rbCalcNo.Size = new System.Drawing.Size(46, 20);
            this.rbCalcNo.TabIndex = 1;
            this.rbCalcNo.Text = "No";
            this.rbCalcNo.UseVisualStyleBackColor = true;
            this.rbCalcNo.CheckedChanged += new System.EventHandler(this.rbCalcNo_CheckedChanged);
            // 
            // rbCalcYes
            // 
            this.rbCalcYes.AutoSize = true;
            this.rbCalcYes.Location = new System.Drawing.Point(19, 38);
            this.rbCalcYes.Name = "rbCalcYes";
            this.rbCalcYes.Size = new System.Drawing.Size(53, 20);
            this.rbCalcYes.TabIndex = 0;
            this.rbCalcYes.Text = "Yes";
            this.rbCalcYes.UseVisualStyleBackColor = true;
            this.rbCalcYes.CheckedChanged += new System.EventHandler(this.rbCalcYes_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 325);
            this.Controls.Add(this.gbAnotherCalc);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHeightInput);
            this.Controls.Add(this.txtWeightInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Body Mass Index";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAnotherCalc.ResumeLayout(false);
            this.gbAnotherCalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeightInput;
        private System.Windows.Forms.TextBox txtHeightInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbAnotherCalc;
        private System.Windows.Forms.RadioButton rbCalcNo;
        private System.Windows.Forms.RadioButton rbCalcYes;
    }
}

