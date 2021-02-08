
namespace MovieAppWin
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
            this.btnShowMovieDetails = new System.Windows.Forms.Button();
            this.btnShowMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMId = new System.Windows.Forms.Label();
            this.lblMName1 = new System.Windows.Forms.Label();
            this.lblActor1 = new System.Windows.Forms.Label();
            this.lblTSold1 = new System.Windows.Forms.Label();
            this.lblMName2 = new System.Windows.Forms.Label();
            this.lblActor2 = new System.Windows.Forms.Label();
            this.lblTSold2 = new System.Windows.Forms.Label();
            this.txtMid = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.txtTsold = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowMovieDetails
            // 
            this.btnShowMovieDetails.Location = new System.Drawing.Point(-1, 1);
            this.btnShowMovieDetails.Name = "btnShowMovieDetails";
            this.btnShowMovieDetails.Size = new System.Drawing.Size(120, 33);
            this.btnShowMovieDetails.TabIndex = 0;
            this.btnShowMovieDetails.Text = "Movie Details";
            this.btnShowMovieDetails.UseVisualStyleBackColor = true;
            this.btnShowMovieDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowMovie
            // 
            this.btnShowMovie.Location = new System.Drawing.Point(125, 0);
            this.btnShowMovie.Name = "btnShowMovie";
            this.btnShowMovie.Size = new System.Drawing.Size(103, 33);
            this.btnShowMovie.TabIndex = 1;
            this.btnShowMovie.Text = "Show Movies";
            this.btnShowMovie.UseVisualStyleBackColor = true;
            this.btnShowMovie.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(231, 1);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(106, 31);
            this.btnUpdateMovie.TabIndex = 2;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblMId
            // 
            this.lblMId.AutoSize = true;
            this.lblMId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMId.Location = new System.Drawing.Point(30, 276);
            this.lblMId.Name = "lblMId";
            this.lblMId.Size = new System.Drawing.Size(130, 20);
            this.lblMId.TabIndex = 4;
            this.lblMId.Text = "Enter Movie Id";
            // 
            // lblMName1
            // 
            this.lblMName1.AutoSize = true;
            this.lblMName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName1.Location = new System.Drawing.Point(30, 321);
            this.lblMName1.Name = "lblMName1";
            this.lblMName1.Size = new System.Drawing.Size(112, 20);
            this.lblMName1.TabIndex = 5;
            this.lblMName1.Text = "Movie Name";
            // 
            // lblActor1
            // 
            this.lblActor1.AutoSize = true;
            this.lblActor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActor1.Location = new System.Drawing.Point(40, 364);
            this.lblActor1.Name = "lblActor1";
            this.lblActor1.Size = new System.Drawing.Size(54, 20);
            this.lblActor1.TabIndex = 6;
            this.lblActor1.Text = "Actor";
            // 
            // lblTSold1
            // 
            this.lblTSold1.AutoSize = true;
            this.lblTSold1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSold1.Location = new System.Drawing.Point(30, 394);
            this.lblTSold1.Name = "lblTSold1";
            this.lblTSold1.Size = new System.Drawing.Size(103, 20);
            this.lblTSold1.TabIndex = 7;
            this.lblTSold1.Text = "Ticket Sold";
            // 
            // lblMName2
            // 
            this.lblMName2.AutoSize = true;
            this.lblMName2.Location = new System.Drawing.Point(184, 324);
            this.lblMName2.Name = "lblMName2";
            this.lblMName2.Size = new System.Drawing.Size(0, 17);
            this.lblMName2.TabIndex = 8;
            // 
            // lblActor2
            // 
            this.lblActor2.AutoSize = true;
            this.lblActor2.Location = new System.Drawing.Point(182, 367);
            this.lblActor2.Name = "lblActor2";
            this.lblActor2.Size = new System.Drawing.Size(0, 17);
            this.lblActor2.TabIndex = 9;
            // 
            // lblTSold2
            // 
            this.lblTSold2.AutoSize = true;
            this.lblTSold2.Location = new System.Drawing.Point(184, 410);
            this.lblTSold2.Name = "lblTSold2";
            this.lblTSold2.Size = new System.Drawing.Size(0, 17);
            this.lblTSold2.TabIndex = 10;
            // 
            // txtMid
            // 
            this.txtMid.Location = new System.Drawing.Point(217, 273);
            this.txtMid.Name = "txtMid";
            this.txtMid.Size = new System.Drawing.Size(100, 22);
            this.txtMid.TabIndex = 11;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(439, 319);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(100, 22);
            this.txtMName.TabIndex = 12;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(439, 362);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(100, 22);
            this.txtActor.TabIndex = 13;
            // 
            // txtTsold
            // 
            this.txtTsold.Location = new System.Drawing.Point(439, 405);
            this.txtTsold.Name = "txtTsold";
            this.txtTsold.Size = new System.Drawing.Size(100, 22);
            this.txtTsold.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTsold);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtMid);
            this.Controls.Add(this.lblTSold2);
            this.Controls.Add(this.lblActor2);
            this.Controls.Add(this.lblMName2);
            this.Controls.Add(this.lblTSold1);
            this.Controls.Add(this.lblActor1);
            this.Controls.Add(this.lblMName1);
            this.Controls.Add(this.lblMId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnShowMovie);
            this.Controls.Add(this.btnShowMovieDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowMovieDetails;
        private System.Windows.Forms.Button btnShowMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMId;
        private System.Windows.Forms.Label lblMName1;
        private System.Windows.Forms.Label lblActor1;
        private System.Windows.Forms.Label lblTSold1;
        private System.Windows.Forms.Label lblMName2;
        private System.Windows.Forms.Label lblActor2;
        private System.Windows.Forms.Label lblTSold2;
        private System.Windows.Forms.TextBox txtMid;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.TextBox txtTsold;
    }
}

