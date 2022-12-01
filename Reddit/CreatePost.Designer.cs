﻿namespace Reddit
{
    partial class CreatePost
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCreatePostTitle = new System.Windows.Forms.Label();
            this.lblPostName = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreatePostTitle
            // 
            this.lblCreatePostTitle.AutoSize = true;
            this.lblCreatePostTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreatePostTitle.Location = new System.Drawing.Point(170, 11);
            this.lblCreatePostTitle.Name = "lblCreatePostTitle";
            this.lblCreatePostTitle.Size = new System.Drawing.Size(208, 37);
            this.lblCreatePostTitle.TabIndex = 0;
            this.lblCreatePostTitle.Text = "CREATE POST";
            this.lblCreatePostTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPostName
            // 
            this.lblPostName.AutoSize = true;
            this.lblPostName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPostName.Location = new System.Drawing.Point(96, 92);
            this.lblPostName.Name = "lblPostName";
            this.lblPostName.Size = new System.Drawing.Size(104, 20);
            this.lblPostName.TabIndex = 1;
            this.lblPostName.Text = "Post Name : ";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContent.Location = new System.Drawing.Point(117, 135);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(83, 20);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 136);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 115);
            this.textBox2.TabIndex = 4;
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.btnCreatePost.FlatAppearance.BorderSize = 0;
            this.btnCreatePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCreatePost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnCreatePost.Location = new System.Drawing.Point(197, 273);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(96, 40);
            this.btnCreatePost.TabIndex = 9;
            this.btnCreatePost.Text = "Create";
            this.btnCreatePost.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnExit.Location = new System.Drawing.Point(301, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblPostName);
            this.Controls.Add(this.lblCreatePostTitle);
            this.Name = "CreatePost";
            this.Size = new System.Drawing.Size(565, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCreatePostTitle;
        private Label lblPostName;
        private Label lblContent;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCreatePost;
        private Button btnExit;
    }
}
