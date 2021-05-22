
namespace masterDetailSongAlbums
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_songs = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_album_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.dtp_album = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_song_duration = new System.Windows.Forms.TextBox();
            this.btn_song_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_songs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_album);
            this.groupBox1.Controls.Add(this.txt_author);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_album_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(74, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Album";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_song_add);
            this.groupBox2.Controls.Add(this.txt_song_duration);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(74, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Song";
            // 
            // dgv_songs
            // 
            this.dgv_songs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_songs.Location = new System.Drawing.Point(74, 335);
            this.dgv_songs.Name = "dgv_songs";
            this.dgv_songs.RowHeadersWidth = 51;
            this.dgv_songs.RowTemplate.Height = 29;
            this.dgv_songs.Size = new System.Drawing.Size(994, 287);
            this.dgv_songs.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(973, 629);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 29);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_album_name
            // 
            this.txt_album_name.Location = new System.Drawing.Point(132, 35);
            this.txt_album_name.Name = "txt_album_name";
            this.txt_album_name.Size = new System.Drawing.Size(250, 27);
            this.txt_album_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(132, 84);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(250, 27);
            this.txt_author.TabIndex = 1;
            // 
            // dtp_album
            // 
            this.dtp_album.Location = new System.Drawing.Point(704, 35);
            this.dtp_album.Name = "dtp_album";
            this.dtp_album.Size = new System.Drawing.Size(250, 27);
            this.dtp_album.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Release Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Duration";
            // 
            // txt_song_duration
            // 
            this.txt_song_duration.Location = new System.Drawing.Point(145, 82);
            this.txt_song_duration.Name = "txt_song_duration";
            this.txt_song_duration.Size = new System.Drawing.Size(250, 27);
            this.txt_song_duration.TabIndex = 3;
            // 
            // btn_song_add
            // 
            this.btn_song_add.Location = new System.Drawing.Point(442, 85);
            this.btn_song_add.Name = "btn_song_add";
            this.btn_song_add.Size = new System.Drawing.Size(94, 29);
            this.btn_song_add.TabIndex = 2;
            this.btn_song_add.Text = "Add";
            this.btn_song_add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 703);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_songs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_songs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_album;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_album_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_song_duration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_songs;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_song_add;
    }
}

