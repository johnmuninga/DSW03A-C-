namespace Question1
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
            this.txtRes = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(12, 35);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(399, 20);
            this.txtRes.TabIndex = 0;
            this.txtRes.Text = "0";
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 61);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 58);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.NumEvent);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(93, 61);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 58);
            this.b8.TabIndex = 2;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.NumEvent);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(174, 61);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 58);
            this.b9.TabIndex = 3;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.NumEvent);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(255, 61);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(75, 58);
            this.bDiv.TabIndex = 4;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(336, 61);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(75, 58);
            this.bCE.TabIndex = 5;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 125);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 58);
            this.b4.TabIndex = 6;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.NumEvent);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(93, 125);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 58);
            this.b5.TabIndex = 7;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.NumEvent);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(174, 125);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 58);
            this.b6.TabIndex = 8;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.NumEvent);
            // 
            // bMul
            // 
            this.bMul.Location = new System.Drawing.Point(255, 125);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(75, 58);
            this.bMul.TabIndex = 9;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(336, 125);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(75, 58);
            this.bC.TabIndex = 10;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 189);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 58);
            this.b1.TabIndex = 11;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.NumEvent);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(93, 189);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 58);
            this.b2.TabIndex = 12;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.NumEvent);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(174, 189);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 58);
            this.b3.TabIndex = 13;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.NumEvent);
            // 
            // bSub
            // 
            this.bSub.Location = new System.Drawing.Point(255, 189);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(75, 58);
            this.bSub.TabIndex = 14;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.OperandEvent);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(174, 253);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 58);
            this.button15.TabIndex = 15;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(255, 253);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 58);
            this.bAdd.TabIndex = 16;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bEq
            // 
            this.bEq.Location = new System.Drawing.Point(336, 189);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(75, 122);
            this.bEq.TabIndex = 17;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = true;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 253);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(156, 58);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.NumEvent);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 19);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bEq);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.txtRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Label lbResult;
    }
}

