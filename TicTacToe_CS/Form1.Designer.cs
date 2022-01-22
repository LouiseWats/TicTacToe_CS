namespace TicTacToe_CS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.playerO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TicTacBtn9 = new System.Windows.Forms.Button();
            this.TicTacBtn6 = new System.Windows.Forms.Button();
            this.TicTacBtn3 = new System.Windows.Forms.Button();
            this.TicTacBtn8 = new System.Windows.Forms.Button();
            this.TicTacBtn7 = new System.Windows.Forms.Button();
            this.TicTacBtn5 = new System.Windows.Forms.Button();
            this.TicTacBtn4 = new System.Windows.Forms.Button();
            this.TicTacBtn2 = new System.Windows.Forms.Button();
            this.TicTacBtn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 137);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tic Tac Toe in C#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.playerO);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.playerX);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(797, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(542, 127);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = "Games won:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerO
            // 
            this.playerO.AutoSize = true;
            this.playerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerO.Location = new System.Drawing.Point(475, 88);
            this.playerO.Name = "playerO";
            this.playerO.Size = new System.Drawing.Size(36, 39);
            this.playerO.TabIndex = 1;
            this.playerO.Text = "0";
            this.playerO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playerO.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(321, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player O";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerX
            // 
            this.playerX.AutoSize = true;
            this.playerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerX.Location = new System.Drawing.Point(166, 88);
            this.playerX.Name = "playerX";
            this.playerX.Size = new System.Drawing.Size(36, 39);
            this.playerX.TabIndex = 1;
            this.playerX.Text = "0";
            this.playerX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playerX.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player X";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 582);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.Exit);
            this.panel4.Controls.Add(this.Reset);
            this.panel4.Controls.Add(this.NewGame);
            this.panel4.Location = new System.Drawing.Point(797, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(542, 572);
            this.panel4.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Exit.Location = new System.Drawing.Point(19, 353);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(499, 101);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Reset.Location = new System.Drawing.Point(19, 232);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(499, 101);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NewGame.Location = new System.Drawing.Point(19, 112);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(499, 101);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TicTacBtn9);
            this.panel3.Controls.Add(this.TicTacBtn6);
            this.panel3.Controls.Add(this.TicTacBtn3);
            this.panel3.Controls.Add(this.TicTacBtn8);
            this.panel3.Controls.Add(this.TicTacBtn7);
            this.panel3.Controls.Add(this.TicTacBtn5);
            this.panel3.Controls.Add(this.TicTacBtn4);
            this.panel3.Controls.Add(this.TicTacBtn2);
            this.panel3.Controls.Add(this.TicTacBtn1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 572);
            this.panel3.TabIndex = 0;
            // 
            // TicTacBtn9
            // 
            this.TicTacBtn9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn9.Location = new System.Drawing.Point(518, 383);
            this.TicTacBtn9.Name = "TicTacBtn9";
            this.TicTacBtn9.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn9.TabIndex = 0;
            this.TicTacBtn9.UseVisualStyleBackColor = false;
            this.TicTacBtn9.Click += new System.EventHandler(this.TicTacBtn9_Click);
            // 
            // TicTacBtn6
            // 
            this.TicTacBtn6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn6.Location = new System.Drawing.Point(518, 193);
            this.TicTacBtn6.Name = "TicTacBtn6";
            this.TicTacBtn6.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn6.TabIndex = 0;
            this.TicTacBtn6.UseVisualStyleBackColor = false;
            this.TicTacBtn6.Click += new System.EventHandler(this.TicTacBtn6_Click);
            // 
            // TicTacBtn3
            // 
            this.TicTacBtn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn3.Location = new System.Drawing.Point(518, 3);
            this.TicTacBtn3.Name = "TicTacBtn3";
            this.TicTacBtn3.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn3.TabIndex = 0;
            this.TicTacBtn3.UseVisualStyleBackColor = false;
            this.TicTacBtn3.Click += new System.EventHandler(this.TicTacBtn3_Click);
            // 
            // TicTacBtn8
            // 
            this.TicTacBtn8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn8.Location = new System.Drawing.Point(263, 383);
            this.TicTacBtn8.Name = "TicTacBtn8";
            this.TicTacBtn8.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn8.TabIndex = 0;
            this.TicTacBtn8.UseVisualStyleBackColor = false;
            this.TicTacBtn8.Click += new System.EventHandler(this.TicTacBtn8_Click);
            // 
            // TicTacBtn7
            // 
            this.TicTacBtn7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn7.Location = new System.Drawing.Point(8, 383);
            this.TicTacBtn7.Name = "TicTacBtn7";
            this.TicTacBtn7.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn7.TabIndex = 0;
            this.TicTacBtn7.UseVisualStyleBackColor = false;
            this.TicTacBtn7.Click += new System.EventHandler(this.TicTacBtn7_Click);
            // 
            // TicTacBtn5
            // 
            this.TicTacBtn5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn5.Location = new System.Drawing.Point(263, 193);
            this.TicTacBtn5.Name = "TicTacBtn5";
            this.TicTacBtn5.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn5.TabIndex = 0;
            this.TicTacBtn5.UseVisualStyleBackColor = false;
            this.TicTacBtn5.Click += new System.EventHandler(this.TicTacBtn5_Click);
            // 
            // TicTacBtn4
            // 
            this.TicTacBtn4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn4.Location = new System.Drawing.Point(8, 193);
            this.TicTacBtn4.Name = "TicTacBtn4";
            this.TicTacBtn4.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn4.TabIndex = 0;
            this.TicTacBtn4.UseVisualStyleBackColor = false;
            this.TicTacBtn4.Click += new System.EventHandler(this.TicTacBtn4_Click);
            // 
            // TicTacBtn2
            // 
            this.TicTacBtn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn2.Location = new System.Drawing.Point(263, 3);
            this.TicTacBtn2.Name = "TicTacBtn2";
            this.TicTacBtn2.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn2.TabIndex = 0;
            this.TicTacBtn2.UseVisualStyleBackColor = false;
            this.TicTacBtn2.Click += new System.EventHandler(this.TicTacBtn2_Click);
            // 
            // TicTacBtn1
            // 
            this.TicTacBtn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicTacBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacBtn1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicTacBtn1.Location = new System.Drawing.Point(8, 3);
            this.TicTacBtn1.Name = "TicTacBtn1";
            this.TicTacBtn1.Size = new System.Drawing.Size(249, 184);
            this.TicTacBtn1.TabIndex = 0;
            this.TicTacBtn1.UseVisualStyleBackColor = false;
            this.TicTacBtn1.Click += new System.EventHandler(this.TicTacBtn1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Brown;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(366, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 15);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Developed by MsWatts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TicTacBtn1;
        private System.Windows.Forms.Button TicTacBtn9;
        private System.Windows.Forms.Button TicTacBtn6;
        private System.Windows.Forms.Button TicTacBtn3;
        private System.Windows.Forms.Button TicTacBtn8;
        private System.Windows.Forms.Button TicTacBtn7;
        private System.Windows.Forms.Button TicTacBtn5;
        private System.Windows.Forms.Button TicTacBtn4;
        private System.Windows.Forms.Button TicTacBtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerO;
        private System.Windows.Forms.Label playerX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

