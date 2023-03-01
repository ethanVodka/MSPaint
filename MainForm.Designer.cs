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
            this.BtnSelectColor = new System.Windows.Forms.Button();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.SelectColor = new System.Windows.Forms.PictureBox();
            this.LabelFontSize = new System.Windows.Forms.Label();
            this.LabelFontStyle = new System.Windows.Forms.Label();
            this.LabelFontFamily = new System.Windows.Forms.Label();
            this.BtnSelectFont = new System.Windows.Forms.Button();
            this.FontStyle = new System.Windows.Forms.GroupBox();
            this.CmbPenWidth = new System.Windows.Forms.ComboBox();
            this.SelectBold = new System.Windows.Forms.RadioButton();
            this.SelectRegular = new System.Windows.Forms.RadioButton();
            this.BtnLine_5 = new FontAwesome.Sharp.IconButton();
            this.BtnCircle_4 = new FontAwesome.Sharp.IconButton();
            this.BtnRectangle_3 = new FontAwesome.Sharp.IconButton();
            this.BtnBucket_2 = new FontAwesome.Sharp.IconButton();
            this.BtnEraser_1 = new FontAwesome.Sharp.IconButton();
            this.BtnPen_0 = new FontAwesome.Sharp.IconButton();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.BtnOpen = new FontAwesome.Sharp.IconButton();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.DrawaingFontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PanelTitle.SuspendLayout();
            this.PanelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectColor)).BeginInit();
            this.FontStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
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
            this.PanelTitle.Size = new System.Drawing.Size(1150, 27);
            this.PanelTitle.TabIndex = 0;
            this.PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(9, 5);
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
            this.BtnClose.Location = new System.Drawing.Point(1122, 2);
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
            this.BtnMinimize.Location = new System.Drawing.Point(1076, 2);
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
            this.BtnMaximize.Location = new System.Drawing.Point(1099, 2);
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
            this.PanelTools.BackColor = System.Drawing.Color.DarkGray;
            this.PanelTools.Controls.Add(this.BtnSelectColor);
            this.PanelTools.Controls.Add(this.BtnClear);
            this.PanelTools.Controls.Add(this.SelectColor);
            this.PanelTools.Controls.Add(this.LabelFontSize);
            this.PanelTools.Controls.Add(this.LabelFontStyle);
            this.PanelTools.Controls.Add(this.LabelFontFamily);
            this.PanelTools.Controls.Add(this.BtnSelectFont);
            this.PanelTools.Controls.Add(this.FontStyle);
            this.PanelTools.Controls.Add(this.BtnLine_5);
            this.PanelTools.Controls.Add(this.BtnCircle_4);
            this.PanelTools.Controls.Add(this.BtnRectangle_3);
            this.PanelTools.Controls.Add(this.BtnBucket_2);
            this.PanelTools.Controls.Add(this.BtnEraser_1);
            this.PanelTools.Controls.Add(this.BtnPen_0);
            this.PanelTools.Controls.Add(this.BtnSave);
            this.PanelTools.Controls.Add(this.BtnOpen);
            this.PanelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTools.Location = new System.Drawing.Point(0, 27);
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.Size = new System.Drawing.Size(1150, 120);
            this.PanelTools.TabIndex = 1;
            // 
            // BtnSelectColor
            // 
            this.BtnSelectColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelectColor.FlatAppearance.BorderSize = 0;
            this.BtnSelectColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectColor.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSelectColor.ForeColor = System.Drawing.Color.White;
            this.BtnSelectColor.Location = new System.Drawing.Point(625, 6);
            this.BtnSelectColor.Name = "BtnSelectColor";
            this.BtnSelectColor.Size = new System.Drawing.Size(53, 23);
            this.BtnSelectColor.TabIndex = 15;
            this.BtnSelectColor.Text = "Color";
            this.BtnSelectColor.UseVisualStyleBackColor = true;
            this.BtnSelectColor.Click += new System.EventHandler(this.BtnSelectColor_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.IconChar = FontAwesome.Sharp.IconChar.Pallet;
            this.BtnClear.IconColor = System.Drawing.Color.Black;
            this.BtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClear.IconSize = 32;
            this.BtnClear.Location = new System.Drawing.Point(110, 6);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(49, 88);
            this.BtnClear.TabIndex = 14;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // SelectColor
            // 
            this.SelectColor.Location = new System.Drawing.Point(625, 59);
            this.SelectColor.Name = "SelectColor";
            this.SelectColor.Size = new System.Drawing.Size(52, 52);
            this.SelectColor.TabIndex = 13;
            this.SelectColor.TabStop = false;
            this.SelectColor.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // LabelFontSize
            // 
            this.LabelFontSize.AutoSize = true;
            this.LabelFontSize.Location = new System.Drawing.Point(703, 99);
            this.LabelFontSize.Name = "LabelFontSize";
            this.LabelFontSize.Size = new System.Drawing.Size(11, 12);
            this.LabelFontSize.TabIndex = 12;
            this.LabelFontSize.Text = "...";
            // 
            // LabelFontStyle
            // 
            this.LabelFontStyle.AutoSize = true;
            this.LabelFontStyle.Location = new System.Drawing.Point(703, 69);
            this.LabelFontStyle.Name = "LabelFontStyle";
            this.LabelFontStyle.Size = new System.Drawing.Size(11, 12);
            this.LabelFontStyle.TabIndex = 11;
            this.LabelFontStyle.Text = "...";
            // 
            // LabelFontFamily
            // 
            this.LabelFontFamily.AutoSize = true;
            this.LabelFontFamily.Location = new System.Drawing.Point(703, 38);
            this.LabelFontFamily.Name = "LabelFontFamily";
            this.LabelFontFamily.Size = new System.Drawing.Size(11, 12);
            this.LabelFontFamily.TabIndex = 10;
            this.LabelFontFamily.Text = "...";
            // 
            // BtnSelectFont
            // 
            this.BtnSelectFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelectFont.FlatAppearance.BorderSize = 0;
            this.BtnSelectFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectFont.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSelectFont.ForeColor = System.Drawing.Color.White;
            this.BtnSelectFont.Location = new System.Drawing.Point(705, 6);
            this.BtnSelectFont.Name = "BtnSelectFont";
            this.BtnSelectFont.Size = new System.Drawing.Size(53, 23);
            this.BtnSelectFont.TabIndex = 9;
            this.BtnSelectFont.Text = "Font";
            this.BtnSelectFont.UseVisualStyleBackColor = true;
            this.BtnSelectFont.Click += new System.EventHandler(this.BtnSelectFont_Click);
            // 
            // FontStyle
            // 
            this.FontStyle.BackColor = System.Drawing.Color.Silver;
            this.FontStyle.Controls.Add(this.CmbPenWidth);
            this.FontStyle.Controls.Add(this.SelectBold);
            this.FontStyle.Controls.Add(this.SelectRegular);
            this.FontStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontStyle.Location = new System.Drawing.Point(498, 6);
            this.FontStyle.Name = "FontStyle";
            this.FontStyle.Size = new System.Drawing.Size(91, 105);
            this.FontStyle.TabIndex = 8;
            this.FontStyle.TabStop = false;
            this.FontStyle.Text = "PenWidth";
            // 
            // CmbPenWidth
            // 
            this.CmbPenWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbPenWidth.FormattingEnabled = true;
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
            this.CmbPenWidth.Location = new System.Drawing.Point(6, 76);
            this.CmbPenWidth.Name = "CmbPenWidth";
            this.CmbPenWidth.Size = new System.Drawing.Size(72, 20);
            this.CmbPenWidth.TabIndex = 3;
            this.CmbPenWidth.Text = "Custum";
            this.CmbPenWidth.SelectedValueChanged += new System.EventHandler(this.CmbPenWidth_SelectedValueChanged);
            // 
            // SelectBold
            // 
            this.SelectBold.AutoSize = true;
            this.SelectBold.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SelectBold.Location = new System.Drawing.Point(7, 46);
            this.SelectBold.Name = "SelectBold";
            this.SelectBold.Size = new System.Drawing.Size(48, 16);
            this.SelectBold.TabIndex = 2;
            this.SelectBold.Text = "bold";
            this.SelectBold.UseVisualStyleBackColor = true;
            this.SelectBold.CheckedChanged += new System.EventHandler(this.SelectPenWidth_CheckedChanged);
            // 
            // SelectRegular
            // 
            this.SelectRegular.AutoSize = true;
            this.SelectRegular.Checked = true;
            this.SelectRegular.Location = new System.Drawing.Point(7, 20);
            this.SelectRegular.Name = "SelectRegular";
            this.SelectRegular.Size = new System.Drawing.Size(62, 16);
            this.SelectRegular.TabIndex = 0;
            this.SelectRegular.TabStop = true;
            this.SelectRegular.Text = "Regular";
            this.SelectRegular.UseVisualStyleBackColor = true;
            this.SelectRegular.CheckedChanged += new System.EventHandler(this.SelectPenWidth_CheckedChanged);
            // 
            // BtnLine_5
            // 
            this.BtnLine_5.FlatAppearance.BorderSize = 0;
            this.BtnLine_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine_5.IconChar = FontAwesome.Sharp.IconChar.LinesLeaning;
            this.BtnLine_5.IconColor = System.Drawing.Color.Black;
            this.BtnLine_5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLine_5.IconSize = 12;
            this.BtnLine_5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLine_5.Location = new System.Drawing.Point(292, 76);
            this.BtnLine_5.Name = "BtnLine_5";
            this.BtnLine_5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnLine_5.Size = new System.Drawing.Size(87, 24);
            this.BtnLine_5.TabIndex = 7;
            this.BtnLine_5.Text = "Line";
            this.BtnLine_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLine_5.UseVisualStyleBackColor = true;
            this.BtnLine_5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnCircle_4
            // 
            this.BtnCircle_4.FlatAppearance.BorderSize = 0;
            this.BtnCircle_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCircle_4.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.BtnCircle_4.IconColor = System.Drawing.Color.Black;
            this.BtnCircle_4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCircle_4.IconSize = 12;
            this.BtnCircle_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCircle_4.Location = new System.Drawing.Point(292, 46);
            this.BtnCircle_4.Name = "BtnCircle_4";
            this.BtnCircle_4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnCircle_4.Size = new System.Drawing.Size(87, 24);
            this.BtnCircle_4.TabIndex = 6;
            this.BtnCircle_4.Text = "Circle";
            this.BtnCircle_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCircle_4.UseVisualStyleBackColor = true;
            this.BtnCircle_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnRectangle_3
            // 
            this.BtnRectangle_3.FlatAppearance.BorderSize = 0;
            this.BtnRectangle_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle_3.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnRectangle_3.IconColor = System.Drawing.Color.Black;
            this.BtnRectangle_3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRectangle_3.IconSize = 12;
            this.BtnRectangle_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRectangle_3.Location = new System.Drawing.Point(292, 16);
            this.BtnRectangle_3.Name = "BtnRectangle_3";
            this.BtnRectangle_3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnRectangle_3.Size = new System.Drawing.Size(87, 24);
            this.BtnRectangle_3.TabIndex = 5;
            this.BtnRectangle_3.Text = "Rectangle";
            this.BtnRectangle_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRectangle_3.UseVisualStyleBackColor = true;
            this.BtnRectangle_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnBucket_2
            // 
            this.BtnBucket_2.FlatAppearance.BorderSize = 0;
            this.BtnBucket_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBucket_2.IconChar = FontAwesome.Sharp.IconChar.Bucket;
            this.BtnBucket_2.IconColor = System.Drawing.Color.Black;
            this.BtnBucket_2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBucket_2.IconSize = 12;
            this.BtnBucket_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBucket_2.Location = new System.Drawing.Point(202, 76);
            this.BtnBucket_2.Name = "BtnBucket_2";
            this.BtnBucket_2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnBucket_2.Size = new System.Drawing.Size(76, 24);
            this.BtnBucket_2.TabIndex = 4;
            this.BtnBucket_2.Text = "Bucket";
            this.BtnBucket_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBucket_2.UseVisualStyleBackColor = true;
            this.BtnBucket_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnEraser_1
            // 
            this.BtnEraser_1.FlatAppearance.BorderSize = 0;
            this.BtnEraser_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser_1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnEraser_1.IconColor = System.Drawing.Color.Black;
            this.BtnEraser_1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEraser_1.IconSize = 12;
            this.BtnEraser_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEraser_1.Location = new System.Drawing.Point(202, 46);
            this.BtnEraser_1.Name = "BtnEraser_1";
            this.BtnEraser_1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnEraser_1.Size = new System.Drawing.Size(62, 24);
            this.BtnEraser_1.TabIndex = 3;
            this.BtnEraser_1.Text = "Eraser";
            this.BtnEraser_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEraser_1.UseVisualStyleBackColor = true;
            this.BtnEraser_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnPen_0
            // 
            this.BtnPen_0.FlatAppearance.BorderSize = 0;
            this.BtnPen_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPen_0.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BtnPen_0.IconColor = System.Drawing.Color.Black;
            this.BtnPen_0.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPen_0.IconSize = 12;
            this.BtnPen_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPen_0.Location = new System.Drawing.Point(202, 16);
            this.BtnPen_0.Name = "BtnPen_0";
            this.BtnPen_0.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnPen_0.Size = new System.Drawing.Size(62, 24);
            this.BtnPen_0.TabIndex = 2;
            this.BtnPen_0.Text = "Pen";
            this.BtnPen_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPen_0.UseVisualStyleBackColor = true;
            this.BtnPen_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModeButton_MouseClick);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 32;
            this.BtnSave.Location = new System.Drawing.Point(61, 6);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(49, 88);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnOpen
            // 
            this.BtnOpen.FlatAppearance.BorderSize = 0;
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.BtnOpen.IconColor = System.Drawing.Color.Black;
            this.BtnOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnOpen.IconSize = 32;
            this.BtnOpen.Location = new System.Drawing.Point(12, 6);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(49, 88);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnOpen.UseVisualStyleBackColor = true;
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 147);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1150, 603);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.ClientSizeChanged += new System.EventHandler(this.Canvas_ClientSizeChanged);
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 750);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.PanelTools);
            this.Controls.Add(this.PanelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelTools.ResumeLayout(false);
            this.PanelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectColor)).EndInit();
            this.FontStyle.ResumeLayout(false);
            this.FontStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
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
        private System.Windows.Forms.Button BtnSelectFont;
        private System.Windows.Forms.GroupBox FontStyle;
        private System.Windows.Forms.RadioButton SelectBold;
        private System.Windows.Forms.RadioButton SelectRegular;
        private System.Windows.Forms.FontDialog DrawaingFontDialog;
        private System.Windows.Forms.ComboBox CmbPenWidth;
        private System.Windows.Forms.Label LabelFontSize;
        private System.Windows.Forms.Label LabelFontStyle;
        private System.Windows.Forms.Label LabelFontFamily;
        private System.Windows.Forms.PictureBox SelectColor;
        private FontAwesome.Sharp.IconButton BtnClear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnSelectColor;
    }
}

