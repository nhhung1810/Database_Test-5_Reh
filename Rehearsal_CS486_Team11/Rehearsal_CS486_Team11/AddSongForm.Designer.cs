namespace Rehearsal_CS486_Team11
{
    partial class AddSongForm
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
            this.AddSongButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.songRelease = new System.Windows.Forms.TextBox();
            this.songQuality = new System.Windows.Forms.TextBox();
            this.songId = new System.Windows.Forms.TextBox();
            this.songOfficial = new System.Windows.Forms.TextBox();
            this.songViews = new System.Windows.Forms.TextBox();
            this.songName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddSongButton
            // 
            this.AddSongButton.Location = new System.Drawing.Point(21, 188);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(167, 23);
            this.AddSongButton.TabIndex = 26;
            this.AddSongButton.Text = "Add new song";
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "releaseData";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "official";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "views";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "id";
            // 
            // songRelease
            // 
            this.songRelease.Location = new System.Drawing.Point(88, 144);
            this.songRelease.Name = "songRelease";
            this.songRelease.Size = new System.Drawing.Size(100, 20);
            this.songRelease.TabIndex = 19;
            // 
            // songQuality
            // 
            this.songQuality.Location = new System.Drawing.Point(88, 118);
            this.songQuality.Name = "songQuality";
            this.songQuality.Size = new System.Drawing.Size(100, 20);
            this.songQuality.TabIndex = 18;
            // 
            // songId
            // 
            this.songId.Location = new System.Drawing.Point(88, 14);
            this.songId.Name = "songId";
            this.songId.Size = new System.Drawing.Size(100, 20);
            this.songId.TabIndex = 17;
            // 
            // songOfficial
            // 
            this.songOfficial.Location = new System.Drawing.Point(88, 92);
            this.songOfficial.Name = "songOfficial";
            this.songOfficial.Size = new System.Drawing.Size(100, 20);
            this.songOfficial.TabIndex = 16;
            // 
            // songViews
            // 
            this.songViews.Location = new System.Drawing.Point(88, 66);
            this.songViews.Name = "songViews";
            this.songViews.Size = new System.Drawing.Size(100, 20);
            this.songViews.TabIndex = 15;
            // 
            // songName
            // 
            this.songName.Location = new System.Drawing.Point(88, 40);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(100, 20);
            this.songName.TabIndex = 14;
            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 241);
            this.Controls.Add(this.AddSongButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songRelease);
            this.Controls.Add(this.songQuality);
            this.Controls.Add(this.songId);
            this.Controls.Add(this.songOfficial);
            this.Controls.Add(this.songViews);
            this.Controls.Add(this.songName);
            this.Name = "AddSongForm";
            this.Text = "AddSongForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox songRelease;
        private System.Windows.Forms.TextBox songQuality;
        private System.Windows.Forms.TextBox songId;
        private System.Windows.Forms.TextBox songOfficial;
        private System.Windows.Forms.TextBox songViews;
        private System.Windows.Forms.TextBox songName;
    }
}