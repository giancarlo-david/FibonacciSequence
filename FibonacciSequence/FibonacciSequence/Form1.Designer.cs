namespace FibonacciSequence
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
            this.buttonNextNumber = new System.Windows.Forms.Button();
            this.textBoxCurrentNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumInSequence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonNextNumber
            // 
            this.buttonNextNumber.Font = new System.Drawing.Font("SimSun-ExtB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextNumber.Location = new System.Drawing.Point(314, 200);
            this.buttonNextNumber.Name = "buttonNextNumber";
            this.buttonNextNumber.Size = new System.Drawing.Size(175, 105);
            this.buttonNextNumber.TabIndex = 0;
            this.buttonNextNumber.Text = "Next Number";
            this.buttonNextNumber.UseVisualStyleBackColor = true;
            this.buttonNextNumber.Click += new System.EventHandler(this.buttonNextNumber_Click);
            // 
            // textBoxCurrentNumber
            // 
            this.textBoxCurrentNumber.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentNumber.Location = new System.Drawing.Point(201, 133);
            this.textBoxCurrentNumber.Name = "textBoxCurrentNumber";
            this.textBoxCurrentNumber.Size = new System.Drawing.Size(408, 41);
            this.textBoxCurrentNumber.TabIndex = 1;
            this.textBoxCurrentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fibonacci Sequence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number In Sequence";
            // 
            // textBoxNumInSequence
            // 
            this.textBoxNumInSequence.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F);
            this.textBoxNumInSequence.Location = new System.Drawing.Point(314, 384);
            this.textBoxNumInSequence.Name = "textBoxNumInSequence";
            this.textBoxNumInSequence.ReadOnly = true;
            this.textBoxNumInSequence.Size = new System.Drawing.Size(175, 41);
            this.textBoxNumInSequence.TabIndex = 4;
            this.textBoxNumInSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNumInSequence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCurrentNumber);
            this.Controls.Add(this.buttonNextNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextNumber;
        private System.Windows.Forms.TextBox textBoxCurrentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumInSequence;
    }
}

