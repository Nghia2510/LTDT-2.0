﻿namespace LTDT_2._0
{
    partial class MainForm
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
            this.Toolpanel = new System.Windows.Forms.Panel();
            this.ThuatToangrpbox = new System.Windows.Forms.GroupBox();
            this.Dijkstrarbt = new System.Windows.Forms.RadioButton();
            this.Primrbt = new System.Windows.Forms.RadioButton();
            this.Toolgrpbox = new System.Windows.Forms.GroupBox();
            this.TaoDinhbtn = new System.Windows.Forms.Button();
            this.RunSpeed = new System.Windows.Forms.TrackBar();
            this.ChayThuatToanbtn = new System.Windows.Forms.Button();
            this.Newbtn = new System.Windows.Forms.Button();
            this.Movebtn = new System.Windows.Forms.Button();
            this.XemMaTranbtn = new System.Windows.Forms.Button();
            this.TaoDuongDibtn = new System.Windows.Forms.Button();
            this.Listviewpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.runspeedlabel = new System.Windows.Forms.Label();
            this.Dijkstrapanelselect = new System.Windows.Forms.Panel();
            this.CancelDijbtn = new System.Windows.Forms.Button();
            this.Chaydijbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dij2cbx = new System.Windows.Forms.ComboBox();
            this.Dij1cbx = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.MaTranLV = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Toolpanel.SuspendLayout();
            this.ThuatToangrpbox.SuspendLayout();
            this.Toolgrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunSpeed)).BeginInit();
            this.Listviewpanel.SuspendLayout();
            this.Dijkstrapanelselect.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolpanel
            // 
            this.Toolpanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Toolpanel.Controls.Add(this.ThuatToangrpbox);
            this.Toolpanel.Location = new System.Drawing.Point(0, 4);
            this.Toolpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Toolpanel.Name = "Toolpanel";
            this.Toolpanel.Size = new System.Drawing.Size(273, 109);
            this.Toolpanel.TabIndex = 0;
            // 
            // ThuatToangrpbox
            // 
            this.ThuatToangrpbox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ThuatToangrpbox.Controls.Add(this.Dijkstrarbt);
            this.ThuatToangrpbox.Controls.Add(this.Primrbt);
            this.ThuatToangrpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThuatToangrpbox.Location = new System.Drawing.Point(25, 13);
            this.ThuatToangrpbox.Margin = new System.Windows.Forms.Padding(4);
            this.ThuatToangrpbox.Name = "ThuatToangrpbox";
            this.ThuatToangrpbox.Padding = new System.Windows.Forms.Padding(4);
            this.ThuatToangrpbox.Size = new System.Drawing.Size(228, 97);
            this.ThuatToangrpbox.TabIndex = 0;
            this.ThuatToangrpbox.TabStop = false;
            this.ThuatToangrpbox.Text = "Thuật toán";
            // 
            // Dijkstrarbt
            // 
            this.Dijkstrarbt.AutoSize = true;
            this.Dijkstrarbt.Location = new System.Drawing.Point(109, 42);
            this.Dijkstrarbt.Margin = new System.Windows.Forms.Padding(4);
            this.Dijkstrarbt.Name = "Dijkstrarbt";
            this.Dijkstrarbt.Size = new System.Drawing.Size(97, 29);
            this.Dijkstrarbt.TabIndex = 2;
            this.Dijkstrarbt.Text = "Dijkstra";
            this.Dijkstrarbt.UseVisualStyleBackColor = true;
            this.Dijkstrarbt.CheckedChanged += new System.EventHandler(this.Dijkstrarbt_CheckedChanged);
            // 
            // Primrbt
            // 
            this.Primrbt.AutoSize = true;
            this.Primrbt.Checked = true;
            this.Primrbt.Location = new System.Drawing.Point(8, 42);
            this.Primrbt.Margin = new System.Windows.Forms.Padding(4);
            this.Primrbt.Name = "Primrbt";
            this.Primrbt.Size = new System.Drawing.Size(72, 29);
            this.Primrbt.TabIndex = 1;
            this.Primrbt.TabStop = true;
            this.Primrbt.Text = "Prim";
            this.Primrbt.UseVisualStyleBackColor = true;
            this.Primrbt.CheckedChanged += new System.EventHandler(this.Primrbt_CheckedChanged);
            // 
            // Toolgrpbox
            // 
            this.Toolgrpbox.Controls.Add(this.TaoDinhbtn);
            this.Toolgrpbox.Controls.Add(this.RunSpeed);
            this.Toolgrpbox.Controls.Add(this.ChayThuatToanbtn);
            this.Toolgrpbox.Controls.Add(this.Newbtn);
            this.Toolgrpbox.Controls.Add(this.Movebtn);
            this.Toolgrpbox.Controls.Add(this.XemMaTranbtn);
            this.Toolgrpbox.Controls.Add(this.TaoDuongDibtn);
            this.Toolgrpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toolgrpbox.Location = new System.Drawing.Point(6, 4);
            this.Toolgrpbox.Margin = new System.Windows.Forms.Padding(4);
            this.Toolgrpbox.Name = "Toolgrpbox";
            this.Toolgrpbox.Padding = new System.Windows.Forms.Padding(4);
            this.Toolgrpbox.Size = new System.Drawing.Size(1146, 105);
            this.Toolgrpbox.TabIndex = 1;
            this.Toolgrpbox.TabStop = false;
            this.Toolgrpbox.Text = "Chức năng";
            // 
            // TaoDinhbtn
            // 
            this.TaoDinhbtn.BackColor = System.Drawing.Color.White;
            this.TaoDinhbtn.FlatAppearance.BorderSize = 0;
            this.TaoDinhbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaoDinhbtn.Image = global::LTDT_2._0.Properties.Resources.dinh2;
            this.TaoDinhbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaoDinhbtn.Location = new System.Drawing.Point(8, 27);
            this.TaoDinhbtn.Margin = new System.Windows.Forms.Padding(4);
            this.TaoDinhbtn.Name = "TaoDinhbtn";
            this.TaoDinhbtn.Size = new System.Drawing.Size(130, 62);
            this.TaoDinhbtn.TabIndex = 3;
            this.TaoDinhbtn.Text = "Tạo đỉnh";
            this.TaoDinhbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaoDinhbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TaoDinhbtn.UseVisualStyleBackColor = false;
            this.TaoDinhbtn.Click += new System.EventHandler(this.TaoDinhbtn_Click);
            // 
            // RunSpeed
            // 
            this.RunSpeed.Location = new System.Drawing.Point(978, 27);
            this.RunSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.RunSpeed.Maximum = 3000;
            this.RunSpeed.Minimum = 100;
            this.RunSpeed.Name = "RunSpeed";
            this.RunSpeed.Size = new System.Drawing.Size(159, 56);
            this.RunSpeed.SmallChange = 100;
            this.RunSpeed.TabIndex = 2;
            this.RunSpeed.TabStop = false;
            this.RunSpeed.TickFrequency = 20;
            this.RunSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.RunSpeed.Value = 100;
            this.RunSpeed.Scroll += new System.EventHandler(this.RunSpeed_Scroll);
            // 
            // ChayThuatToanbtn
            // 
            this.ChayThuatToanbtn.BackColor = System.Drawing.Color.White;
            this.ChayThuatToanbtn.FlatAppearance.BorderSize = 0;
            this.ChayThuatToanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChayThuatToanbtn.Image = global::LTDT_2._0.Properties.Resources.chay;
            this.ChayThuatToanbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChayThuatToanbtn.Location = new System.Drawing.Point(498, 27);
            this.ChayThuatToanbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChayThuatToanbtn.Name = "ChayThuatToanbtn";
            this.ChayThuatToanbtn.Size = new System.Drawing.Size(155, 62);
            this.ChayThuatToanbtn.TabIndex = 6;
            this.ChayThuatToanbtn.Text = "Chạy thuật toán";
            this.ChayThuatToanbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChayThuatToanbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChayThuatToanbtn.UseVisualStyleBackColor = false;
            this.ChayThuatToanbtn.Click += new System.EventHandler(this.ChayThuatToanbtn_Click);
            // 
            // Newbtn
            // 
            this.Newbtn.BackColor = System.Drawing.Color.White;
            this.Newbtn.FlatAppearance.BorderSize = 0;
            this.Newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newbtn.Image = global::LTDT_2._0.Properties.Resources.khoidong;
            this.Newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Newbtn.Location = new System.Drawing.Point(661, 27);
            this.Newbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(131, 62);
            this.Newbtn.TabIndex = 3;
            this.Newbtn.Text = "Làm mới";
            this.Newbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Newbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Newbtn.UseVisualStyleBackColor = false;
            this.Newbtn.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // Movebtn
            // 
            this.Movebtn.BackColor = System.Drawing.Color.White;
            this.Movebtn.FlatAppearance.BorderSize = 0;
            this.Movebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movebtn.Image = global::LTDT_2._0.Properties.Resources.dichuyen;
            this.Movebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Movebtn.Location = new System.Drawing.Point(800, 27);
            this.Movebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Movebtn.Name = "Movebtn";
            this.Movebtn.Size = new System.Drawing.Size(170, 62);
            this.Movebtn.TabIndex = 3;
            this.Movebtn.Text = "Di chuyển đỉnh";
            this.Movebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Movebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Movebtn.UseVisualStyleBackColor = false;
            this.Movebtn.Click += new System.EventHandler(this.Movebtn_Click);
            // 
            // XemMaTranbtn
            // 
            this.XemMaTranbtn.BackColor = System.Drawing.Color.White;
            this.XemMaTranbtn.FlatAppearance.BorderSize = 0;
            this.XemMaTranbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XemMaTranbtn.Image = global::LTDT_2._0.Properties.Resources.xem;
            this.XemMaTranbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XemMaTranbtn.Location = new System.Drawing.Point(327, 27);
            this.XemMaTranbtn.Margin = new System.Windows.Forms.Padding(4);
            this.XemMaTranbtn.Name = "XemMaTranbtn";
            this.XemMaTranbtn.Size = new System.Drawing.Size(163, 62);
            this.XemMaTranbtn.TabIndex = 5;
            this.XemMaTranbtn.Text = "Xem ma trận";
            this.XemMaTranbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XemMaTranbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XemMaTranbtn.UseVisualStyleBackColor = false;
            this.XemMaTranbtn.Click += new System.EventHandler(this.XemMaTranbtn_Click);
            // 
            // TaoDuongDibtn
            // 
            this.TaoDuongDibtn.BackColor = System.Drawing.Color.White;
            this.TaoDuongDibtn.FlatAppearance.BorderSize = 0;
            this.TaoDuongDibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaoDuongDibtn.Image = global::LTDT_2._0.Properties.Resources.đường_đi;
            this.TaoDuongDibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaoDuongDibtn.Location = new System.Drawing.Point(146, 27);
            this.TaoDuongDibtn.Margin = new System.Windows.Forms.Padding(4);
            this.TaoDuongDibtn.Name = "TaoDuongDibtn";
            this.TaoDuongDibtn.Size = new System.Drawing.Size(173, 62);
            this.TaoDuongDibtn.TabIndex = 4;
            this.TaoDuongDibtn.Text = "Tạo đường đi";
            this.TaoDuongDibtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaoDuongDibtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TaoDuongDibtn.UseVisualStyleBackColor = false;
            this.TaoDuongDibtn.Click += new System.EventHandler(this.TaoDuongDibtn_Click);
            // 
            // Listviewpanel
            // 
            this.Listviewpanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Listviewpanel.Controls.Add(this.label4);
            this.Listviewpanel.Controls.Add(this.runspeedlabel);
            this.Listviewpanel.Controls.Add(this.Dijkstrapanelselect);
            this.Listviewpanel.Controls.Add(this.Result);
            this.Listviewpanel.Controls.Add(this.MaTranLV);
            this.Listviewpanel.Controls.Add(this.Toolpanel);
            this.Listviewpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Listviewpanel.Location = new System.Drawing.Point(0, 0);
            this.Listviewpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Listviewpanel.Name = "Listviewpanel";
            this.Listviewpanel.Size = new System.Drawing.Size(273, 731);
            this.Listviewpanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tốc độ chạy của thuật toán";
            // 
            // runspeedlabel
            // 
            this.runspeedlabel.AutoSize = true;
            this.runspeedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runspeedlabel.Location = new System.Drawing.Point(74, 421);
            this.runspeedlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.runspeedlabel.Name = "runspeedlabel";
            this.runspeedlabel.Size = new System.Drawing.Size(100, 20);
            this.runspeedlabel.TabIndex = 15;
            this.runspeedlabel.Text = "Tốc độ chạy";
            // 
            // Dijkstrapanelselect
            // 
            this.Dijkstrapanelselect.BackColor = System.Drawing.Color.FloralWhite;
            this.Dijkstrapanelselect.Controls.Add(this.CancelDijbtn);
            this.Dijkstrapanelselect.Controls.Add(this.Chaydijbtn);
            this.Dijkstrapanelselect.Controls.Add(this.label3);
            this.Dijkstrapanelselect.Controls.Add(this.label2);
            this.Dijkstrapanelselect.Controls.Add(this.label1);
            this.Dijkstrapanelselect.Controls.Add(this.Dij2cbx);
            this.Dijkstrapanelselect.Controls.Add(this.Dij1cbx);
            this.Dijkstrapanelselect.Location = new System.Drawing.Point(1, 264);
            this.Dijkstrapanelselect.Margin = new System.Windows.Forms.Padding(4);
            this.Dijkstrapanelselect.Name = "Dijkstrapanelselect";
            this.Dijkstrapanelselect.Size = new System.Drawing.Size(272, 133);
            this.Dijkstrapanelselect.TabIndex = 3;
            this.Dijkstrapanelselect.Visible = false;
            // 
            // CancelDijbtn
            // 
            this.CancelDijbtn.Location = new System.Drawing.Point(148, 92);
            this.CancelDijbtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelDijbtn.Name = "CancelDijbtn";
            this.CancelDijbtn.Size = new System.Drawing.Size(84, 33);
            this.CancelDijbtn.TabIndex = 11;
            this.CancelDijbtn.Text = "Huỷ";
            this.CancelDijbtn.UseVisualStyleBackColor = true;
            this.CancelDijbtn.Click += new System.EventHandler(this.CancelDijbtn_Click);
            // 
            // Chaydijbtn
            // 
            this.Chaydijbtn.Location = new System.Drawing.Point(24, 92);
            this.Chaydijbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Chaydijbtn.Name = "Chaydijbtn";
            this.Chaydijbtn.Size = new System.Drawing.Size(84, 33);
            this.Chaydijbtn.TabIndex = 10;
            this.Chaydijbtn.Text = "Chạy";
            this.Chaydijbtn.UseVisualStyleBackColor = true;
            this.Chaydijbtn.Click += new System.EventHandler(this.Chaydijbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dijkstra";
            // 
            // Dij2cbx
            // 
            this.Dij2cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dij2cbx.FormattingEnabled = true;
            this.Dij2cbx.Location = new System.Drawing.Point(160, 50);
            this.Dij2cbx.Margin = new System.Windows.Forms.Padding(4);
            this.Dij2cbx.Name = "Dij2cbx";
            this.Dij2cbx.Size = new System.Drawing.Size(52, 24);
            this.Dij2cbx.TabIndex = 9;
            this.Dij2cbx.SelectedIndexChanged += new System.EventHandler(this.Dij2cbx_SelectedIndexChanged);
            // 
            // Dij1cbx
            // 
            this.Dij1cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dij1cbx.FormattingEnabled = true;
            this.Dij1cbx.Location = new System.Drawing.Point(51, 50);
            this.Dij1cbx.Margin = new System.Windows.Forms.Padding(4);
            this.Dij1cbx.Name = "Dij1cbx";
            this.Dij1cbx.Size = new System.Drawing.Size(52, 24);
            this.Dij1cbx.TabIndex = 8;
            this.Dij1cbx.SelectedIndexChanged += new System.EventHandler(this.Dij1cbx_SelectedIndexChanged);
            // 
            // Result
            // 
            this.Result.AllowDrop = true;
            this.Result.BackColor = System.Drawing.Color.FloralWhite;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(1, 483);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(272, 134);
            this.Result.TabIndex = 7;
            // 
            // MaTranLV
            // 
            this.MaTranLV.GridLines = true;
            this.MaTranLV.HideSelection = false;
            this.MaTranLV.Location = new System.Drawing.Point(0, 111);
            this.MaTranLV.Margin = new System.Windows.Forms.Padding(4);
            this.MaTranLV.Name = "MaTranLV";
            this.MaTranLV.Size = new System.Drawing.Size(272, 156);
            this.MaTranLV.TabIndex = 0;
            this.MaTranLV.TabStop = false;
            this.MaTranLV.UseCompatibleStateImageBehavior = false;
            this.MaTranLV.View = System.Windows.Forms.View.Details;
            this.MaTranLV.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.Toolgrpbox);
            this.panel1.Location = new System.Drawing.Point(275, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 110);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1438, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Listviewpanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "CTQM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Toolpanel.ResumeLayout(false);
            this.ThuatToangrpbox.ResumeLayout(false);
            this.ThuatToangrpbox.PerformLayout();
            this.Toolgrpbox.ResumeLayout(false);
            this.Toolgrpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunSpeed)).EndInit();
            this.Listviewpanel.ResumeLayout(false);
            this.Listviewpanel.PerformLayout();
            this.Dijkstrapanelselect.ResumeLayout(false);
            this.Dijkstrapanelselect.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toolpanel;
        private System.Windows.Forms.GroupBox ThuatToangrpbox;
        private System.Windows.Forms.GroupBox Toolgrpbox;
        private System.Windows.Forms.RadioButton Dijkstrarbt;
        private System.Windows.Forms.RadioButton Primrbt;
        private System.Windows.Forms.Button TaoDinhbtn;
        private System.Windows.Forms.Button TaoDuongDibtn;
        private System.Windows.Forms.Button XemMaTranbtn;
        private System.Windows.Forms.Button ChayThuatToanbtn;
        private System.Windows.Forms.Panel Listviewpanel;
        private System.Windows.Forms.ListView MaTranLV;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Panel Dijkstrapanelselect;
        private System.Windows.Forms.Button CancelDijbtn;
        private System.Windows.Forms.Button Chaydijbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Dij2cbx;
        private System.Windows.Forms.ComboBox Dij1cbx;
        private System.Windows.Forms.TrackBar RunSpeed;
        private System.Windows.Forms.Label runspeedlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Newbtn;
        private System.Windows.Forms.Button Movebtn;
        private System.Windows.Forms.Panel panel1;
    }
}

