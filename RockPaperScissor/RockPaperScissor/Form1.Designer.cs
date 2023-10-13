namespace RockPaperScissor
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.txtBot = new System.Windows.Forms.TextBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.lblScoreBot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumClicks = new System.Windows.Forms.Label();
            this.lblNumDraw = new System.Windows.Forms.Label();
            this.lblPaperClicks = new System.Windows.Forms.Label();
            this.lblScissorClicks = new System.Windows.Forms.Label();
            this.lblRockClicks = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblConsider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRock.Location = new System.Drawing.Point(141, 157);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(141, 187);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(141, 217);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 2;
            this.btnScissor.Text = "Scissor";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(262, 189);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer.TabIndex = 3;
            // 
            // txtBot
            // 
            this.txtBot.Location = new System.Drawing.Point(581, 188);
            this.txtBot.Name = "txtBot";
            this.txtBot.Size = new System.Drawing.Size(100, 20);
            this.txtBot.TabIndex = 4;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(319, 36);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(166, 13);
            this.lblGame.TabIndex = 5;
            this.lblGame.Text = "Welcome to Rock Paper Scissors";
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoSize = true;
            this.lblScorePlayer.Location = new System.Drawing.Point(259, 275);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(41, 13);
            this.lblScorePlayer.TabIndex = 6;
            this.lblScorePlayer.Text = "Score: ";
            // 
            // lblScoreBot
            // 
            this.lblScoreBot.AutoSize = true;
            this.lblScoreBot.Location = new System.Drawing.Point(578, 275);
            this.lblScoreBot.Name = "lblScoreBot";
            this.lblScoreBot.Size = new System.Drawing.Size(41, 13);
            this.lblScoreBot.TabIndex = 7;
            this.lblScoreBot.Text = "Score: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your Opponent\'s points";
            // 
            // lblNumClicks
            // 
            this.lblNumClicks.AutoSize = true;
            this.lblNumClicks.Location = new System.Drawing.Point(177, 86);
            this.lblNumClicks.Name = "lblNumClicks";
            this.lblNumClicks.Size = new System.Drawing.Size(93, 13);
            this.lblNumClicks.TabIndex = 10;
            this.lblNumClicks.Text = "Number of Clicks: ";
            // 
            // lblNumDraw
            // 
            this.lblNumDraw.AutoSize = true;
            this.lblNumDraw.Location = new System.Drawing.Point(460, 86);
            this.lblNumDraw.Name = "lblNumDraw";
            this.lblNumDraw.Size = new System.Drawing.Size(221, 13);
            this.lblNumDraw.TabIndex = 11;
            this.lblNumDraw.Text = "Number of times where a draw has occurred: ";
            // 
            // lblPaperClicks
            // 
            this.lblPaperClicks.AutoSize = true;
            this.lblPaperClicks.Location = new System.Drawing.Point(37, 428);
            this.lblPaperClicks.Name = "lblPaperClicks";
            this.lblPaperClicks.Size = new System.Drawing.Size(179, 13);
            this.lblPaperClicks.TabIndex = 12;
            this.lblPaperClicks.Text = "Number of times Paper was clicked: ";
            // 
            // lblScissorClicks
            // 
            this.lblScissorClicks.AutoSize = true;
            this.lblScissorClicks.Location = new System.Drawing.Point(319, 428);
            this.lblScissorClicks.Name = "lblScissorClicks";
            this.lblScissorClicks.Size = new System.Drawing.Size(190, 13);
            this.lblScissorClicks.TabIndex = 13;
            this.lblScissorClicks.Text = "Number of times Scissors was clicked: ";
            // 
            // lblRockClicks
            // 
            this.lblRockClicks.AutoSize = true;
            this.lblRockClicks.Location = new System.Drawing.Point(578, 428);
            this.lblRockClicks.Name = "lblRockClicks";
            this.lblRockClicks.Size = new System.Drawing.Size(177, 13);
            this.lblRockClicks.TabIndex = 14;
            this.lblRockClicks.Text = "Number of times Rock was clicked: ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 325);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 13);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "Note: ";
            // 
            // lblConsider
            // 
            this.lblConsider.AutoSize = true;
            this.lblConsider.Location = new System.Drawing.Point(12, 349);
            this.lblConsider.Name = "lblConsider";
            this.lblConsider.Size = new System.Drawing.Size(54, 13);
            this.lblConsider.TabIndex = 16;
            this.lblConsider.Text = "Consider: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConsider);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblRockClicks);
            this.Controls.Add(this.lblScissorClicks);
            this.Controls.Add(this.lblPaperClicks);
            this.Controls.Add(this.lblNumDraw);
            this.Controls.Add(this.lblNumClicks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScoreBot);
            this.Controls.Add(this.lblScorePlayer);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.txtBot);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.TextBox txtBot;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblScorePlayer;
        private System.Windows.Forms.Label lblScoreBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumClicks;
        private System.Windows.Forms.Label lblNumDraw;
        private System.Windows.Forms.Label lblPaperClicks;
        private System.Windows.Forms.Label lblScissorClicks;
        private System.Windows.Forms.Label lblRockClicks;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblConsider;
    }
}

