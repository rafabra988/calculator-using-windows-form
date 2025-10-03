namespace CalculadoraBase
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
            display = new TextBox();
            b1 = new Button();
            bsoma = new Button();
            bigual = new Button();
            bvirgula = new Button();
            bclear = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            b0 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            creditosToolStripMenuItem = new ToolStripMenuItem();
            Sair = new ToolStripMenuItem();
            button8 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.BackColor = SystemColors.Control;
            display.BorderStyle = BorderStyle.None;
            display.Enabled = false;
            display.Font = new Font("Segoe UI", 40F);
            display.ForeColor = SystemColors.WindowText;
            display.Location = new Point(7, 42);
            display.Margin = new Padding(3, 2, 3, 2);
            display.MaxLength = 20;
            display.Multiline = true;
            display.Name = "display";
            display.PlaceholderText = "0 ";
            display.ReadOnly = true;
            display.Size = new Size(244, 110);
            display.TabIndex = 0;
            display.TextAlign = HorizontalAlignment.Right;
            display.TextChanged += display_TextChanged;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b1.Location = new Point(7, 352);
            b1.Margin = new Padding(3, 2, 3, 2);
            b1.Name = "b1";
            b1.Size = new Size(57, 37);
            b1.TabIndex = 1;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // bsoma
            // 
            bsoma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsoma.Location = new Point(194, 351);
            bsoma.Margin = new Padding(3, 2, 3, 2);
            bsoma.Name = "bsoma";
            bsoma.Size = new Size(57, 37);
            bsoma.TabIndex = 2;
            bsoma.Text = "+";
            bsoma.TextAlign = ContentAlignment.BottomCenter;
            bsoma.UseVisualStyleBackColor = true;
            bsoma.Click += bsoma_Click;
            // 
            // bigual
            // 
            bigual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bigual.Location = new Point(194, 397);
            bigual.Margin = new Padding(3, 2, 3, 2);
            bigual.Name = "bigual";
            bigual.Size = new Size(57, 37);
            bigual.TabIndex = 3;
            bigual.Text = "=";
            bigual.TextAlign = ContentAlignment.BottomCenter;
            bigual.UseVisualStyleBackColor = true;
            bigual.Click += bigual_Click;
            // 
            // bvirgula
            // 
            bvirgula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bvirgula.Location = new Point(133, 397);
            bvirgula.Margin = new Padding(3, 2, 3, 2);
            bvirgula.Name = "bvirgula";
            bvirgula.Size = new Size(57, 37);
            bvirgula.TabIndex = 4;
            bvirgula.Text = ",";
            bvirgula.TextAlign = ContentAlignment.BottomCenter;
            bvirgula.UseVisualStyleBackColor = true;
            bvirgula.Click += bvirgula_Click;
            // 
            // bclear
            // 
            bclear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bclear.Location = new Point(7, 144);
            bclear.Margin = new Padding(3, 2, 3, 2);
            bclear.Name = "bclear";
            bclear.Size = new Size(244, 27);
            bclear.TabIndex = 5;
            bclear.Text = "C";
            bclear.TextAlign = ContentAlignment.BottomCenter;
            bclear.UseVisualStyleBackColor = true;
            bclear.Click += bclear_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b2.Location = new Point(70, 351);
            b2.Name = "b2";
            b2.Size = new Size(57, 37);
            b2.TabIndex = 6;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += button1_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b3.Location = new Point(133, 351);
            b3.Name = "b3";
            b3.Size = new Size(57, 37);
            b3.TabIndex = 7;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b4.Location = new Point(7, 305);
            b4.Name = "b4";
            b4.Size = new Size(57, 37);
            b4.TabIndex = 8;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b5.Location = new Point(70, 303);
            b5.Name = "b5";
            b5.Size = new Size(57, 37);
            b5.TabIndex = 9;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b6.Location = new Point(133, 303);
            b6.Name = "b6";
            b6.Size = new Size(57, 37);
            b6.TabIndex = 10;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b7.Location = new Point(7, 259);
            b7.Name = "b7";
            b7.Size = new Size(57, 37);
            b7.TabIndex = 11;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b8.Location = new Point(70, 258);
            b8.Name = "b8";
            b8.Size = new Size(57, 37);
            b8.TabIndex = 12;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b9.Location = new Point(133, 259);
            b9.Name = "b9";
            b9.Size = new Size(57, 37);
            b9.TabIndex = 13;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b0
            // 
            b0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b0.Location = new Point(70, 397);
            b0.Name = "b0";
            b0.Size = new Size(57, 37);
            b0.TabIndex = 14;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button10.Location = new Point(194, 305);
            button10.Name = "button10";
            button10.Size = new Size(57, 37);
            button10.TabIndex = 15;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button11.Location = new Point(194, 260);
            button11.Name = "button11";
            button11.Size = new Size(57, 37);
            button11.TabIndex = 16;
            button11.Text = "÷";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button12.Location = new Point(194, 216);
            button12.Name = "button12";
            button12.Size = new Size(57, 37);
            button12.TabIndex = 17;
            button12.Text = "×";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.8301888F, FontStyle.Bold);
            button1.Location = new Point(70, 216);
            button1.Name = "button1";
            button1.Size = new Size(57, 37);
            button1.TabIndex = 18;
            button1.Text = "√";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8301888F, FontStyle.Bold);
            button2.Location = new Point(7, 216);
            button2.Name = "button2";
            button2.Size = new Size(57, 37);
            button2.TabIndex = 19;
            button2.Text = "x²";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 15.8301888F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(70, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 31);
            textBox1.TabIndex = 20;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            button3.Location = new Point(70, 176);
            button3.Name = "button3";
            button3.Size = new Size(57, 37);
            button3.TabIndex = 21;
            button3.Text = "Log";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            button4.Location = new Point(7, 176);
            button4.Name = "button4";
            button4.Size = new Size(57, 37);
            button4.TabIndex = 22;
            button4.Text = "Mod";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            button5.Location = new Point(133, 176);
            button5.Name = "button5";
            button5.Size = new Size(57, 37);
            button5.TabIndex = 23;
            button5.Text = "Sin";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9.830189F, FontStyle.Bold);
            button6.Location = new Point(133, 216);
            button6.Name = "button6";
            button6.Size = new Size(57, 37);
            button6.TabIndex = 24;
            button6.Text = "|x|";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 7.830189F, FontStyle.Bold);
            button7.Location = new Point(194, 176);
            button7.Name = "button7";
            button7.Size = new Size(57, 37);
            button7.TabIndex = 25;
            button7.Text = "Apagar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(257, 25);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { creditosToolStripMenuItem, Sair });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(53, 21);
            toolStripMenuItem1.Text = "Menu";
            // 
            // creditosToolStripMenuItem
            // 
            creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            creditosToolStripMenuItem.Size = new Size(131, 24);
            creditosToolStripMenuItem.Text = "Creditos";
            creditosToolStripMenuItem.Click += creditosToolStripMenuItem_Click;
            // 
            // Sair
            // 
            Sair.Name = "Sair";
            Sair.Size = new Size(131, 24);
            Sair.Text = "Sair";
            Sair.Click += toolStripMenuItem2_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold);
            button8.Location = new Point(7, 396);
            button8.Name = "button8";
            button8.Size = new Size(57, 37);
            button8.TabIndex = 27;
            button8.Text = "±";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 445);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(b0);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(bclear);
            Controls.Add(bvirgula);
            Controls.Add(bigual);
            Controls.Add(bsoma);
            Controls.Add(b1);
            Controls.Add(display);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calculadora Base";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
		private Button b1;
		private Button bsoma;
		private Button bigual;
		private Button bvirgula;
		private Button bclear;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button b0;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem creditosToolStripMenuItem;
        private ToolStripMenuItem Sair;
        private Button button8;
    }
}
