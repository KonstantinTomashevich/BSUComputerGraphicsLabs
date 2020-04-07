namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topMenuLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sizeInfoLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.toolsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolsLabel = new System.Windows.Forms.Label();
            this.lineStepButton = new System.Windows.Forms.RadioButton();
            this.lineDDAButton = new System.Windows.Forms.RadioButton();
            this.lineBresenhamButton = new System.Windows.Forms.RadioButton();
            this.circleBresenhamButton = new System.Windows.Forms.RadioButton();
            this.circleConfigLabel = new System.Windows.Forms.Label();
            this.circleRadiusLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.circleRadiusInput = new System.Windows.Forms.NumericUpDown();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorSelectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.alphaEdit = new System.Windows.Forms.NumericUpDown();
            this.rEdit = new System.Windows.Forms.NumericUpDown();
            this.gEdit = new System.Windows.Forms.NumericUpDown();
            this.bEdit = new System.Windows.Forms.NumericUpDown();
            this.bitmapPanel = new System.Windows.Forms.Panel();
            this.topPanelTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.lastDrawCallTimeInfoLabel = new System.Windows.Forms.Label();
            this.lastDrawCallTimeLabel = new System.Windows.Forms.Label();
            this.msLabel = new System.Windows.Forms.Label();
            this.testPerformanceButton = new System.Windows.Forms.Button();
            this.lineMidpointButton = new System.Windows.Forms.RadioButton();
            this.circleMidpointButton = new System.Windows.Forms.RadioButton();
            this.lineByButton = new System.Windows.Forms.RadioButton();
            this.mainTableLayout.SuspendLayout();
            this.topMenuLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            this.toolsPanel.SuspendLayout();
            this.circleRadiusLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadiusInput)).BeginInit();
            this.colorSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.Controls.Add(this.topMenuLayout, 0, 0);
            this.mainTableLayout.Controls.Add(this.toolsPanel, 1, 1);
            this.mainTableLayout.Controls.Add(this.bitmapPanel, 0, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(1143, 633);
            this.mainTableLayout.TabIndex = 0;
            // 
            // topMenuLayout
            // 
            this.topMenuLayout.AutoSize = true;
            this.topMenuLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTableLayout.SetColumnSpan(this.topMenuLayout, 2);
            this.topMenuLayout.Controls.Add(this.sizeInfoLabel);
            this.topMenuLayout.Controls.Add(this.widthInput);
            this.topMenuLayout.Controls.Add(this.xLabel);
            this.topMenuLayout.Controls.Add(this.heightInput);
            this.topMenuLayout.Controls.Add(this.lastDrawCallTimeInfoLabel);
            this.topMenuLayout.Controls.Add(this.lastDrawCallTimeLabel);
            this.topMenuLayout.Controls.Add(this.msLabel);
            this.topMenuLayout.Controls.Add(this.testPerformanceButton);
            this.topMenuLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenuLayout.Location = new System.Drawing.Point(3, 3);
            this.topMenuLayout.Name = "topMenuLayout";
            this.topMenuLayout.Size = new System.Drawing.Size(1137, 42);
            this.topMenuLayout.TabIndex = 0;
            // 
            // sizeInfoLabel
            // 
            this.sizeInfoLabel.AutoSize = true;
            this.sizeInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.sizeInfoLabel.Name = "sizeInfoLabel";
            this.sizeInfoLabel.Size = new System.Drawing.Size(304, 42);
            this.sizeInfoLabel.TabIndex = 0;
            this.sizeInfoLabel.Text = "Image sample size (width x height):";
            this.sizeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthInput
            // 
            this.widthInput.AutoSize = true;
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthInput.Location = new System.Drawing.Point(313, 3);
            this.widthInput.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(70, 28);
            this.widthInput.TabIndex = 1;
            this.topPanelTooltip.SetToolTip(this.widthInput, "edit to expand or shrink sample");
            this.widthInput.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.widthInput.ValueChanged += new System.EventHandler(this.widthInput_ValueChanged);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xLabel.Location = new System.Drawing.Point(389, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(20, 42);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "x";
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heightInput
            // 
            this.heightInput.AutoSize = true;
            this.heightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightInput.Location = new System.Drawing.Point(415, 3);
            this.heightInput.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.heightInput.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(70, 28);
            this.heightInput.TabIndex = 2;
            this.topPanelTooltip.SetToolTip(this.heightInput, "edit to expand or shrink sample");
            this.heightInput.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.heightInput.ValueChanged += new System.EventHandler(this.heightInput_ValueChanged);
            // 
            // toolsPanel
            // 
            this.toolsPanel.AutoScroll = true;
            this.toolsPanel.AutoSize = true;
            this.toolsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolsPanel.Controls.Add(this.toolsLabel);
            this.toolsPanel.Controls.Add(this.lineStepButton);
            this.toolsPanel.Controls.Add(this.lineDDAButton);
            this.toolsPanel.Controls.Add(this.lineBresenhamButton);
            this.toolsPanel.Controls.Add(this.lineMidpointButton);
            this.toolsPanel.Controls.Add(this.lineByButton);
            this.toolsPanel.Controls.Add(this.circleBresenhamButton);
            this.toolsPanel.Controls.Add(this.circleMidpointButton);
            this.toolsPanel.Controls.Add(this.circleConfigLabel);
            this.toolsPanel.Controls.Add(this.circleRadiusLayout);
            this.toolsPanel.Controls.Add(this.colorLabel);
            this.toolsPanel.Controls.Add(this.colorSelectionPanel);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.toolsPanel.Location = new System.Drawing.Point(870, 51);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(270, 579);
            this.toolsPanel.TabIndex = 1;
            this.toolsPanel.WrapContents = false;
            // 
            // toolsLabel
            // 
            this.toolsLabel.AutoSize = true;
            this.toolsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolsLabel.Location = new System.Drawing.Point(3, 0);
            this.toolsLabel.Name = "toolsLabel";
            this.toolsLabel.Size = new System.Drawing.Size(264, 29);
            this.toolsLabel.TabIndex = 0;
            this.toolsLabel.Text = "Tools";
            this.toolsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lineStepButton
            // 
            this.lineStepButton.AutoSize = true;
            this.lineStepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineStepButton.Location = new System.Drawing.Point(3, 32);
            this.lineStepButton.Name = "lineStepButton";
            this.lineStepButton.Size = new System.Drawing.Size(172, 28);
            this.lineStepButton.TabIndex = 1;
            this.lineStepButton.TabStop = true;
            this.lineStepButton.Text = "Line step by step";
            this.lineStepButton.UseVisualStyleBackColor = true;
            this.lineStepButton.CheckedChanged += new System.EventHandler(this.lineStepButton_CheckedChanged);
            // 
            // lineDDAButton
            // 
            this.lineDDAButton.AutoSize = true;
            this.lineDDAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineDDAButton.Location = new System.Drawing.Point(3, 66);
            this.lineDDAButton.Name = "lineDDAButton";
            this.lineDDAButton.Size = new System.Drawing.Size(111, 28);
            this.lineDDAButton.TabIndex = 2;
            this.lineDDAButton.TabStop = true;
            this.lineDDAButton.Text = "Line DDA";
            this.lineDDAButton.UseVisualStyleBackColor = true;
            this.lineDDAButton.CheckedChanged += new System.EventHandler(this.lineDDAButton_CheckedChanged);
            // 
            // lineBresenhamButton
            // 
            this.lineBresenhamButton.AutoSize = true;
            this.lineBresenhamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineBresenhamButton.Location = new System.Drawing.Point(3, 100);
            this.lineBresenhamButton.Name = "lineBresenhamButton";
            this.lineBresenhamButton.Size = new System.Drawing.Size(169, 28);
            this.lineBresenhamButton.TabIndex = 3;
            this.lineBresenhamButton.TabStop = true;
            this.lineBresenhamButton.Text = "Line Bresenham";
            this.lineBresenhamButton.UseVisualStyleBackColor = true;
            this.lineBresenhamButton.CheckedChanged += new System.EventHandler(this.lineBresenhamButton_CheckedChanged);
            // 
            // circleBresenhamButton
            // 
            this.circleBresenhamButton.AutoSize = true;
            this.circleBresenhamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleBresenhamButton.Location = new System.Drawing.Point(3, 202);
            this.circleBresenhamButton.Name = "circleBresenhamButton";
            this.circleBresenhamButton.Size = new System.Drawing.Size(181, 28);
            this.circleBresenhamButton.TabIndex = 4;
            this.circleBresenhamButton.TabStop = true;
            this.circleBresenhamButton.Text = "Circle Bresenham";
            this.circleBresenhamButton.UseVisualStyleBackColor = true;
            this.circleBresenhamButton.CheckedChanged += new System.EventHandler(this.circleBresenhamButton_CheckedChanged);
            // 
            // circleConfigLabel
            // 
            this.circleConfigLabel.AutoSize = true;
            this.circleConfigLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.circleConfigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleConfigLabel.Location = new System.Drawing.Point(3, 267);
            this.circleConfigLabel.Name = "circleConfigLabel";
            this.circleConfigLabel.Size = new System.Drawing.Size(264, 29);
            this.circleConfigLabel.TabIndex = 5;
            this.circleConfigLabel.Text = "Circle parameters";
            this.circleConfigLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // circleRadiusLayout
            // 
            this.circleRadiusLayout.AutoSize = true;
            this.circleRadiusLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.circleRadiusLayout.Controls.Add(this.radiusLabel);
            this.circleRadiusLayout.Controls.Add(this.circleRadiusInput);
            this.circleRadiusLayout.Location = new System.Drawing.Point(3, 299);
            this.circleRadiusLayout.Name = "circleRadiusLayout";
            this.circleRadiusLayout.Size = new System.Drawing.Size(205, 34);
            this.circleRadiusLayout.TabIndex = 6;
            this.circleRadiusLayout.WrapContents = false;
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiusLabel.Location = new System.Drawing.Point(3, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(73, 34);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "Radius:";
            this.radiusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // circleRadiusInput
            // 
            this.circleRadiusInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.circleRadiusInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleRadiusInput.Location = new System.Drawing.Point(82, 3);
            this.circleRadiusInput.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.circleRadiusInput.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.circleRadiusInput.Name = "circleRadiusInput";
            this.circleRadiusInput.Size = new System.Drawing.Size(120, 28);
            this.circleRadiusInput.TabIndex = 2;
            this.circleRadiusInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorLabel.Location = new System.Drawing.Point(3, 336);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(264, 29);
            this.colorLabel.TabIndex = 7;
            this.colorLabel.Text = "Color (ARGB)";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorSelectionPanel
            // 
            this.colorSelectionPanel.AutoSize = true;
            this.colorSelectionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorSelectionPanel.Controls.Add(this.alphaEdit);
            this.colorSelectionPanel.Controls.Add(this.rEdit);
            this.colorSelectionPanel.Controls.Add(this.gEdit);
            this.colorSelectionPanel.Controls.Add(this.bEdit);
            this.colorSelectionPanel.Location = new System.Drawing.Point(3, 368);
            this.colorSelectionPanel.Name = "colorSelectionPanel";
            this.colorSelectionPanel.Size = new System.Drawing.Size(264, 34);
            this.colorSelectionPanel.TabIndex = 8;
            this.colorSelectionPanel.WrapContents = false;
            // 
            // alphaEdit
            // 
            this.alphaEdit.AutoSize = true;
            this.alphaEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.alphaEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphaEdit.Location = new System.Drawing.Point(3, 3);
            this.alphaEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alphaEdit.Name = "alphaEdit";
            this.alphaEdit.Size = new System.Drawing.Size(60, 28);
            this.alphaEdit.TabIndex = 2;
            this.alphaEdit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // rEdit
            // 
            this.rEdit.AutoSize = true;
            this.rEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.rEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rEdit.Location = new System.Drawing.Point(69, 3);
            this.rEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rEdit.Name = "rEdit";
            this.rEdit.Size = new System.Drawing.Size(60, 28);
            this.rEdit.TabIndex = 3;
            // 
            // gEdit
            // 
            this.gEdit.AutoSize = true;
            this.gEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.gEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gEdit.Location = new System.Drawing.Point(135, 3);
            this.gEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gEdit.Name = "gEdit";
            this.gEdit.Size = new System.Drawing.Size(60, 28);
            this.gEdit.TabIndex = 4;
            // 
            // bEdit
            // 
            this.bEdit.AutoSize = true;
            this.bEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEdit.Location = new System.Drawing.Point(201, 3);
            this.bEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(60, 28);
            this.bEdit.TabIndex = 5;
            // 
            // bitmapPanel
            // 
            this.bitmapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bitmapPanel.Location = new System.Drawing.Point(3, 51);
            this.bitmapPanel.Name = "bitmapPanel";
            this.bitmapPanel.Size = new System.Drawing.Size(861, 579);
            this.bitmapPanel.TabIndex = 2;
            this.bitmapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bitmapPanel_Paint);
            this.bitmapPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bitmapPanel_MouseClick);
            this.bitmapPanel.Resize += new System.EventHandler(this.bitmapPanel_Resize);
            // 
            // lastDrawCallTimeInfoLabel
            // 
            this.lastDrawCallTimeInfoLabel.AutoSize = true;
            this.lastDrawCallTimeInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastDrawCallTimeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastDrawCallTimeInfoLabel.Location = new System.Drawing.Point(491, 0);
            this.lastDrawCallTimeInfoLabel.Name = "lastDrawCallTimeInfoLabel";
            this.lastDrawCallTimeInfoLabel.Size = new System.Drawing.Size(167, 42);
            this.lastDrawCallTimeInfoLabel.TabIndex = 4;
            this.lastDrawCallTimeInfoLabel.Text = "Last draw call time:";
            this.lastDrawCallTimeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastDrawCallTimeLabel
            // 
            this.lastDrawCallTimeLabel.AutoSize = true;
            this.lastDrawCallTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastDrawCallTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastDrawCallTimeLabel.Location = new System.Drawing.Point(664, 0);
            this.lastDrawCallTimeLabel.Name = "lastDrawCallTimeLabel";
            this.lastDrawCallTimeLabel.Size = new System.Drawing.Size(20, 42);
            this.lastDrawCallTimeLabel.TabIndex = 5;
            this.lastDrawCallTimeLabel.Text = "0";
            this.lastDrawCallTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msLabel.Location = new System.Drawing.Point(690, 0);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(35, 42);
            this.msLabel.TabIndex = 6;
            this.msLabel.Text = "ns.";
            this.msLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // testPerformanceButton
            // 
            this.testPerformanceButton.AutoSize = true;
            this.testPerformanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testPerformanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testPerformanceButton.Location = new System.Drawing.Point(731, 3);
            this.testPerformanceButton.Name = "testPerformanceButton";
            this.testPerformanceButton.Size = new System.Drawing.Size(171, 36);
            this.testPerformanceButton.TabIndex = 7;
            this.testPerformanceButton.Text = "Test Performance";
            this.testPerformanceButton.UseVisualStyleBackColor = true;
            this.testPerformanceButton.Click += new System.EventHandler(this.testPerformanceButton_Click);
            // 
            // lineMidpointButton
            // 
            this.lineMidpointButton.AutoSize = true;
            this.lineMidpointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineMidpointButton.Location = new System.Drawing.Point(3, 134);
            this.lineMidpointButton.Name = "lineMidpointButton";
            this.lineMidpointButton.Size = new System.Drawing.Size(144, 28);
            this.lineMidpointButton.TabIndex = 9;
            this.lineMidpointButton.TabStop = true;
            this.lineMidpointButton.Text = "Line Midpoint";
            this.lineMidpointButton.UseVisualStyleBackColor = true;
            this.lineMidpointButton.CheckedChanged += new System.EventHandler(this.lineMidpointButton_CheckedChanged);
            // 
            // circleMidpointButton
            // 
            this.circleMidpointButton.AutoSize = true;
            this.circleMidpointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleMidpointButton.Location = new System.Drawing.Point(3, 236);
            this.circleMidpointButton.Name = "circleMidpointButton";
            this.circleMidpointButton.Size = new System.Drawing.Size(156, 28);
            this.circleMidpointButton.TabIndex = 10;
            this.circleMidpointButton.TabStop = true;
            this.circleMidpointButton.Text = "Circle Midpoint";
            this.circleMidpointButton.UseVisualStyleBackColor = true;
            this.circleMidpointButton.CheckedChanged += new System.EventHandler(this.circleMidpointButton_CheckedChanged);
            // 
            // lineByButton
            // 
            this.lineByButton.AutoSize = true;
            this.lineByButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineByButton.Location = new System.Drawing.Point(3, 168);
            this.lineByButton.Name = "lineByButton";
            this.lineByButton.Size = new System.Drawing.Size(93, 28);
            this.lineByButton.TabIndex = 11;
            this.lineByButton.TabStop = true;
            this.lineByButton.Text = "Line By";
            this.lineByButton.UseVisualStyleBackColor = true;
            this.lineByButton.CheckedChanged += new System.EventHandler(this.lineByButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1143, 633);
            this.Controls.Add(this.mainTableLayout);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Name = "MainForm";
            this.Text = "Konstantin Tomashevich CG Lab 4";
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.topMenuLayout.ResumeLayout(false);
            this.topMenuLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.circleRadiusLayout.ResumeLayout(false);
            this.circleRadiusLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadiusInput)).EndInit();
            this.colorSelectionPanel.ResumeLayout(false);
            this.colorSelectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel topMenuLayout;
        private System.Windows.Forms.FlowLayoutPanel toolsPanel;
        private System.Windows.Forms.Label sizeInfoLabel;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.NumericUpDown heightInput;
        private System.Windows.Forms.ToolTip topPanelTooltip;
        private System.Windows.Forms.Label toolsLabel;
        private System.Windows.Forms.RadioButton lineStepButton;
        private System.Windows.Forms.RadioButton lineDDAButton;
        private System.Windows.Forms.RadioButton lineBresenhamButton;
        private System.Windows.Forms.RadioButton circleBresenhamButton;
        private System.Windows.Forms.Label circleConfigLabel;
        private System.Windows.Forms.FlowLayoutPanel circleRadiusLayout;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.NumericUpDown circleRadiusInput;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.FlowLayoutPanel colorSelectionPanel;
        private System.Windows.Forms.NumericUpDown alphaEdit;
        private System.Windows.Forms.NumericUpDown rEdit;
        private System.Windows.Forms.NumericUpDown gEdit;
        private System.Windows.Forms.NumericUpDown bEdit;
        private System.Windows.Forms.Panel bitmapPanel;
        private System.Windows.Forms.Label lastDrawCallTimeInfoLabel;
        private System.Windows.Forms.Label lastDrawCallTimeLabel;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.Button testPerformanceButton;
        private System.Windows.Forms.RadioButton lineMidpointButton;
        private System.Windows.Forms.RadioButton circleMidpointButton;
        private System.Windows.Forms.RadioButton lineByButton;
    }
}

