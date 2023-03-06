namespace MSPaint
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.PanelTools = new System.Windows.Forms.Panel();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.BtnOpen = new FontAwesome.Sharp.IconButton();
            this.CmbPenWidth = new System.Windows.Forms.ComboBox();
            this.SelectBold = new System.Windows.Forms.RadioButton();
            this.SelectRegular = new System.Windows.Forms.RadioButton();
            this.PanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPen_0 = new FontAwesome.Sharp.IconButton();
            this.BtnEraser_1 = new FontAwesome.Sharp.IconButton();
            this.BtnRectangle_3 = new FontAwesome.Sharp.IconButton();
            this.BtnCircle_4 = new FontAwesome.Sharp.IconButton();
            this.PanelWidth = new System.Windows.Forms.Panel();
            this.BtnBucket_2 = new FontAwesome.Sharp.IconButton();
            this.BtnLine_5 = new FontAwesome.Sharp.IconButton();
            this.Palette1 = new System.Windows.Forms.PictureBox();
            this.Palette2 = new System.Windows.Forms.PictureBox();
            this.Palette3 = new System.Windows.Forms.PictureBox();
            this.Palette4 = new System.Windows.Forms.PictureBox();
            this.Palette5 = new System.Windows.Forms.PictureBox();
            this.Palette6 = new System.Windows.Forms.PictureBox();
            this.Palette7 = new System.Windows.Forms.PictureBox();
            this.Palette8 = new System.Windows.Forms.PictureBox();
            this.Palette9 = new System.Windows.Forms.PictureBox();
            this.Palette10 = new System.Windows.Forms.PictureBox();
            this.Palette11 = new System.Windows.Forms.PictureBox();
            this.Palette12 = new System.Windows.Forms.PictureBox();
            this.Palette13 = new System.Windows.Forms.PictureBox();
            this.Palette14 = new System.Windows.Forms.PictureBox();
            this.Palette15 = new System.Windows.Forms.PictureBox();
            this.Palette16 = new System.Windows.Forms.PictureBox();
            this.Palette17 = new System.Windows.Forms.PictureBox();
            this.Palette18 = new System.Windows.Forms.PictureBox();
            this.Palette19 = new System.Windows.Forms.PictureBox();
            this.Palette20 = new System.Windows.Forms.PictureBox();
            this.ColorPaltte = new System.Windows.Forms.PictureBox();
            this.SelectedColor = new FontAwesome.Sharp.IconPictureBox();
            this.lblTools = new System.Windows.Forms.Label();
            this.lblShapes = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblColors = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.PanelCanvas = new System.Windows.Forms.Panel();
            this.PanelTitle.SuspendLayout();
            this.PanelTools.SuspendLayout();
            this.PanelControl.SuspendLayout();
            this.PanelWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Palette1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPaltte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.PanelCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.Black;
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Controls.Add(this.BtnClose);
            this.PanelTitle.Controls.Add(this.BtnMinimize);
            this.PanelTitle.Controls.Add(this.BtnMaximize);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(900, 27);
            this.PanelTitle.TabIndex = 0;
            this.PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(6, 5);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(42, 17);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "Paint";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(872, 2);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.BtnClose.Size = new System.Drawing.Size(23, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(826, 2);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.BtnMinimize.Size = new System.Drawing.Size(23, 23);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnMaximize.ForeColor = System.Drawing.Color.White;
            this.BtnMaximize.Location = new System.Drawing.Point(849, 2);
            this.BtnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.BtnMaximize.Size = new System.Drawing.Size(23, 23);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.Text = "□";
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // PanelTools
            // 
            this.PanelTools.BackColor = System.Drawing.Color.Gray;
            this.PanelTools.Controls.Add(this.BtnClear);
            this.PanelTools.Controls.Add(this.BtnSave);
            this.PanelTools.Controls.Add(this.BtnOpen);
            this.PanelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTools.Location = new System.Drawing.Point(0, 27);
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.Size = new System.Drawing.Size(900, 28);
            this.PanelTools.TabIndex = 1;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.IconChar = FontAwesome.Sharp.IconChar.C;
            this.BtnClear.IconColor = System.Drawing.Color.Black;
            this.BtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClear.IconSize = 24;
            this.BtnClear.Location = new System.Drawing.Point(98, 0);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(49, 28);
            this.BtnClear.TabIndex = 14;
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 24;
            this.BtnSave.Location = new System.Drawing.Point(49, 0);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(49, 28);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnOpen.FlatAppearance.BorderSize = 0;
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.BtnOpen.IconColor = System.Drawing.Color.Black;
            this.BtnOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnOpen.IconSize = 24;
            this.BtnOpen.Location = new System.Drawing.Point(0, 0);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(49, 28);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // CmbPenWidth
            // 
            this.CmbPenWidth.BackColor = System.Drawing.Color.White;
            this.CmbPenWidth.DropDownHeight = 100;
            this.CmbPenWidth.DropDownWidth = 20;
            this.CmbPenWidth.Font = new System.Drawing.Font("游ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CmbPenWidth.FormattingEnabled = true;
            this.CmbPenWidth.ItemHeight = 14;
            this.CmbPenWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CmbPenWidth.Location = new System.Drawing.Point(450, 47);
            this.CmbPenWidth.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPenWidth.Name = "CmbPenWidth";
            this.CmbPenWidth.Size = new System.Drawing.Size(64, 22);
            this.CmbPenWidth.TabIndex = 3;
            this.CmbPenWidth.Text = "Custum";
            this.CmbPenWidth.SelectedValueChanged += new System.EventHandler(this.CmbPenWidth_SelectedValueChanged);
            // 
            // SelectBold
            // 
            this.SelectBold.AutoSize = true;
            this.SelectBold.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectBold.Font = new System.Drawing.Font("游ゴシック", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SelectBold.Location = new System.Drawing.Point(0, 0);
            this.SelectBold.Name = "SelectBold";
            this.SelectBold.Size = new System.Drawing.Size(65, 18);
            this.SelectBold.TabIndex = 2;
            this.SelectBold.Text = "bold";
            this.SelectBold.UseVisualStyleBackColor = true;
            this.SelectBold.CheckedChanged += new System.EventHandler(this.SelectPenWidth_CheckedChanged);
            // 
            // SelectRegular
            // 
            this.SelectRegular.AutoSize = true;
            this.SelectRegular.Checked = true;
            this.SelectRegular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectRegular.Font = new System.Drawing.Font("游ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SelectRegular.Location = new System.Drawing.Point(0, 38);
            this.SelectRegular.Name = "SelectRegular";
            this.SelectRegular.Size = new System.Drawing.Size(65, 18);
            this.SelectRegular.TabIndex = 0;
            this.SelectRegular.TabStop = true;
            this.SelectRegular.Text = "Regular";
            this.SelectRegular.UseVisualStyleBackColor = true;
            this.SelectRegular.CheckedChanged += new System.EventHandler(this.SelectPenWidth_CheckedChanged);
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.Color.White;
            this.PanelControl.ColumnCount = 25;
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.086957F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.086957F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.086957F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.540416F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.351039F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.466513F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.351039F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.540416F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.967668F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.843137F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.381776F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.768166F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.608696F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.086957F));
            this.PanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PanelControl.Controls.Add(this.CmbPenWidth, 10, 2);
            this.PanelControl.Controls.Add(this.BtnPen_0, 1, 1);
            this.PanelControl.Controls.Add(this.BtnEraser_1, 2, 1);
            this.PanelControl.Controls.Add(this.BtnRectangle_3, 6, 1);
            this.PanelControl.Controls.Add(this.BtnCircle_4, 5, 1);
            this.PanelControl.Controls.Add(this.PanelWidth, 9, 1);
            this.PanelControl.Controls.Add(this.BtnBucket_2, 3, 1);
            this.PanelControl.Controls.Add(this.BtnLine_5, 7, 1);
            this.PanelControl.Controls.Add(this.Palette1, 13, 1);
            this.PanelControl.Controls.Add(this.Palette2, 14, 1);
            this.PanelControl.Controls.Add(this.Palette3, 15, 1);
            this.PanelControl.Controls.Add(this.Palette4, 16, 1);
            this.PanelControl.Controls.Add(this.Palette5, 17, 1);
            this.PanelControl.Controls.Add(this.Palette6, 18, 1);
            this.PanelControl.Controls.Add(this.Palette7, 19, 1);
            this.PanelControl.Controls.Add(this.Palette8, 20, 1);
            this.PanelControl.Controls.Add(this.Palette9, 21, 1);
            this.PanelControl.Controls.Add(this.Palette10, 22, 1);
            this.PanelControl.Controls.Add(this.Palette11, 13, 2);
            this.PanelControl.Controls.Add(this.Palette12, 14, 2);
            this.PanelControl.Controls.Add(this.Palette13, 15, 2);
            this.PanelControl.Controls.Add(this.Palette14, 16, 2);
            this.PanelControl.Controls.Add(this.Palette15, 17, 2);
            this.PanelControl.Controls.Add(this.Palette16, 18, 2);
            this.PanelControl.Controls.Add(this.Palette17, 19, 2);
            this.PanelControl.Controls.Add(this.Palette18, 20, 2);
            this.PanelControl.Controls.Add(this.Palette19, 21, 2);
            this.PanelControl.Controls.Add(this.Palette20, 22, 2);
            this.PanelControl.Controls.Add(this.ColorPaltte, 23, 1);
            this.PanelControl.Controls.Add(this.SelectedColor, 11, 1);
            this.PanelControl.Controls.Add(this.lblTools, 2, 3);
            this.PanelControl.Controls.Add(this.lblShapes, 6, 3);
            this.PanelControl.Controls.Add(this.lblWidth, 9, 3);
            this.PanelControl.Controls.Add(this.lblColors, 11, 3);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl.Location = new System.Drawing.Point(0, 55);
            this.PanelControl.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.RowCount = 4;
            this.PanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.PanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.PanelControl.Size = new System.Drawing.Size(900, 100);
            this.PanelControl.TabIndex = 3;
            // 
            // BtnPen_0
            // 
            this.BtnPen_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPen_0.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BtnPen_0.IconColor = System.Drawing.Color.Black;
            this.BtnPen_0.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPen_0.IconSize = 32;
            this.BtnPen_0.Location = new System.Drawing.Point(15, 25);
            this.BtnPen_0.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.BtnPen_0.Name = "BtnPen_0";
            this.BtnPen_0.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PanelControl.SetRowSpan(this.BtnPen_0, 2);
            this.BtnPen_0.Size = new System.Drawing.Size(43, 40);
            this.BtnPen_0.TabIndex = 2;
            this.BtnPen_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPen_0.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPen_0.UseVisualStyleBackColor = true;
            this.BtnPen_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnEraser_1
            // 
            this.BtnEraser_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser_1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnEraser_1.IconColor = System.Drawing.Color.Black;
            this.BtnEraser_1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEraser_1.IconSize = 32;
            this.BtnEraser_1.Location = new System.Drawing.Point(68, 25);
            this.BtnEraser_1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.BtnEraser_1.Name = "BtnEraser_1";
            this.BtnEraser_1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PanelControl.SetRowSpan(this.BtnEraser_1, 2);
            this.BtnEraser_1.Size = new System.Drawing.Size(43, 40);
            this.BtnEraser_1.TabIndex = 3;
            this.BtnEraser_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEraser_1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnEraser_1.UseVisualStyleBackColor = true;
            this.BtnEraser_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnRectangle_3
            // 
            this.BtnRectangle_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle_3.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.BtnRectangle_3.IconColor = System.Drawing.Color.Black;
            this.BtnRectangle_3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRectangle_3.IconSize = 32;
            this.BtnRectangle_3.Location = new System.Drawing.Point(251, 25);
            this.BtnRectangle_3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.BtnRectangle_3.Name = "BtnRectangle_3";
            this.BtnRectangle_3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PanelControl.SetRowSpan(this.BtnRectangle_3, 2);
            this.BtnRectangle_3.Size = new System.Drawing.Size(45, 40);
            this.BtnRectangle_3.TabIndex = 5;
            this.BtnRectangle_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRectangle_3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRectangle_3.UseVisualStyleBackColor = true;
            this.BtnRectangle_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnCircle_4
            // 
            this.BtnCircle_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCircle_4.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.BtnCircle_4.IconColor = System.Drawing.Color.Black;
            this.BtnCircle_4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCircle_4.IconSize = 32;
            this.BtnCircle_4.Location = new System.Drawing.Point(196, 25);
            this.BtnCircle_4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.BtnCircle_4.Name = "BtnCircle_4";
            this.BtnCircle_4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PanelControl.SetRowSpan(this.BtnCircle_4, 2);
            this.BtnCircle_4.Size = new System.Drawing.Size(45, 40);
            this.BtnCircle_4.TabIndex = 6;
            this.BtnCircle_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCircle_4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCircle_4.UseVisualStyleBackColor = true;
            this.BtnCircle_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // PanelWidth
            // 
            this.PanelWidth.Controls.Add(this.SelectRegular);
            this.PanelWidth.Controls.Add(this.SelectBold);
            this.PanelWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWidth.Location = new System.Drawing.Point(381, 17);
            this.PanelWidth.Margin = new System.Windows.Forms.Padding(2);
            this.PanelWidth.Name = "PanelWidth";
            this.PanelControl.SetRowSpan(this.PanelWidth, 2);
            this.PanelWidth.Size = new System.Drawing.Size(65, 56);
            this.PanelWidth.TabIndex = 8;
            // 
            // BtnBucket_2
            // 
            this.BtnBucket_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBucket_2.IconChar = FontAwesome.Sharp.IconChar.FillDrip;
            this.BtnBucket_2.IconColor = System.Drawing.Color.Black;
            this.BtnBucket_2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBucket_2.IconSize = 32;
            this.BtnBucket_2.Location = new System.Drawing.Point(121, 25);
            this.BtnBucket_2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.BtnBucket_2.Name = "BtnBucket_2";
            this.BtnBucket_2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PanelControl.SetRowSpan(this.BtnBucket_2, 2);
            this.BtnBucket_2.Size = new System.Drawing.Size(43, 40);
            this.BtnBucket_2.TabIndex = 4;
            this.BtnBucket_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBucket_2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBucket_2.UseVisualStyleBackColor = true;
            this.BtnBucket_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnLine_5
            // 
            this.BtnLine_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine_5.IconChar = FontAwesome.Sharp.IconChar.LinesLeaning;
            this.BtnLine_5.IconColor = System.Drawing.Color.Black;
            this.BtnLine_5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLine_5.IconSize = 32;
            this.BtnLine_5.Location = new System.Drawing.Point(307, 25);
            this.BtnLine_5.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.BtnLine_5.Name = "BtnLine_5";
            this.BtnLine_5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PanelControl.SetRowSpan(this.BtnLine_5, 2);
            this.BtnLine_5.Size = new System.Drawing.Size(43, 40);
            this.BtnLine_5.TabIndex = 7;
            this.BtnLine_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLine_5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnLine_5.UseVisualStyleBackColor = true;
            this.BtnLine_5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // Palette1
            // 
            this.Palette1.BackColor = System.Drawing.Color.Black;
            this.Palette1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette1.Location = new System.Drawing.Point(606, 17);
            this.Palette1.Margin = new System.Windows.Forms.Padding(2);
            this.Palette1.Name = "Palette1";
            this.Palette1.Size = new System.Drawing.Size(18, 26);
            this.Palette1.TabIndex = 14;
            this.Palette1.TabStop = false;
            this.Palette1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette2
            // 
            this.Palette2.BackColor = System.Drawing.Color.Gray;
            this.Palette2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette2.Location = new System.Drawing.Point(628, 17);
            this.Palette2.Margin = new System.Windows.Forms.Padding(2);
            this.Palette2.Name = "Palette2";
            this.Palette2.Size = new System.Drawing.Size(18, 26);
            this.Palette2.TabIndex = 15;
            this.Palette2.TabStop = false;
            this.Palette2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette3
            // 
            this.Palette3.BackColor = System.Drawing.Color.DarkRed;
            this.Palette3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette3.Location = new System.Drawing.Point(650, 17);
            this.Palette3.Margin = new System.Windows.Forms.Padding(2);
            this.Palette3.Name = "Palette3";
            this.Palette3.Size = new System.Drawing.Size(18, 26);
            this.Palette3.TabIndex = 15;
            this.Palette3.TabStop = false;
            this.Palette3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette4
            // 
            this.Palette4.BackColor = System.Drawing.Color.Red;
            this.Palette4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette4.Location = new System.Drawing.Point(672, 17);
            this.Palette4.Margin = new System.Windows.Forms.Padding(2);
            this.Palette4.Name = "Palette4";
            this.Palette4.Size = new System.Drawing.Size(18, 26);
            this.Palette4.TabIndex = 15;
            this.Palette4.TabStop = false;
            this.Palette4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette5
            // 
            this.Palette5.BackColor = System.Drawing.Color.Orange;
            this.Palette5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette5.Location = new System.Drawing.Point(694, 17);
            this.Palette5.Margin = new System.Windows.Forms.Padding(2);
            this.Palette5.Name = "Palette5";
            this.Palette5.Size = new System.Drawing.Size(18, 26);
            this.Palette5.TabIndex = 15;
            this.Palette5.TabStop = false;
            this.Palette5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette6
            // 
            this.Palette6.BackColor = System.Drawing.Color.Yellow;
            this.Palette6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette6.Location = new System.Drawing.Point(716, 17);
            this.Palette6.Margin = new System.Windows.Forms.Padding(2);
            this.Palette6.Name = "Palette6";
            this.Palette6.Size = new System.Drawing.Size(18, 26);
            this.Palette6.TabIndex = 15;
            this.Palette6.TabStop = false;
            this.Palette6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette7
            // 
            this.Palette7.BackColor = System.Drawing.Color.Green;
            this.Palette7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette7.Location = new System.Drawing.Point(738, 17);
            this.Palette7.Margin = new System.Windows.Forms.Padding(2);
            this.Palette7.Name = "Palette7";
            this.Palette7.Size = new System.Drawing.Size(18, 26);
            this.Palette7.TabIndex = 15;
            this.Palette7.TabStop = false;
            this.Palette7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette8
            // 
            this.Palette8.BackColor = System.Drawing.Color.Turquoise;
            this.Palette8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette8.Location = new System.Drawing.Point(760, 17);
            this.Palette8.Margin = new System.Windows.Forms.Padding(2);
            this.Palette8.Name = "Palette8";
            this.Palette8.Size = new System.Drawing.Size(18, 26);
            this.Palette8.TabIndex = 15;
            this.Palette8.TabStop = false;
            this.Palette8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette9
            // 
            this.Palette9.BackColor = System.Drawing.Color.MediumBlue;
            this.Palette9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette9.Location = new System.Drawing.Point(782, 17);
            this.Palette9.Margin = new System.Windows.Forms.Padding(2);
            this.Palette9.Name = "Palette9";
            this.Palette9.Size = new System.Drawing.Size(18, 26);
            this.Palette9.TabIndex = 15;
            this.Palette9.TabStop = false;
            this.Palette9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette10
            // 
            this.Palette10.BackColor = System.Drawing.Color.DarkMagenta;
            this.Palette10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette10.Location = new System.Drawing.Point(804, 17);
            this.Palette10.Margin = new System.Windows.Forms.Padding(2);
            this.Palette10.Name = "Palette10";
            this.Palette10.Size = new System.Drawing.Size(18, 26);
            this.Palette10.TabIndex = 15;
            this.Palette10.TabStop = false;
            this.Palette10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette11
            // 
            this.Palette11.BackColor = System.Drawing.Color.White;
            this.Palette11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette11.Location = new System.Drawing.Point(606, 47);
            this.Palette11.Margin = new System.Windows.Forms.Padding(2);
            this.Palette11.Name = "Palette11";
            this.Palette11.Size = new System.Drawing.Size(18, 26);
            this.Palette11.TabIndex = 14;
            this.Palette11.TabStop = false;
            this.Palette11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette12
            // 
            this.Palette12.BackColor = System.Drawing.Color.LightGray;
            this.Palette12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette12.Location = new System.Drawing.Point(628, 47);
            this.Palette12.Margin = new System.Windows.Forms.Padding(2);
            this.Palette12.Name = "Palette12";
            this.Palette12.Size = new System.Drawing.Size(18, 26);
            this.Palette12.TabIndex = 14;
            this.Palette12.TabStop = false;
            this.Palette12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette13
            // 
            this.Palette13.BackColor = System.Drawing.Color.Peru;
            this.Palette13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette13.Location = new System.Drawing.Point(650, 47);
            this.Palette13.Margin = new System.Windows.Forms.Padding(2);
            this.Palette13.Name = "Palette13";
            this.Palette13.Size = new System.Drawing.Size(18, 26);
            this.Palette13.TabIndex = 14;
            this.Palette13.TabStop = false;
            this.Palette13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette14
            // 
            this.Palette14.BackColor = System.Drawing.Color.Pink;
            this.Palette14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette14.Location = new System.Drawing.Point(672, 47);
            this.Palette14.Margin = new System.Windows.Forms.Padding(2);
            this.Palette14.Name = "Palette14";
            this.Palette14.Size = new System.Drawing.Size(18, 26);
            this.Palette14.TabIndex = 14;
            this.Palette14.TabStop = false;
            this.Palette14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette15
            // 
            this.Palette15.BackColor = System.Drawing.Color.Khaki;
            this.Palette15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette15.Location = new System.Drawing.Point(694, 47);
            this.Palette15.Margin = new System.Windows.Forms.Padding(2);
            this.Palette15.Name = "Palette15";
            this.Palette15.Size = new System.Drawing.Size(18, 26);
            this.Palette15.TabIndex = 14;
            this.Palette15.TabStop = false;
            this.Palette15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette16
            // 
            this.Palette16.BackColor = System.Drawing.Color.LightYellow;
            this.Palette16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette16.Location = new System.Drawing.Point(716, 47);
            this.Palette16.Margin = new System.Windows.Forms.Padding(2);
            this.Palette16.Name = "Palette16";
            this.Palette16.Size = new System.Drawing.Size(18, 26);
            this.Palette16.TabIndex = 14;
            this.Palette16.TabStop = false;
            this.Palette16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette17
            // 
            this.Palette17.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Palette17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette17.Location = new System.Drawing.Point(738, 47);
            this.Palette17.Margin = new System.Windows.Forms.Padding(2);
            this.Palette17.Name = "Palette17";
            this.Palette17.Size = new System.Drawing.Size(18, 26);
            this.Palette17.TabIndex = 14;
            this.Palette17.TabStop = false;
            this.Palette17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette18
            // 
            this.Palette18.BackColor = System.Drawing.Color.PowderBlue;
            this.Palette18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette18.Location = new System.Drawing.Point(760, 47);
            this.Palette18.Margin = new System.Windows.Forms.Padding(2);
            this.Palette18.Name = "Palette18";
            this.Palette18.Size = new System.Drawing.Size(18, 26);
            this.Palette18.TabIndex = 14;
            this.Palette18.TabStop = false;
            this.Palette18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette19
            // 
            this.Palette19.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Palette19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette19.Location = new System.Drawing.Point(782, 47);
            this.Palette19.Margin = new System.Windows.Forms.Padding(2);
            this.Palette19.Name = "Palette19";
            this.Palette19.Size = new System.Drawing.Size(18, 26);
            this.Palette19.TabIndex = 14;
            this.Palette19.TabStop = false;
            this.Palette19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // Palette20
            // 
            this.Palette20.BackColor = System.Drawing.Color.Thistle;
            this.Palette20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palette20.Location = new System.Drawing.Point(804, 47);
            this.Palette20.Margin = new System.Windows.Forms.Padding(2);
            this.Palette20.Name = "Palette20";
            this.Palette20.Size = new System.Drawing.Size(18, 26);
            this.Palette20.TabIndex = 14;
            this.Palette20.TabStop = false;
            this.Palette20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseDown);
            // 
            // ColorPaltte
            // 
            this.ColorPaltte.Image = global::MSPaint.Properties.Resources.palette;
            this.ColorPaltte.Location = new System.Drawing.Point(824, 15);
            this.ColorPaltte.Margin = new System.Windows.Forms.Padding(0);
            this.ColorPaltte.Name = "ColorPaltte";
            this.PanelControl.SetRowSpan(this.ColorPaltte, 2);
            this.ColorPaltte.Size = new System.Drawing.Size(53, 60);
            this.ColorPaltte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ColorPaltte.TabIndex = 13;
            this.ColorPaltte.TabStop = false;
            this.ColorPaltte.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // SelectedColor
            // 
            this.SelectedColor.BackColor = System.Drawing.Color.White;
            this.SelectedColor.ForeColor = System.Drawing.Color.Gray;
            this.SelectedColor.IconChar = FontAwesome.Sharp.IconChar.ColonSign;
            this.SelectedColor.IconColor = System.Drawing.Color.Gray;
            this.SelectedColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectedColor.IconSize = 60;
            this.SelectedColor.ImageLocation = "";
            this.SelectedColor.Location = new System.Drawing.Point(516, 15);
            this.SelectedColor.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedColor.Name = "SelectedColor";
            this.PanelControl.SetRowSpan(this.SelectedColor, 2);
            this.SelectedColor.Size = new System.Drawing.Size(64, 60);
            this.SelectedColor.TabIndex = 16;
            this.SelectedColor.TabStop = false;
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTools.Location = new System.Drawing.Point(66, 78);
            this.lblTools.Margin = new System.Windows.Forms.Padding(3);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(47, 19);
            this.lblTools.TabIndex = 17;
            this.lblTools.Text = "Tools";
            this.lblTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShapes
            // 
            this.lblShapes.AutoSize = true;
            this.lblShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShapes.Location = new System.Drawing.Point(249, 78);
            this.lblShapes.Margin = new System.Windows.Forms.Padding(3);
            this.lblShapes.Name = "lblShapes";
            this.lblShapes.Size = new System.Drawing.Size(50, 19);
            this.lblShapes.TabIndex = 17;
            this.lblShapes.Text = "Shaps";
            this.lblShapes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.PanelControl.SetColumnSpan(this.lblWidth, 2);
            this.lblWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWidth.Location = new System.Drawing.Point(382, 78);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(3);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(131, 19);
            this.lblWidth.TabIndex = 17;
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColors.Location = new System.Drawing.Point(519, 78);
            this.lblColors.Margin = new System.Windows.Forms.Padding(3);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(58, 19);
            this.lblColors.TabIndex = 17;
            this.lblColors.Text = "Color";
            this.lblColors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(5, 5);
            this.Canvas.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(890, 585);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.SizeChanged += new System.EventHandler(this.Canvas_SizeChanged);
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // PanelCanvas
            // 
            this.PanelCanvas.BackColor = System.Drawing.Color.Black;
            this.PanelCanvas.Controls.Add(this.Canvas);
            this.PanelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCanvas.Location = new System.Drawing.Point(0, 155);
            this.PanelCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.PanelCanvas.Name = "PanelCanvas";
            this.PanelCanvas.Padding = new System.Windows.Forms.Padding(5);
            this.PanelCanvas.Size = new System.Drawing.Size(900, 595);
            this.PanelCanvas.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.PanelCanvas);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelTools);
            this.Controls.Add(this.PanelTitle);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelTools.ResumeLayout(false);
            this.PanelControl.ResumeLayout(false);
            this.PanelControl.PerformLayout();
            this.PanelWidth.ResumeLayout(false);
            this.PanelWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Palette1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palette20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPaltte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.PanelCanvas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel PanelTools;
        private System.Windows.Forms.PictureBox Canvas;
        private FontAwesome.Sharp.IconButton BtnSave;
        private FontAwesome.Sharp.IconButton BtnOpen;
        private FontAwesome.Sharp.IconButton BtnBucket_2;
        private FontAwesome.Sharp.IconButton BtnEraser_1;
        private FontAwesome.Sharp.IconButton BtnPen_0;
        private FontAwesome.Sharp.IconButton BtnLine_5;
        private FontAwesome.Sharp.IconButton BtnCircle_4;
        private FontAwesome.Sharp.IconButton BtnRectangle_3;
        private System.Windows.Forms.RadioButton SelectBold;
        private System.Windows.Forms.RadioButton SelectRegular;
        private System.Windows.Forms.ComboBox CmbPenWidth;
        private FontAwesome.Sharp.IconButton BtnClear;
        private System.Windows.Forms.TableLayoutPanel PanelControl;
        private System.Windows.Forms.Panel PanelWidth;
        private System.Windows.Forms.PictureBox Palette1;
        private System.Windows.Forms.PictureBox Palette2;
        private System.Windows.Forms.PictureBox Palette3;
        private System.Windows.Forms.PictureBox Palette4;
        private System.Windows.Forms.PictureBox Palette5;
        private System.Windows.Forms.PictureBox Palette6;
        private System.Windows.Forms.PictureBox Palette7;
        private System.Windows.Forms.PictureBox Palette8;
        private System.Windows.Forms.PictureBox Palette9;
        private System.Windows.Forms.PictureBox Palette10;
        private System.Windows.Forms.PictureBox Palette11;
        private System.Windows.Forms.PictureBox Palette12;
        private System.Windows.Forms.PictureBox Palette13;
        private System.Windows.Forms.PictureBox Palette14;
        private System.Windows.Forms.PictureBox Palette15;
        private System.Windows.Forms.PictureBox Palette16;
        private System.Windows.Forms.PictureBox Palette17;
        private System.Windows.Forms.PictureBox Palette18;
        private System.Windows.Forms.PictureBox Palette19;
        private System.Windows.Forms.PictureBox Palette20;
        private System.Windows.Forms.PictureBox ColorPaltte;
        private FontAwesome.Sharp.IconPictureBox SelectedColor;
        private System.Windows.Forms.Panel PanelCanvas;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.Label lblShapes;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblColors;
    }
}

