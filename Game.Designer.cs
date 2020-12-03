namespace TicTacToe_Nov2020
{
    partial class Game
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
            this.Grid = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.pictureBoxO = new System.Windows.Forms.PictureBox();
            this.labelScoreX = new System.Windows.Forms.Label();
            this.labelScoreO = new System.Windows.Forms.Label();
            this.Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxO)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.Grid.ColumnCount = 3;
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Grid.Controls.Add(this.pictureBox9, 2, 2);
            this.Grid.Controls.Add(this.pictureBox8, 1, 2);
            this.Grid.Controls.Add(this.pictureBox7, 0, 2);
            this.Grid.Controls.Add(this.pictureBox6, 2, 1);
            this.Grid.Controls.Add(this.pictureBox5, 1, 1);
            this.Grid.Controls.Add(this.pictureBox4, 0, 1);
            this.Grid.Controls.Add(this.pictureBox3, 2, 0);
            this.Grid.Controls.Add(this.pictureBox2, 1, 0);
            this.Grid.Controls.Add(this.pictureBox1, 0, 0);
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.RowCount = 3;
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Grid.Size = new System.Drawing.Size(449, 418);
            this.Grid.TabIndex = 0;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Location = new System.Drawing.Point(302, 281);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(142, 132);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Location = new System.Drawing.Point(153, 281);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(141, 132);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(5, 281);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(140, 132);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(302, 143);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(142, 130);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(153, 143);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(141, 130);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(5, 143);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 130);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(302, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 130);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(153, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 130);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(481, 339);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(293, 74);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Visible = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.Image = global::TicTacToe_Nov2020.Properties.Resources.x;
            this.pictureBoxX.Location = new System.Drawing.Point(481, 12);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(134, 123);
            this.pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxX.TabIndex = 3;
            this.pictureBoxX.TabStop = false;
            // 
            // pictureBoxO
            // 
            this.pictureBoxO.Image = global::TicTacToe_Nov2020.Properties.Resources.o;
            this.pictureBoxO.Location = new System.Drawing.Point(640, 12);
            this.pictureBoxO.Name = "pictureBoxO";
            this.pictureBoxO.Size = new System.Drawing.Size(134, 123);
            this.pictureBoxO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxO.TabIndex = 4;
            this.pictureBoxO.TabStop = false;
            // 
            // labelScoreX
            // 
            this.labelScoreX.AutoSize = true;
            this.labelScoreX.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreX.Location = new System.Drawing.Point(530, 171);
            this.labelScoreX.Name = "labelScoreX";
            this.labelScoreX.Size = new System.Drawing.Size(41, 44);
            this.labelScoreX.TabIndex = 5;
            this.labelScoreX.Text = "0";
            // 
            // labelScoreO
            // 
            this.labelScoreO.AutoSize = true;
            this.labelScoreO.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreO.Location = new System.Drawing.Point(686, 171);
            this.labelScoreO.Name = "labelScoreO";
            this.labelScoreO.Size = new System.Drawing.Size(41, 44);
            this.labelScoreO.TabIndex = 6;
            this.labelScoreO.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 419);
            this.Controls.Add(this.labelScoreO);
            this.Controls.Add(this.labelScoreX);
            this.Controls.Add(this.pictureBoxO);
            this.Controls.Add(this.pictureBoxX);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.Grid);
            this.Name = "Game";
            this.Text = "Form1";
            this.Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Grid;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.PictureBox pictureBoxO;
        private System.Windows.Forms.Label labelScoreX;
        private System.Windows.Forms.Label labelScoreO;
    }
}

