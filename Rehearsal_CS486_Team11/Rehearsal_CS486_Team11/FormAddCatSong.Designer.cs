
namespace Rehearsal_CS486_Team11
{
    partial class FormAddCatSong
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
            this.labelCatID = new System.Windows.Forms.Label();
            this.labelAuthorID = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtSongID = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCatID
            // 
            this.labelCatID.AutoSize = true;
            this.labelCatID.Location = new System.Drawing.Point(16, 58);
            this.labelCatID.Name = "labelCatID";
            this.labelCatID.Size = new System.Drawing.Size(82, 17);
            this.labelCatID.TabIndex = 10;
            this.labelCatID.Text = "Category ID";
            // 
            // labelAuthorID
            // 
            this.labelAuthorID.AutoSize = true;
            this.labelAuthorID.Location = new System.Drawing.Point(16, 15);
            this.labelAuthorID.Name = "labelAuthorID";
            this.labelAuthorID.Size = new System.Drawing.Size(58, 17);
            this.labelAuthorID.TabIndex = 9;
            this.labelAuthorID.Text = "Song ID";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(102, 53);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(162, 22);
            this.txtCat.TabIndex = 7;
            // 
            // txtSongID
            // 
            this.txtSongID.Location = new System.Drawing.Point(102, 12);
            this.txtSongID.Name = "txtSongID";
            this.txtSongID.Size = new System.Drawing.Size(162, 22);
            this.txtSongID.TabIndex = 8;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(223, 115);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(114, 23);
            this.buttonConfirm.TabIndex = 11;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddCatSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 170);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelCatID);
            this.Controls.Add(this.labelAuthorID);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtSongID);
            this.Name = "FormAddCatSong";
            this.Text = "Add categorySong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCatID;
        private System.Windows.Forms.Label labelAuthorID;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtSongID;
        private System.Windows.Forms.Button buttonConfirm;
    }
}