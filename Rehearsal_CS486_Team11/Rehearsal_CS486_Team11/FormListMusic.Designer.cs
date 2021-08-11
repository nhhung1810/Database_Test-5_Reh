
namespace Rehearsal_CS486_Team11
{
    partial class FormListMusic
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
            this.lblMusic = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxMusic = new System.Windows.Forms.ComboBox();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Location = new System.Drawing.Point(182, 51);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(50, 20);
            this.lblMusic.TabIndex = 0;
            this.lblMusic.Text = "Music";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbxMusic
            // 
            this.cbxMusic.FormattingEnabled = true;
            this.cbxMusic.Location = new System.Drawing.Point(319, 51);
            this.cbxMusic.Name = "cbxMusic";
            this.cbxMusic.Size = new System.Drawing.Size(188, 28);
            this.cbxMusic.TabIndex = 2;
            // 
            // dgvMusic
            // 
            this.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusic.Location = new System.Drawing.Point(146, 150);
            this.dgvMusic.Name = "dgvMusic";
            this.dgvMusic.RowHeadersWidth = 62;
            this.dgvMusic.RowTemplate.Height = 28;
            this.dgvMusic.Size = new System.Drawing.Size(497, 256);
            this.dgvMusic.TabIndex = 3;
            // 
            // FormListMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMusic);
            this.Controls.Add(this.cbxMusic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMusic);
            this.Name = "FormListMusic";
            this.Text = "FormListMusic";
            this.Load += new System.EventHandler(this.FormListMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxMusic;
        private System.Windows.Forms.DataGridView dgvMusic;
    }
}