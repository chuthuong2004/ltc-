
namespace GUI_CSharp
{
    partial class frmChkedListBox
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
            this.chklstLeft = new System.Windows.Forms.CheckedListBox();
            this.btnMoveOneFromLeftToRight = new System.Windows.Forms.Button();
            this.btnMoveAllFromLeftToRight = new System.Windows.Forms.Button();
            this.btnMoveOneFromRightToLeft = new System.Windows.Forms.Button();
            this.btnMoveAllFromRightToLeft = new System.Windows.Forms.Button();
            this.chklstRight = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chklstLeft
            // 
            this.chklstLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstLeft.FormattingEnabled = true;
            this.chklstLeft.Location = new System.Drawing.Point(10, 41);
            this.chklstLeft.Name = "chklstLeft";
            this.chklstLeft.Size = new System.Drawing.Size(181, 316);
            this.chklstLeft.TabIndex = 0;
            // 
            // btnMoveOneFromLeftToRight
            // 
            this.btnMoveOneFromLeftToRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMoveOneFromLeftToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveOneFromLeftToRight.Location = new System.Drawing.Point(214, 73);
            this.btnMoveOneFromLeftToRight.Name = "btnMoveOneFromLeftToRight";
            this.btnMoveOneFromLeftToRight.Size = new System.Drawing.Size(75, 37);
            this.btnMoveOneFromLeftToRight.TabIndex = 1;
            this.btnMoveOneFromLeftToRight.Text = ">";
            this.btnMoveOneFromLeftToRight.UseVisualStyleBackColor = false;
            this.btnMoveOneFromLeftToRight.Click += new System.EventHandler(this.btnMoveOneFromLeftToRight_Click);
            // 
            // btnMoveAllFromLeftToRight
            // 
            this.btnMoveAllFromLeftToRight.BackColor = System.Drawing.Color.Green;
            this.btnMoveAllFromLeftToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllFromLeftToRight.Location = new System.Drawing.Point(214, 140);
            this.btnMoveAllFromLeftToRight.Name = "btnMoveAllFromLeftToRight";
            this.btnMoveAllFromLeftToRight.Size = new System.Drawing.Size(75, 37);
            this.btnMoveAllFromLeftToRight.TabIndex = 1;
            this.btnMoveAllFromLeftToRight.Text = ">>";
            this.btnMoveAllFromLeftToRight.UseVisualStyleBackColor = false;
            this.btnMoveAllFromLeftToRight.Click += new System.EventHandler(this.btnMoveAllFromLeftToRight_Click);
            // 
            // btnMoveOneFromRightToLeft
            // 
            this.btnMoveOneFromRightToLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMoveOneFromRightToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveOneFromRightToLeft.Location = new System.Drawing.Point(214, 207);
            this.btnMoveOneFromRightToLeft.Name = "btnMoveOneFromRightToLeft";
            this.btnMoveOneFromRightToLeft.Size = new System.Drawing.Size(75, 37);
            this.btnMoveOneFromRightToLeft.TabIndex = 1;
            this.btnMoveOneFromRightToLeft.Text = "<";
            this.btnMoveOneFromRightToLeft.UseVisualStyleBackColor = false;
            this.btnMoveOneFromRightToLeft.Click += new System.EventHandler(this.btnMoveOneFromRightToLeft_Click);
            // 
            // btnMoveAllFromRightToLeft
            // 
            this.btnMoveAllFromRightToLeft.BackColor = System.Drawing.Color.Green;
            this.btnMoveAllFromRightToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllFromRightToLeft.Location = new System.Drawing.Point(214, 275);
            this.btnMoveAllFromRightToLeft.Name = "btnMoveAllFromRightToLeft";
            this.btnMoveAllFromRightToLeft.Size = new System.Drawing.Size(75, 37);
            this.btnMoveAllFromRightToLeft.TabIndex = 1;
            this.btnMoveAllFromRightToLeft.Text = "<<";
            this.btnMoveAllFromRightToLeft.UseVisualStyleBackColor = false;
            this.btnMoveAllFromRightToLeft.Click += new System.EventHandler(this.btnMoveAllFromRightToLeft_Click);
            // 
            // chklstRight
            // 
            this.chklstRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstRight.FormattingEnabled = true;
            this.chklstRight.Location = new System.Drawing.Point(307, 41);
            this.chklstRight.Name = "chklstRight";
            this.chklstRight.Size = new System.Drawing.Size(181, 316);
            this.chklstRight.TabIndex = 2;
            // 
            // frmChkedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.chklstRight);
            this.Controls.Add(this.btnMoveAllFromRightToLeft);
            this.Controls.Add(this.btnMoveOneFromRightToLeft);
            this.Controls.Add(this.btnMoveAllFromLeftToRight);
            this.Controls.Add(this.btnMoveOneFromLeftToRight);
            this.Controls.Add(this.chklstLeft);
            this.Name = "frmChkedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChkedListBox";
            this.Load += new System.EventHandler(this.frmChkedListBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstLeft;
        private System.Windows.Forms.Button btnMoveOneFromLeftToRight;
        private System.Windows.Forms.Button btnMoveAllFromLeftToRight;
        private System.Windows.Forms.Button btnMoveOneFromRightToLeft;
        private System.Windows.Forms.Button btnMoveAllFromRightToLeft;
        private System.Windows.Forms.CheckedListBox chklstRight;
    }
}