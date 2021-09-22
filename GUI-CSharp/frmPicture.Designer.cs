
namespace GUI_CSharp
{
    partial class frmPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPicture));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picOn = new System.Windows.Forms.PictureBox();
            this.picOff = new System.Windows.Forms.PictureBox();
            this.btnTurnOnOff = new System.Windows.Forms.Button();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblNameDesign = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // picOn
            // 
            this.picOn.Image = ((System.Drawing.Image)(resources.GetObject("picOn.Image")));
            this.picOn.Location = new System.Drawing.Point(123, 79);
            this.picOn.Name = "picOn";
            this.picOn.Size = new System.Drawing.Size(160, 158);
            this.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOn.TabIndex = 2;
            this.picOn.TabStop = false;
            // 
            // picOff
            // 
            this.picOff.Image = ((System.Drawing.Image)(resources.GetObject("picOff.Image")));
            this.picOff.Location = new System.Drawing.Point(123, 79);
            this.picOff.Name = "picOff";
            this.picOff.Size = new System.Drawing.Size(160, 158);
            this.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOff.TabIndex = 2;
            this.picOff.TabStop = false;
            // 
            // btnTurnOnOff
            // 
            this.btnTurnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOnOff.Location = new System.Drawing.Point(22, 243);
            this.btnTurnOnOff.Name = "btnTurnOnOff";
            this.btnTurnOnOff.Size = new System.Drawing.Size(349, 38);
            this.btnTurnOnOff.TabIndex = 3;
            this.btnTurnOnOff.UseVisualStyleBackColor = true;
            this.btnTurnOnOff.Click += new System.EventHandler(this.btnTurnOnOff_Click);
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.Location = new System.Drawing.Point(18, 301);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(115, 24);
            this.lblDesign.TabIndex = 4;
            this.lblDesign.Text = "Design by: ";
            // 
            // lblNameDesign
            // 
            this.lblNameDesign.AutoSize = true;
            this.lblNameDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDesign.Location = new System.Drawing.Point(139, 301);
            this.lblNameDesign.Name = "lblNameDesign";
            this.lblNameDesign.Size = new System.Drawing.Size(127, 24);
            this.lblNameDesign.TabIndex = 5;
            this.lblNameDesign.Text = "Chu Thương";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(287, 297);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 351);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblNameDesign);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.btnTurnOnOff);
            this.Controls.Add(this.picOff);
            this.Controls.Add(this.picOn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "frmPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tắt mở đèn";
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picOn;
        private System.Windows.Forms.PictureBox picOff;
        private System.Windows.Forms.Button btnTurnOnOff;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblNameDesign;
        private System.Windows.Forms.Button btnThoat;
    }
}