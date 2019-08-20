namespace WindowsFormsApp
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ip_input = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.start_adb_btn = new System.Windows.Forms.Button();
            this.out_lable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.23474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.76526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.ip_input, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.connect_btn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.start_adb_btn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // ip_input
            // 
            this.ip_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ip_input.Location = new System.Drawing.Point(109, 61);
            this.ip_input.Name = "ip_input";
            this.ip_input.Size = new System.Drawing.Size(99, 20);
            this.ip_input.TabIndex = 2;
            // 
            // connect_btn
            // 
            this.connect_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.connect_btn.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connect_btn.Location = new System.Drawing.Point(214, 59);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 3;
            this.connect_btn.Text = "connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ip:";
            // 
            // start_adb_btn
            // 
            this.start_adb_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start_adb_btn.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_adb_btn.Location = new System.Drawing.Point(121, 12);
            this.start_adb_btn.Name = "start_adb_btn";
            this.start_adb_btn.Size = new System.Drawing.Size(75, 23);
            this.start_adb_btn.TabIndex = 0;
            this.start_adb_btn.Text = "start adb";
            this.start_adb_btn.UseVisualStyleBackColor = true;
            this.start_adb_btn.Click += new System.EventHandler(this.Start_adb_btn_Click);
            // 
            // out_lable
            // 
            this.out_lable.AutoSize = true;
            this.out_lable.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_lable.Location = new System.Drawing.Point(19, 149);
            this.out_lable.Name = "out_lable";
            this.out_lable.Size = new System.Drawing.Size(0, 16);
            this.out_lable.TabIndex = 4;
            this.out_lable.Click += new System.EventHandler(this.Out_lable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wifi ADB";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.out_lable);
            this.Name = "MainWindow";
            this.Text = "Wifi adb";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ip_input;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_adb_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label out_lable;
    }
}

