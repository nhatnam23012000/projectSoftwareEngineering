namespace SFCS
{
    partial class Cook
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUpdateState = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.vbOrderInfo = new System.Windows.Forms.ListView();
            this.foodID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNotification = new System.Windows.Forms.Label();
            this.vbOrderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cbSearchName = new System.Windows.Forms.ComboBox();
            this.lbList = new System.Windows.Forms.ListBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblStateNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(292, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(95, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Cook";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome, ";
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewOrder.Location = new System.Drawing.Point(12, 85);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(134, 49);
            this.btnViewOrder.TabIndex = 5;
            this.btnViewOrder.Text = "Xem thông tin đơn hàng";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 388);
            this.listBox1.TabIndex = 6;
            // 
            // btnUpdateState
            // 
            this.btnUpdateState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateState.Location = new System.Drawing.Point(152, 85);
            this.btnUpdateState.Name = "btnUpdateState";
            this.btnUpdateState.Size = new System.Drawing.Size(148, 49);
            this.btnUpdateState.TabIndex = 7;
            this.btnUpdateState.Text = "Cập nhật trạng thái đơn hàng";
            this.btnUpdateState.UseVisualStyleBackColor = true;
            this.btnUpdateState.Click += new System.EventHandler(this.btnUpdateState_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(223, 178);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 17);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Nhập tên khách hàng";
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Location = new System.Drawing.Point(226, 228);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(62, 28);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // vbOrderInfo
            // 
            this.vbOrderInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodID,
            this.foodName,
            this.foodNum});
            this.vbOrderInfo.HideSelection = false;
            this.vbOrderInfo.Location = new System.Drawing.Point(23, 372);
            this.vbOrderInfo.Name = "vbOrderInfo";
            this.vbOrderInfo.Size = new System.Drawing.Size(373, 137);
            this.vbOrderInfo.TabIndex = 25;
            this.vbOrderInfo.UseCompatibleStateImageBehavior = false;
            this.vbOrderInfo.View = System.Windows.Forms.View.Details;
            // 
            // foodID
            // 
            this.foodID.Tag = "";
            this.foodID.Text = "Mã món ăn";
            this.foodID.Width = 100;
            // 
            // foodName
            // 
            this.foodName.Tag = "";
            this.foodName.Text = "Tên món ăn";
            this.foodName.Width = 100;
            // 
            // foodNum
            // 
            this.foodNum.Text = "Số lượng";
            this.foodNum.Width = 80;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.White;
            this.lblNotification.Location = new System.Drawing.Point(223, 268);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(38, 17);
            this.lblNotification.TabIndex = 26;
            this.lblNotification.Text = "label";
            // 
            // vbOrderList
            // 
            this.vbOrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.vbOrderList.HideSelection = false;
            this.vbOrderList.Location = new System.Drawing.Point(33, 198);
            this.vbOrderList.Name = "vbOrderList";
            this.vbOrderList.Size = new System.Drawing.Size(175, 117);
            this.vbOrderList.TabIndex = 27;
            this.vbOrderList.UseCompatibleStateImageBehavior = false;
            this.vbOrderList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Tên khách hàng";
            this.columnHeader1.Width = 200;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(20, 352);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(150, 17);
            this.lbl3.TabIndex = 28;
            this.lbl3.Text = "Thông tin đơn hàng";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(30, 178);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(158, 17);
            this.lbl2.TabIndex = 29;
            this.lbl2.Text = "Danh sách đơn hàng";
            // 
            // cbSearchName
            // 
            this.cbSearchName.FormattingEnabled = true;
            this.cbSearchName.Location = new System.Drawing.Point(226, 198);
            this.cbSearchName.Name = "cbSearchName";
            this.cbSearchName.Size = new System.Drawing.Size(150, 24);
            this.cbSearchName.TabIndex = 30;
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 16;
            this.lbList.Location = new System.Drawing.Point(23, 157);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(373, 180);
            this.lbList.TabIndex = 31;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(20, 352);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(221, 17);
            this.lbl4.TabIndex = 32;
            this.lbl4.Text = "Cập nhật trạng thái đơn hàng";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(44, 381);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(131, 17);
            this.lbl5.TabIndex = 33;
            this.lbl5.Text = "Trạng thái hiện tại: ";
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.BackColor = System.Drawing.Color.White;
            this.lblCurrentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentState.Location = new System.Drawing.Point(202, 381);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(28, 17);
            this.lblCurrentState.TabIndex = 34;
            this.lblCurrentState.Text = "TT";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(44, 410);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(155, 17);
            this.lbl6.TabIndex = 35;
            this.lbl6.Text = "Cập nhật trạng thái mới";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "WAITING",
            "DOING",
            "READY"});
            this.cbState.Location = new System.Drawing.Point(205, 407);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(150, 24);
            this.cbState.TabIndex = 36;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(205, 437);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 28);
            this.btnOK.TabIndex = 37;
            this.btnOK.Text = "Xác nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblStateNotification
            // 
            this.lblStateNotification.AutoSize = true;
            this.lblStateNotification.BackColor = System.Drawing.Color.White;
            this.lblStateNotification.Location = new System.Drawing.Point(175, 477);
            this.lblStateNotification.Name = "lblStateNotification";
            this.lblStateNotification.Size = new System.Drawing.Size(33, 17);
            this.lblStateNotification.TabIndex = 38;
            this.lblStateNotification.Text = "Noti";
            // 
            // Cook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(418, 547);
            this.Controls.Add(this.lblStateNotification);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblCurrentState);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cbSearchName);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.vbOrderList);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.vbOrderInfo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnUpdateState);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cook";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnUpdateState;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListView vbOrderInfo;
        private System.Windows.Forms.ColumnHeader foodID;
        private System.Windows.Forms.ColumnHeader foodName;
        private System.Windows.Forms.ColumnHeader foodNum;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.ListView vbOrderList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cbSearchName;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblStateNotification;
    }
}