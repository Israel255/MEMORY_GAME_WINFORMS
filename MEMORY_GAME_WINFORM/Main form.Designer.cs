namespace MEMORY_GAME_WINFORM
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameMenuMs = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuMs = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuMs = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuMs = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNumLbl = new System.Windows.Forms.Label();
            this.secondNumLbl = new System.Windows.Forms.Label();
            this.thirdNumLbl = new System.Windows.Forms.Label();
            this.fourthNumLbl = new System.Windows.Forms.Label();
            this.fifthNumLbl = new System.Windows.Forms.Label();
            this.firstNumTxtbx = new System.Windows.Forms.TextBox();
            this.fifthNumTxtbx = new System.Windows.Forms.TextBox();
            this.fourthNumTxtbx = new System.Windows.Forms.TextBox();
            this.thirdNumTxtbx = new System.Windows.Forms.TextBox();
            this.secondNumTxtbx = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.highScoreLbx = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuMs,
            this.helpMenuMs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameMenuMs
            // 
            this.gameMenuMs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuMs,
            this.exitMenuMs});
            this.gameMenuMs.Name = "gameMenuMs";
            this.gameMenuMs.Size = new System.Drawing.Size(50, 20);
            this.gameMenuMs.Text = "&Game";
            // 
            // newGameMenuMs
            // 
            this.newGameMenuMs.Name = "newGameMenuMs";
            this.newGameMenuMs.Size = new System.Drawing.Size(180, 22);
            this.newGameMenuMs.Text = "New Game";
            this.newGameMenuMs.Click += new System.EventHandler(this.newGameMenuMs_Click);
            // 
            // exitMenuMs
            // 
            this.exitMenuMs.Name = "exitMenuMs";
            this.exitMenuMs.Size = new System.Drawing.Size(180, 22);
            this.exitMenuMs.Text = "Exit";
            this.exitMenuMs.Click += new System.EventHandler(this.exitMenuMs_Click);
            // 
            // helpMenuMs
            // 
            this.helpMenuMs.Name = "helpMenuMs";
            this.helpMenuMs.Size = new System.Drawing.Size(44, 20);
            this.helpMenuMs.Text = "&Help";
            // 
            // firstNumLbl
            // 
            this.firstNumLbl.AutoSize = true;
            this.firstNumLbl.Location = new System.Drawing.Point(82, 64);
            this.firstNumLbl.Name = "firstNumLbl";
            this.firstNumLbl.Size = new System.Drawing.Size(0, 13);
            this.firstNumLbl.TabIndex = 1;
            // 
            // secondNumLbl
            // 
            this.secondNumLbl.AutoSize = true;
            this.secondNumLbl.Location = new System.Drawing.Point(184, 64);
            this.secondNumLbl.Name = "secondNumLbl";
            this.secondNumLbl.Size = new System.Drawing.Size(0, 13);
            this.secondNumLbl.TabIndex = 2;
            // 
            // thirdNumLbl
            // 
            this.thirdNumLbl.AutoSize = true;
            this.thirdNumLbl.Location = new System.Drawing.Point(284, 64);
            this.thirdNumLbl.Name = "thirdNumLbl";
            this.thirdNumLbl.Size = new System.Drawing.Size(0, 13);
            this.thirdNumLbl.TabIndex = 3;
            // 
            // fourthNumLbl
            // 
            this.fourthNumLbl.AutoSize = true;
            this.fourthNumLbl.Location = new System.Drawing.Point(403, 64);
            this.fourthNumLbl.Name = "fourthNumLbl";
            this.fourthNumLbl.Size = new System.Drawing.Size(0, 13);
            this.fourthNumLbl.TabIndex = 4;
            // 
            // fifthNumLbl
            // 
            this.fifthNumLbl.AutoSize = true;
            this.fifthNumLbl.Location = new System.Drawing.Point(504, 64);
            this.fifthNumLbl.Name = "fifthNumLbl";
            this.fifthNumLbl.Size = new System.Drawing.Size(0, 13);
            this.fifthNumLbl.TabIndex = 5;
            // 
            // firstNumTxtbx
            // 
            this.firstNumTxtbx.Location = new System.Drawing.Point(85, 94);
            this.firstNumTxtbx.Name = "firstNumTxtbx";
            this.firstNumTxtbx.Size = new System.Drawing.Size(32, 20);
            this.firstNumTxtbx.TabIndex = 6;
            this.firstNumTxtbx.TextChanged += new System.EventHandler(this.firstNumTxtbx_TextChanged);
            // 
            // fifthNumTxtbx
            // 
            this.fifthNumTxtbx.Location = new System.Drawing.Point(507, 94);
            this.fifthNumTxtbx.Name = "fifthNumTxtbx";
            this.fifthNumTxtbx.Size = new System.Drawing.Size(32, 20);
            this.fifthNumTxtbx.TabIndex = 7;
            this.fifthNumTxtbx.TextChanged += new System.EventHandler(this.fifthNumTxtbx_TextChanged);
            // 
            // fourthNumTxtbx
            // 
            this.fourthNumTxtbx.Location = new System.Drawing.Point(406, 94);
            this.fourthNumTxtbx.Name = "fourthNumTxtbx";
            this.fourthNumTxtbx.Size = new System.Drawing.Size(32, 20);
            this.fourthNumTxtbx.TabIndex = 8;
            this.fourthNumTxtbx.TextChanged += new System.EventHandler(this.fourthNumTxtbx_TextChanged);
            // 
            // thirdNumTxtbx
            // 
            this.thirdNumTxtbx.Location = new System.Drawing.Point(287, 94);
            this.thirdNumTxtbx.Name = "thirdNumTxtbx";
            this.thirdNumTxtbx.Size = new System.Drawing.Size(32, 20);
            this.thirdNumTxtbx.TabIndex = 9;
            this.thirdNumTxtbx.TextChanged += new System.EventHandler(this.thirdNumTxtbx_TextChanged);
            // 
            // secondNumTxtbx
            // 
            this.secondNumTxtbx.Location = new System.Drawing.Point(187, 94);
            this.secondNumTxtbx.Name = "secondNumTxtbx";
            this.secondNumTxtbx.Size = new System.Drawing.Size(32, 20);
            this.secondNumTxtbx.TabIndex = 10;
            this.secondNumTxtbx.TextChanged += new System.EventHandler(this.secondNumTxtbx_TextChanged);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(363, 169);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(464, 169);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 12;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            // 
            // highScoreLbl
            // 
            this.highScoreLbl.AutoSize = true;
            this.highScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.highScoreLbl.Location = new System.Drawing.Point(7, 223);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Size = new System.Drawing.Size(135, 25);
            this.highScoreLbl.TabIndex = 13;
            this.highScoreLbl.Text = "High Score:";
            // 
            // highScoreLbx
            // 
            this.highScoreLbx.FormattingEnabled = true;
            this.highScoreLbx.Location = new System.Drawing.Point(12, 251);
            this.highScoreLbx.Name = "highScoreLbx";
            this.highScoreLbx.Size = new System.Drawing.Size(527, 173);
            this.highScoreLbx.TabIndex = 14;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 432);
            this.Controls.Add(this.highScoreLbx);
            this.Controls.Add(this.highScoreLbl);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.secondNumTxtbx);
            this.Controls.Add(this.thirdNumTxtbx);
            this.Controls.Add(this.fourthNumTxtbx);
            this.Controls.Add(this.fifthNumTxtbx);
            this.Controls.Add(this.firstNumTxtbx);
            this.Controls.Add(this.fifthNumLbl);
            this.Controls.Add(this.fourthNumLbl);
            this.Controls.Add(this.thirdNumLbl);
            this.Controls.Add(this.secondNumLbl);
            this.Controls.Add(this.firstNumLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Remember The Number!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameMenuMs;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuMs;
        private System.Windows.Forms.ToolStripMenuItem helpMenuMs;
        private System.Windows.Forms.Label firstNumLbl;
        private System.Windows.Forms.Label secondNumLbl;
        private System.Windows.Forms.Label thirdNumLbl;
        private System.Windows.Forms.Label fourthNumLbl;
        private System.Windows.Forms.Label fifthNumLbl;
        private System.Windows.Forms.TextBox firstNumTxtbx;
        private System.Windows.Forms.TextBox fifthNumTxtbx;
        private System.Windows.Forms.TextBox fourthNumTxtbx;
        private System.Windows.Forms.TextBox thirdNumTxtbx;
        private System.Windows.Forms.TextBox secondNumTxtbx;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Label highScoreLbl;
        private System.Windows.Forms.ListBox highScoreLbx;
        private System.Windows.Forms.ToolStripMenuItem exitMenuMs;
    }
}

