namespace test
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
            no1 = new TextBox();
            no2 = new TextBox();
            button1 = new Button();
            result = new Label();
            add = new RadioButton();
            sub = new RadioButton();
            mult = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 114);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 169);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // no1
            // 
            no1.Location = new Point(273, 106);
            no1.Name = "no1";
            no1.Size = new Size(100, 23);
            no1.TabIndex = 2;
            // 
            // no2
            // 
            no2.Location = new Point(273, 161);
            no2.Name = "no2";
            no2.Size = new Size(100, 23);
            no2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(267, 223);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 4;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.BackColor = SystemColors.ControlDark;
            result.Location = new Point(435, 106);
            result.MinimumSize = new Size(75, 75);
            result.Name = "result";
            result.Size = new Size(75, 75);
            result.TabIndex = 5;
            result.Visible = false;
            // 
            // add
            // 
            add.AutoSize = true;
            add.Location = new Point(58, 115);
            add.Name = "add";
            add.Size = new Size(47, 19);
            add.TabIndex = 6;
            add.TabStop = true;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            sub.AutoSize = true;
            sub.Location = new Point(58, 140);
            sub.Name = "sub";
            sub.Size = new Size(69, 19);
            sub.TabIndex = 7;
            sub.TabStop = true;
            sub.Text = "Subtract";
            sub.UseVisualStyleBackColor = true;
            // 
            // mult
            // 
            mult.AutoSize = true;
            mult.Location = new Point(58, 165);
            mult.Name = "mult";
            mult.Size = new Size(69, 19);
            mult.TabIndex = 8;
            mult.TabStop = true;
            mult.Text = "Multiply";
            mult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 394);
            Controls.Add(mult);
            Controls.Add(sub);
            Controls.Add(add);
            Controls.Add(result);
            Controls.Add(button1);
            Controls.Add(no2);
            Controls.Add(no1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox no1;
        private TextBox no2;
        private Button button1;
        private Label result;
        private RadioButton add;
        private RadioButton sub;
        private RadioButton mult;
    }
}
