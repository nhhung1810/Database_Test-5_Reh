namespace Rehearsal_CS486_Team11
{
    partial class AddAuthorForm
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAuthorID = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(162, 74);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(56, 19);
            this.buttonConfirm.TabIndex = 23;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Name";
            // 
            // labelAuthorID
            // 
            this.labelAuthorID.AutoSize = true;
            this.labelAuthorID.Location = new System.Drawing.Point(16, 13);
            this.labelAuthorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthorID.Name = "labelAuthorID";
            this.labelAuthorID.Size = new System.Drawing.Size(18, 13);
            this.labelAuthorID.TabIndex = 21;
            this.labelAuthorID.Text = "ID";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(55, 44);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(76, 20);
            this.txtAuthorName.TabIndex = 19;
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(55, 11);
            this.txtAuthorId.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(76, 20);
            this.txtAuthorId.TabIndex = 20;
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 127);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelAuthorID);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtAuthorId);
            this.Name = "AddAuthorForm";
            this.Text = "AddAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAuthorID;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtAuthorId;
    }
}