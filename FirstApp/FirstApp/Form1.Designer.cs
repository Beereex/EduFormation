namespace FirstApp
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
            digit_0 = new Button();
            Screen = new TextBox();
            digit_1 = new Button();
            digit_2 = new Button();
            digit_3 = new Button();
            digit_4 = new Button();
            digit_5 = new Button();
            digit_6 = new Button();
            digit_7 = new Button();
            digit_8 = new Button();
            digit_9 = new Button();
            digit_comma = new Button();
            op_add = new Button();
            op_sub = new Button();
            op_div = new Button();
            op_mult = new Button();
            op_c = new Button();
            op_delete = new Button();
            op_equals = new Button();
            SuspendLayout();
            // 
            // digit_0
            // 
            digit_0.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_0.Location = new Point(12, 298);
            digit_0.Name = "digit_0";
            digit_0.Size = new Size(118, 54);
            digit_0.TabIndex = 0;
            digit_0.Text = "0";
            digit_0.UseVisualStyleBackColor = true;
            digit_0.Click += digit_0_Click;
            // 
            // Screen
            // 
            Screen.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Screen.Location = new Point(12, 12);
            Screen.MaxLength = 15;
            Screen.Name = "Screen";
            Screen.ReadOnly = true;
            Screen.Size = new Size(242, 39);
            Screen.TabIndex = 1;
            Screen.Text = "0";
            Screen.TextAlign = HorizontalAlignment.Right;
            // 
            // digit_1
            // 
            digit_1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_1.Location = new Point(12, 238);
            digit_1.Name = "digit_1";
            digit_1.Size = new Size(56, 54);
            digit_1.TabIndex = 0;
            digit_1.Text = "1";
            digit_1.UseVisualStyleBackColor = true;
            digit_1.Click += digit_1_Click;
            // 
            // digit_2
            // 
            digit_2.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_2.Location = new Point(74, 238);
            digit_2.Name = "digit_2";
            digit_2.Size = new Size(56, 54);
            digit_2.TabIndex = 0;
            digit_2.Text = "2";
            digit_2.UseVisualStyleBackColor = true;
            digit_2.Click += digit_2_Click;
            // 
            // digit_3
            // 
            digit_3.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_3.Location = new Point(136, 238);
            digit_3.Name = "digit_3";
            digit_3.Size = new Size(56, 54);
            digit_3.TabIndex = 0;
            digit_3.Text = "3";
            digit_3.UseVisualStyleBackColor = true;
            digit_3.Click += digit_3_Click;
            // 
            // digit_4
            // 
            digit_4.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_4.Location = new Point(12, 178);
            digit_4.Name = "digit_4";
            digit_4.Size = new Size(56, 54);
            digit_4.TabIndex = 0;
            digit_4.Text = "4";
            digit_4.UseVisualStyleBackColor = true;
            digit_4.Click += digit_4_Click;
            // 
            // digit_5
            // 
            digit_5.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_5.Location = new Point(74, 178);
            digit_5.Name = "digit_5";
            digit_5.Size = new Size(56, 54);
            digit_5.TabIndex = 0;
            digit_5.Text = "5";
            digit_5.UseVisualStyleBackColor = true;
            digit_5.Click += digit_5_Click;
            // 
            // digit_6
            // 
            digit_6.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_6.Location = new Point(136, 178);
            digit_6.Name = "digit_6";
            digit_6.Size = new Size(56, 54);
            digit_6.TabIndex = 0;
            digit_6.Text = "6";
            digit_6.UseVisualStyleBackColor = true;
            digit_6.Click += digit_6_Click;
            // 
            // digit_7
            // 
            digit_7.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_7.Location = new Point(12, 118);
            digit_7.Name = "digit_7";
            digit_7.Size = new Size(56, 54);
            digit_7.TabIndex = 0;
            digit_7.Text = "7";
            digit_7.UseVisualStyleBackColor = true;
            digit_7.Click += digit_7_Click;
            // 
            // digit_8
            // 
            digit_8.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_8.Location = new Point(74, 118);
            digit_8.Name = "digit_8";
            digit_8.Size = new Size(56, 54);
            digit_8.TabIndex = 0;
            digit_8.Text = "8";
            digit_8.UseVisualStyleBackColor = true;
            digit_8.Click += digit_8_Click;
            // 
            // digit_9
            // 
            digit_9.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_9.Location = new Point(136, 118);
            digit_9.Name = "digit_9";
            digit_9.Size = new Size(56, 54);
            digit_9.TabIndex = 0;
            digit_9.Text = "9";
            digit_9.UseVisualStyleBackColor = true;
            digit_9.Click += digit_9_Click;
            // 
            // digit_comma
            // 
            digit_comma.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            digit_comma.Location = new Point(136, 298);
            digit_comma.Name = "digit_comma";
            digit_comma.Size = new Size(56, 54);
            digit_comma.TabIndex = 0;
            digit_comma.Text = ",";
            digit_comma.UseVisualStyleBackColor = true;
            digit_comma.Click += digit_comma_Click;
            // 
            // op_add
            // 
            op_add.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            op_add.Location = new Point(198, 58);
            op_add.Name = "op_add";
            op_add.Size = new Size(56, 54);
            op_add.TabIndex = 0;
            op_add.Text = "+";
            op_add.UseVisualStyleBackColor = true;
            // 
            // op_sub
            // 
            op_sub.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            op_sub.Location = new Point(198, 118);
            op_sub.Name = "op_sub";
            op_sub.Size = new Size(56, 54);
            op_sub.TabIndex = 0;
            op_sub.Text = "-";
            op_sub.UseVisualStyleBackColor = true;
            // 
            // op_div
            // 
            op_div.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            op_div.Location = new Point(198, 178);
            op_div.Name = "op_div";
            op_div.Size = new Size(56, 54);
            op_div.TabIndex = 0;
            op_div.Text = "/";
            op_div.UseVisualStyleBackColor = true;
            // 
            // op_mult
            // 
            op_mult.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            op_mult.Location = new Point(136, 58);
            op_mult.Name = "op_mult";
            op_mult.Size = new Size(56, 54);
            op_mult.TabIndex = 0;
            op_mult.Text = "x";
            op_mult.UseVisualStyleBackColor = true;
            // 
            // op_c
            // 
            op_c.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            op_c.Location = new Point(12, 57);
            op_c.Name = "op_c";
            op_c.Size = new Size(56, 54);
            op_c.TabIndex = 0;
            op_c.Text = "C";
            op_c.UseVisualStyleBackColor = true;
            op_c.Click += op_c_Click;
            // 
            // op_delete
            // 
            op_delete.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            op_delete.Location = new Point(74, 57);
            op_delete.Name = "op_delete";
            op_delete.Size = new Size(56, 54);
            op_delete.TabIndex = 0;
            op_delete.Text = "←";
            op_delete.UseVisualStyleBackColor = true;
            op_delete.Click += op_delete_Click;
            // 
            // op_equals
            // 
            op_equals.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            op_equals.Location = new Point(198, 238);
            op_equals.Name = "op_equals";
            op_equals.Size = new Size(56, 114);
            op_equals.TabIndex = 0;
            op_equals.Text = "=";
            op_equals.UseVisualStyleBackColor = true;
            op_equals.Click += digit_0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 364);
            Controls.Add(Screen);
            Controls.Add(op_mult);
            Controls.Add(op_div);
            Controls.Add(op_sub);
            Controls.Add(op_add);
            Controls.Add(digit_9);
            Controls.Add(digit_8);
            Controls.Add(op_delete);
            Controls.Add(op_c);
            Controls.Add(digit_7);
            Controls.Add(digit_6);
            Controls.Add(digit_5);
            Controls.Add(digit_4);
            Controls.Add(digit_comma);
            Controls.Add(digit_3);
            Controls.Add(digit_2);
            Controls.Add(digit_1);
            Controls.Add(op_equals);
            Controls.Add(digit_0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button digit_0;
        private TextBox Screen;
        private Button digit_1;
        private Button digit_2;
        private Button digit_3;
        private Button digit_4;
        private Button digit_5;
        private Button digit_6;
        private Button digit_7;
        private Button digit_8;
        private Button digit_9;
        private Button digit_comma;
        private Button op_add;
        private Button op_sub;
        private Button op_div;
        private Button op_mult;
        private Button op_c;
        private Button op_delete;
        private Button op_equals;
    }
}