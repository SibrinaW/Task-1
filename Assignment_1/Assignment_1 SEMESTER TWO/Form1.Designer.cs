namespace Assignment_1_SEMESTER_TWO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.min_lbl = new System.Windows.Forms.Label();
            this.second_lbl = new System.Windows.Forms.Label();
            this.mili_lbl = new System.Windows.Forms.Label();
            this.colon_lbl = new System.Windows.Forms.Label();
            this.fullstop_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.TableLayoutPanel();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.melee_lbl = new System.Windows.Forms.Label();
            this.range_lbl = new System.Windows.Forms.Label();
            this.info_txb = new System.Windows.Forms.TextBox();
            this.unitInfo_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nano_lbl = new System.Windows.Forms.Label();
            this.nano_pic = new System.Windows.Forms.PictureBox();
            this.titan_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nano_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titan_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // min_lbl
            // 
            this.min_lbl.AutoSize = true;
            this.min_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_lbl.Location = new System.Drawing.Point(1035, 63);
            this.min_lbl.Name = "min_lbl";
            this.min_lbl.Size = new System.Drawing.Size(81, 58);
            this.min_lbl.TabIndex = 0;
            this.min_lbl.Text = "00";
            this.min_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // second_lbl
            // 
            this.second_lbl.AutoSize = true;
            this.second_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_lbl.Location = new System.Drawing.Point(1131, 63);
            this.second_lbl.Name = "second_lbl";
            this.second_lbl.Size = new System.Drawing.Size(81, 58);
            this.second_lbl.TabIndex = 1;
            this.second_lbl.Text = "00";
            // 
            // mili_lbl
            // 
            this.mili_lbl.AutoSize = true;
            this.mili_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mili_lbl.Location = new System.Drawing.Point(1218, 86);
            this.mili_lbl.Name = "mili_lbl";
            this.mili_lbl.Size = new System.Drawing.Size(41, 29);
            this.mili_lbl.TabIndex = 2;
            this.mili_lbl.Text = "00";
            // 
            // colon_lbl
            // 
            this.colon_lbl.AutoSize = true;
            this.colon_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon_lbl.Location = new System.Drawing.Point(1104, 63);
            this.colon_lbl.Name = "colon_lbl";
            this.colon_lbl.Size = new System.Drawing.Size(39, 58);
            this.colon_lbl.TabIndex = 3;
            this.colon_lbl.Text = ":";
            // 
            // fullstop_lbl
            // 
            this.fullstop_lbl.AutoSize = true;
            this.fullstop_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullstop_lbl.Location = new System.Drawing.Point(1202, 86);
            this.fullstop_lbl.Name = "fullstop_lbl";
            this.fullstop_lbl.Size = new System.Drawing.Size(20, 29);
            this.fullstop_lbl.TabIndex = 5;
            this.fullstop_lbl.Text = ".";
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(1045, 124);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(79, 36);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(1130, 124);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(79, 36);
            this.stop_btn.TabIndex = 7;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(1215, 124);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(79, 36);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnCount = 20;
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.Grid.Location = new System.Drawing.Point(12, 9);
            this.Grid.Name = "Grid";
            this.Grid.RowCount = 20;
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.Size = new System.Drawing.Size(1003, 1021);
            this.Grid.TabIndex = 9;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Font = new System.Drawing.Font("Hobo Std", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_lbl.Location = new System.Drawing.Point(1038, 11);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(96, 47);
            this.timer_lbl.TabIndex = 10;
            this.timer_lbl.Text = "Time";
            // 
            // melee_lbl
            // 
            this.melee_lbl.AutoSize = true;
            this.melee_lbl.Font = new System.Drawing.Font("Hobo Std", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melee_lbl.Location = new System.Drawing.Point(1672, 71);
            this.melee_lbl.Name = "melee_lbl";
            this.melee_lbl.Size = new System.Drawing.Size(92, 24);
            this.melee_lbl.TabIndex = 12;
            this.melee_lbl.Text = "Melee Unit";
            this.melee_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // range_lbl
            // 
            this.range_lbl.AutoSize = true;
            this.range_lbl.Font = new System.Drawing.Font("Hobo Std", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_lbl.Location = new System.Drawing.Point(1672, 232);
            this.range_lbl.Name = "range_lbl";
            this.range_lbl.Size = new System.Drawing.Size(93, 24);
            this.range_lbl.TabIndex = 13;
            this.range_lbl.Text = "Range Unit";
            this.range_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // info_txb
            // 
            this.info_txb.Location = new System.Drawing.Point(1623, 364);
            this.info_txb.Multiline = true;
            this.info_txb.Name = "info_txb";
            this.info_txb.Size = new System.Drawing.Size(267, 113);
            this.info_txb.TabIndex = 15;
            // 
            // unitInfo_lbl
            // 
            this.unitInfo_lbl.AutoSize = true;
            this.unitInfo_lbl.Font = new System.Drawing.Font("Hobo Std", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitInfo_lbl.Location = new System.Drawing.Point(1617, 312);
            this.unitInfo_lbl.Name = "unitInfo_lbl";
            this.unitInfo_lbl.Size = new System.Drawing.Size(273, 48);
            this.unitInfo_lbl.TabIndex = 16;
            this.unitInfo_lbl.Text = "Unit Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1860, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hobo Std", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1765, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Titans";
            // 
            // nano_lbl
            // 
            this.nano_lbl.AutoSize = true;
            this.nano_lbl.Font = new System.Drawing.Font("Hobo Std", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nano_lbl.Location = new System.Drawing.Point(1766, 174);
            this.nano_lbl.Name = "nano_lbl";
            this.nano_lbl.Size = new System.Drawing.Size(70, 20);
            this.nano_lbl.TabIndex = 19;
            this.nano_lbl.Text = "Nanobots";
            // 
            // nano_pic
            // 
            this.nano_pic.Image = ((System.Drawing.Image)(resources.GetObject("nano_pic.Image")));
            this.nano_pic.Location = new System.Drawing.Point(1770, 197);
            this.nano_pic.Name = "nano_pic";
            this.nano_pic.Size = new System.Drawing.Size(120, 99);
            this.nano_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nano_pic.TabIndex = 14;
            this.nano_pic.TabStop = false;
            this.nano_pic.Click += new System.EventHandler(this.nano_pic_Click);
            // 
            // titan_pic
            // 
            this.titan_pic.Image = ((System.Drawing.Image)(resources.GetObject("titan_pic.Image")));
            this.titan_pic.Location = new System.Drawing.Point(1770, 31);
            this.titan_pic.Name = "titan_pic";
            this.titan_pic.Size = new System.Drawing.Size(120, 104);
            this.titan_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titan_pic.TabIndex = 11;
            this.titan_pic.TabStop = false;
            this.titan_pic.Click += new System.EventHandler(this.titan_pic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.nano_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unitInfo_lbl);
            this.Controls.Add(this.info_txb);
            this.Controls.Add(this.nano_pic);
            this.Controls.Add(this.range_lbl);
            this.Controls.Add(this.melee_lbl);
            this.Controls.Add(this.titan_pic);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.fullstop_lbl);
            this.Controls.Add(this.colon_lbl);
            this.Controls.Add(this.mili_lbl);
            this.Controls.Add(this.second_lbl);
            this.Controls.Add(this.min_lbl);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nano_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titan_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label min_lbl;
        private System.Windows.Forms.Label second_lbl;
        private System.Windows.Forms.Label mili_lbl;
        private System.Windows.Forms.Label colon_lbl;
        private System.Windows.Forms.Label fullstop_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.TableLayoutPanel Grid;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.PictureBox titan_pic;
        private System.Windows.Forms.Label melee_lbl;
        private System.Windows.Forms.Label range_lbl;
        private System.Windows.Forms.PictureBox nano_pic;
        private System.Windows.Forms.Label unitInfo_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nano_lbl;
        public System.Windows.Forms.TextBox info_txb;
    }
}

