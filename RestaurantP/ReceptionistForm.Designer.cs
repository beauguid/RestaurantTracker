namespace RestaurantP
{
    partial class ReceptionistForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnVOrders = new System.Windows.Forms.Button();
            this.tlpReceptionist = new System.Windows.Forms.TableLayoutPanel();
            this.tcOptions = new System.Windows.Forms.TabControl();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.tbMenu = new System.Windows.Forms.TabPage();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.tlpMakeOrder = new System.Windows.Forms.TableLayoutPanel();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tlpItemnInfo = new System.Windows.Forms.TableLayoutPanel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblOrderN = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.tlpReceptionist.SuspendLayout();
            this.tcOptions.SuspendLayout();
            this.tbMenu.SuspendLayout();
            this.tlpMakeOrder.SuspendLayout();
            this.tlpItemnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(788, 490);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 32);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(2, 0);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(59, 22);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(799, 0);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(585, 217);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(261, 150);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Make an Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnVOrders
            // 
            this.btnVOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOrders.Location = new System.Drawing.Point(585, 63);
            this.btnVOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnVOrders.Name = "btnVOrders";
            this.btnVOrders.Size = new System.Drawing.Size(261, 150);
            this.btnVOrders.TabIndex = 4;
            this.btnVOrders.Text = "View Orders";
            this.btnVOrders.UseVisualStyleBackColor = true;
            this.btnVOrders.Click += new System.EventHandler(this.btnVOrders_Click);
            // 
            // tlpReceptionist
            // 
            this.tlpReceptionist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpReceptionist.ColumnCount = 3;
            this.tlpReceptionist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpReceptionist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpReceptionist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpReceptionist.Controls.Add(this.lblInfo, 0, 0);
            this.tlpReceptionist.Controls.Add(this.btnVOrders, 2, 1);
            this.tlpReceptionist.Controls.Add(this.lblDate, 2, 0);
            this.tlpReceptionist.Controls.Add(this.btnLogout, 2, 3);
            this.tlpReceptionist.Controls.Add(this.tcOptions, 0, 1);
            this.tlpReceptionist.Controls.Add(this.btnOrder, 2, 2);
            this.tlpReceptionist.Location = new System.Drawing.Point(9, 17);
            this.tlpReceptionist.Margin = new System.Windows.Forms.Padding(2);
            this.tlpReceptionist.Name = "tlpReceptionist";
            this.tlpReceptionist.RowCount = 4;
            this.tlpReceptionist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tlpReceptionist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tlpReceptionist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tlpReceptionist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tlpReceptionist.Size = new System.Drawing.Size(860, 524);
            this.tlpReceptionist.TabIndex = 5;
            // 
            // tcOptions
            // 
            this.tcOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpReceptionist.SetColumnSpan(this.tcOptions, 2);
            this.tcOptions.Controls.Add(this.tbInfo);
            this.tcOptions.Controls.Add(this.tbMenu);
            this.tcOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcOptions.Location = new System.Drawing.Point(2, 63);
            this.tcOptions.Margin = new System.Windows.Forms.Padding(2);
            this.tcOptions.Name = "tcOptions";
            this.tlpReceptionist.SetRowSpan(this.tcOptions, 3);
            this.tcOptions.SelectedIndex = 0;
            this.tcOptions.Size = new System.Drawing.Size(568, 459);
            this.tcOptions.TabIndex = 5;
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(4, 29);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tbInfo.Size = new System.Drawing.Size(560, 426);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "Information";
            this.tbInfo.UseVisualStyleBackColor = true;
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.lbMenu);
            this.tbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenu.Location = new System.Drawing.Point(4, 29);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Padding = new System.Windows.Forms.Padding(2);
            this.tbMenu.Size = new System.Drawing.Size(560, 426);
            this.tbMenu.TabIndex = 1;
            this.tbMenu.Text = "Menu";
            this.tbMenu.UseVisualStyleBackColor = true;
            // 
            // lbMenu
            // 
            this.lbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 29;
            this.lbMenu.Location = new System.Drawing.Point(2, 2);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(2);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(556, 422);
            this.lbMenu.TabIndex = 0;
            // 
            // tlpMakeOrder
            // 
            this.tlpMakeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMakeOrder.ColumnCount = 7;
            this.tlpMakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMakeOrder.Controls.Add(this.lbOrder, 5, 1);
            this.tlpMakeOrder.Controls.Add(this.btnBack, 6, 3);
            this.tlpMakeOrder.Controls.Add(this.btnCheckOut, 5, 3);
            this.tlpMakeOrder.Controls.Add(this.tlpItemnInfo, 5, 2);
            this.tlpMakeOrder.Controls.Add(this.lblOrderN, 5, 0);
            this.tlpMakeOrder.Controls.Add(this.lblInfo2, 0, 0);
            this.tlpMakeOrder.Controls.Add(this.dgvMenu, 1, 1);
            this.tlpMakeOrder.Controls.Add(this.pnlButtons, 0, 1);
            this.tlpMakeOrder.Location = new System.Drawing.Point(9, 17);
            this.tlpMakeOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMakeOrder.Name = "tlpMakeOrder";
            this.tlpMakeOrder.RowCount = 4;
            this.tlpMakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMakeOrder.Size = new System.Drawing.Size(860, 524);
            this.tlpMakeOrder.TabIndex = 6;
            // 
            // lbOrder
            // 
            this.lbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.Location = new System.Drawing.Point(475, 54);
            this.lbOrder.Margin = new System.Windows.Forms.Padding(2);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(297, 199);
            this.lbOrder.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(779, 492);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.AutoSize = true;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(679, 492);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(93, 30);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // tlpItemnInfo
            // 
            this.tlpItemnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpItemnInfo.ColumnCount = 3;
            this.tlpItemnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.03931F));
            this.tlpItemnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98035F));
            this.tlpItemnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98035F));
            this.tlpItemnInfo.Controls.Add(this.nudQuantity, 1, 0);
            this.tlpItemnInfo.Controls.Add(this.lblItem, 0, 0);
            this.tlpItemnInfo.Controls.Add(this.lblLine, 0, 2);
            this.tlpItemnInfo.Controls.Add(this.btnDelete, 2, 0);
            this.tlpItemnInfo.Location = new System.Drawing.Point(475, 263);
            this.tlpItemnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tlpItemnInfo.Name = "tlpItemnInfo";
            this.tlpItemnInfo.RowCount = 4;
            this.tlpItemnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18176F));
            this.tlpItemnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.09842F));
            this.tlpItemnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854526F));
            this.tlpItemnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.8653F));
            this.tlpItemnInfo.Size = new System.Drawing.Size(297, 205);
            this.tlpItemnInfo.TabIndex = 6;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(233, 2);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(28, 26);
            this.nudQuantity.TabIndex = 0;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(2, 0);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(57, 20);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "label1";
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.AutoSize = true;
            this.tlpItemnInfo.SetColumnSpan(this.lblLine, 3);
            this.lblLine.Location = new System.Drawing.Point(2, 117);
            this.lblLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLine.Size = new System.Drawing.Size(293, 9);
            this.lblLine.TabIndex = 2;
            this.lblLine.Text = "_________________________________________________________________________________" +
    "____________________";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(265, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblOrderN
            // 
            this.lblOrderN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderN.AutoSize = true;
            this.lblOrderN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderN.Location = new System.Drawing.Point(713, 0);
            this.lblOrderN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderN.Name = "lblOrderN";
            this.lblOrderN.Size = new System.Drawing.Size(59, 22);
            this.lblOrderN.TabIndex = 7;
            this.lblOrderN.Text = "label1";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpMakeOrder.SetColumnSpan(this.lblInfo2, 2);
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(2, 0);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(59, 22);
            this.lblInfo2.TabIndex = 2;
            this.lblInfo2.Text = "label1";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeColumns = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMakeOrder.SetColumnSpan(this.dgvMenu, 3);
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(45, 54);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.tlpMakeOrder.SetRowSpan(this.dgvMenu, 2);
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(383, 414);
            this.dgvMenu.TabIndex = 8;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(2, 54);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtons.Name = "pnlButtons";
            this.tlpMakeOrder.SetRowSpan(this.pnlButtons, 2);
            this.pnlButtons.Size = new System.Drawing.Size(39, 414);
            this.pnlButtons.TabIndex = 9;
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 551);
            this.Controls.Add(this.tlpMakeOrder);
            this.Controls.Add(this.tlpReceptionist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceptionistForm";
            this.Text = "ReceptionistForm";
            this.tlpReceptionist.ResumeLayout(false);
            this.tlpReceptionist.PerformLayout();
            this.tcOptions.ResumeLayout(false);
            this.tbMenu.ResumeLayout(false);
            this.tlpMakeOrder.ResumeLayout(false);
            this.tlpMakeOrder.PerformLayout();
            this.tlpItemnInfo.ResumeLayout(false);
            this.tlpItemnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnVOrders;
        private System.Windows.Forms.TableLayoutPanel tlpReceptionist;
        private System.Windows.Forms.TabControl tcOptions;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.TabPage tbMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMakeOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.TableLayoutPanel tlpItemnInfo;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblOrderN;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Panel pnlButtons;
    }
}