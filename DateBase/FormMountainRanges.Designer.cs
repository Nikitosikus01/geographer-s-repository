
namespace DateBase
{
    partial class FormMountainRanges
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
            this.buttonLand = new System.Windows.Forms.Button();
            this.buttonOceans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLand
            // 
            this.buttonLand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLand.FlatAppearance.BorderSize = 2;
            this.buttonLand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonLand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLand.Location = new System.Drawing.Point(17, 42);
            this.buttonLand.Name = "buttonLand";
            this.buttonLand.Size = new System.Drawing.Size(134, 60);
            this.buttonLand.TabIndex = 0;
            this.buttonLand.Text = "На суше";
            this.buttonLand.UseVisualStyleBackColor = true;
            this.buttonLand.Click += new System.EventHandler(this.buttonLand_Click);
            // 
            // buttonOceans
            // 
            this.buttonOceans.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonOceans.FlatAppearance.BorderSize = 2;
            this.buttonOceans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonOceans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonOceans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOceans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOceans.Location = new System.Drawing.Point(177, 42);
            this.buttonOceans.Name = "buttonOceans";
            this.buttonOceans.Size = new System.Drawing.Size(134, 60);
            this.buttonOceans.TabIndex = 1;
            this.buttonOceans.Text = "В океане";
            this.buttonOceans.UseVisualStyleBackColor = true;
            this.buttonOceans.Click += new System.EventHandler(this.buttonOceans_Click);
            // 
            // FormMountainRanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 135);
            this.Controls.Add(this.buttonOceans);
            this.Controls.Add(this.buttonLand);
            this.Name = "FormMountainRanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMountainRanges";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLand;
        private System.Windows.Forms.Button buttonOceans;
    }
}