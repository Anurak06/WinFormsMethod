﻿namespace WinFormsMethod
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            lblResult = new Label();
            btnBMI = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 9);
            label1.Name = "label1";
            label1.Size = new Size(461, 55);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 97);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ นามสกุล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 130);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "อายุ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 167);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "ส่วนสูง (cm)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 197);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "น้ำหนัก (kg)";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(129, 130);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(96, 27);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(129, 164);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(96, 27);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(129, 197);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(96, 27);
            txtWeight.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Linen;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(435, 89);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(353, 288);
            lblResult.TabIndex = 9;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBMI
            // 
            btnBMI.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBMI.Location = new Point(129, 244);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(286, 85);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(129, 335);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(286, 90);
            btnClear.TabIndex = 10;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnBMI);
            Controls.Add(lblResult);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblResult;
        private Button btnBMI;
        private Button btnClear;
    }
}
