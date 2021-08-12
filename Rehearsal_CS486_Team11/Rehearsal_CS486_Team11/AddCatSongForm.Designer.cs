namespace Rehearsal_CS486_Team11
{
    partial class AddCatSongForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.labelCatID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtSongID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 19);
            this.button2.TabIndex = 35;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelCatID
            // 
            this.labelCatID.AutoSize = true;
            this.labelCatID.Location = new System.Drawing.Point(10, 48);
            this.labelCatID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCatID.Name = "labelCatID";
            this.labelCatID.Size = new System.Drawing.Size(63, 13);
            this.labelCatID.TabIndex = 34;
            this.labelCatID.Text = "Category ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Song ID";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(74, 44);
            this.txtCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(122, 20);
            this.txtCat.TabIndex = 31;
            // 
            // txtSongID
            // 
            this.txtSongID.Location = new System.Drawing.Point(74, 11);
            this.txtSongID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSongID.Name = "txtSongID";
            this.txtSongID.Size = new System.Drawing.Size(122, 20);
            this.txtSongID.TabIndex = 32;
            // 
            // AddCatSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 138);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelCatID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtSongID);
            this.Name = "AddCatSongForm";
            this.Text = "AddCatSongForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCatID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtSongID;
    }
}