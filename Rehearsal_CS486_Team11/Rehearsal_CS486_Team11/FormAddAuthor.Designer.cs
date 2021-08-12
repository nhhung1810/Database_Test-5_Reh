
namespace Rehearsal_CS486_Team11
{
    partial class FormAddAuthor
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
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.labelAuthorID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(73, 12);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(100, 22);
            this.txtAuthorId.TabIndex = 0;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(73, 53);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(100, 22);
            this.txtAuthorName.TabIndex = 0;
            // 
            // labelAuthorID
            // 
            this.labelAuthorID.AutoSize = true;
            this.labelAuthorID.Location = new System.Drawing.Point(21, 15);
            this.labelAuthorID.Name = "labelAuthorID";
            this.labelAuthorID.Size = new System.Drawing.Size(21, 17);
            this.labelAuthorID.TabIndex = 1;
            this.labelAuthorID.Text = "ID";
            this.labelAuthorID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(216, 90);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormAddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 137);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAuthorID);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtAuthorId);
            this.Name = "FormAddAuthor";
            this.Text = "Add author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label labelAuthorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirm;
    }
}