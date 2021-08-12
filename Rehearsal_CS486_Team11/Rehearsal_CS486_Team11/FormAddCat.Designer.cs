
namespace Rehearsal_CS486_Team11
{
    partial class FormAddCat
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelAuthorID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ParentID = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // labelAuthorID
            // 
            this.labelAuthorID.AutoSize = true;
            this.labelAuthorID.Location = new System.Drawing.Point(16, 15);
            this.labelAuthorID.Name = "labelAuthorID";
            this.labelAuthorID.Size = new System.Drawing.Size(21, 17);
            this.labelAuthorID.TabIndex = 5;
            this.labelAuthorID.Text = "ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 22);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtAuthorName_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(162, 22);
            this.txtID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ParentID";
            // 
            // ParentID
            // 
            this.ParentID.Location = new System.Drawing.Point(102, 97);
            this.ParentID.Name = "ParentID";
            this.ParentID.Size = new System.Drawing.Size(162, 22);
            this.ParentID.TabIndex = 3;
            this.ParentID.TextChanged += new System.EventHandler(this.txtAuthorName_TextChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(208, 152);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormAddCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 203);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAuthorID);
            this.Controls.Add(this.ParentID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Name = "FormAddCat";
            this.Text = "Add category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAuthorID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ParentID;
        private System.Windows.Forms.Button buttonConfirm;
    }
}