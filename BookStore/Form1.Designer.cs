using System.Drawing;

namespace BookStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataInfos = new System.Windows.Forms.DataGridView();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtReview = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataInfos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdd.Location = new System.Drawing.Point(251, 439);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 79);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataInfos
            // 
            this.DataInfos.AllowUserToAddRows = false;
            this.DataInfos.AllowUserToDeleteRows = false;
            this.DataInfos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataInfos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataInfos.Location = new System.Drawing.Point(384, 99);
            this.DataInfos.Name = "DataInfos";
            this.DataInfos.ReadOnly = true;
            this.DataInfos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataInfos.RowHeadersWidth = 51;
            this.DataInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataInfos.Size = new System.Drawing.Size(600, 426);
            this.DataInfos.TabIndex = 2;
            this.DataInfos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataInfos_CellClick);
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(170, 25);
            this.TxtTitle.MaxLength = 50;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtTitle.Size = new System.Drawing.Size(208, 30);
            this.TxtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Algerian", 12F);
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(170, 70);
            this.TxtAuthor.MaxLength = 50;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtAuthor.Size = new System.Drawing.Size(208, 30);
            this.TxtAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Algerian", 12F);
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "B_Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBNumber
            // 
            this.TxtBNumber.Location = new System.Drawing.Point(170, 172);
            this.TxtBNumber.MaxLength = 11;
            this.TxtBNumber.Name = "TxtBNumber";
            this.TxtBNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBNumber.Size = new System.Drawing.Size(208, 30);
            this.TxtBNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Algerian", 12F);
            this.label4.Location = new System.Drawing.Point(25, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Review";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtReview
            // 
            this.TxtReview.Location = new System.Drawing.Point(134, 223);
            this.TxtReview.MaxLength = 300;
            this.TxtReview.Multiline = true;
            this.TxtReview.Name = "TxtReview";
            this.TxtReview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtReview.Size = new System.Drawing.Size(244, 128);
            this.TxtReview.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Algerian", 12F);
            this.label5.Location = new System.Drawing.Point(25, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtGenre
            // 
            this.TxtGenre.Location = new System.Drawing.Point(170, 120);
            this.TxtGenre.MaxLength = 50;
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtGenre.Size = new System.Drawing.Size(208, 30);
            this.TxtGenre.TabIndex = 9;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(149, 375);
            this.TxtPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPrice.Size = new System.Drawing.Size(73, 30);
            this.TxtPrice.TabIndex = 11;
            this.TxtPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Algerian", 12F);
            this.label6.Location = new System.Drawing.Point(24, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 43);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearch.Location = new System.Drawing.Point(275, 359);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(83, 64);
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEdit.BackgroundImage")));
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEdit.Location = new System.Drawing.Point(25, 439);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(86, 79);
            this.BtnEdit.TabIndex = 16;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.Location = new System.Drawing.Point(134, 439);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 79);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.SystemColors.Info;
            this.BtnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShow.BackgroundImage")));
            this.BtnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShow.Font = new System.Drawing.Font("Pristina", 19F);
            this.BtnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShow.Location = new System.Drawing.Point(435, 25);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnShow.Size = new System.Drawing.Size(70, 61);
            this.BtnShow.TabIndex = 18;
            this.BtnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Algerian", 16F);
            this.label9.Location = new System.Drawing.Point(228, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "$";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1216, 715);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BookStore.Properties.Resources.attaachment_18329574;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(753, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 74);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(996, 546);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtGenre);
            this.Controls.Add(this.TxtReview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataInfos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DataInfos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataInfos;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtReview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.NumericUpDown TxtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

