namespace Maze
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SoundON = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGame.ForeColor = System.Drawing.Color.Black;
            this.NewGame.Location = new System.Drawing.Point(198, 136);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(197, 55);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Info;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(198, 300);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 55);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SoundON
            // 
            this.SoundON.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoundON.ForeColor = System.Drawing.Color.Black;
            this.SoundON.Location = new System.Drawing.Point(198, 219);
            this.SoundON.Name = "SoundON";
            this.SoundON.Size = new System.Drawing.Size(197, 55);
            this.SoundON.TabIndex = 1;
            this.SoundON.Text = "Sound On/Off";
            this.SoundON.UseVisualStyleBackColor = true;
            this.SoundON.Click += new System.EventHandler(this.SoundON_Click);
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue.ForeColor = System.Drawing.Color.Black;
            this.Continue.Location = new System.Drawing.Point(198, 55);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(197, 55);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(597, 406);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.SoundON);
            this.Controls.Add(this.NewGame);
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SoundON;
        private System.Windows.Forms.Button Continue;
    }
}

