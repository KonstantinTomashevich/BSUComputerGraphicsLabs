namespace Lab3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.windowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pictureView = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuPanelLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.modificatorsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addLabel = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.colorAInput = new System.Windows.Forms.NumericUpDown();
            this.colorRInput = new System.Windows.Forms.NumericUpDown();
            this.colorGInput = new System.Windows.Forms.NumericUpDown();
            this.colorBInput = new System.Windows.Forms.NumericUpDown();
            this.plusMinusPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.negateLabel = new System.Windows.Forms.Label();
            this.negateAlphaCheck = new System.Windows.Forms.CheckBox();
            this.negateButton = new System.Windows.Forms.Button();
            this.multiplyLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorAMultiplierInput = new System.Windows.Forms.NumericUpDown();
            this.colorRMultiplierInput = new System.Windows.Forms.NumericUpDown();
            this.colorGMultiplierInput = new System.Windows.Forms.NumericUpDown();
            this.colorBMultiplierInput = new System.Windows.Forms.NumericUpDown();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.powerLabel = new System.Windows.Forms.Label();
            this.powerInput = new System.Windows.Forms.NumericUpDown();
            this.powerAlphaCheck = new System.Windows.Forms.CheckBox();
            this.powerButton = new System.Windows.Forms.Button();
            this.logLabel = new System.Windows.Forms.Label();
            this.logAlphaCheck = new System.Windows.Forms.CheckBox();
            this.logButton = new System.Windows.Forms.Button();
            this.linearContrastLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.contrastMinLabel = new System.Windows.Forms.Label();
            this.contrastMinInput = new System.Windows.Forms.NumericUpDown();
            this.contrastMaxLabel = new System.Windows.Forms.Label();
            this.contrastMaxInput = new System.Windows.Forms.NumericUpDown();
            this.linearContrastAlphaCheck = new System.Windows.Forms.CheckBox();
            this.linearContrastButton = new System.Windows.Forms.Button();
            this.rgbHistogramLabel = new System.Windows.Forms.Label();
            this.rgbHistogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.separateEqualizeButton = new System.Windows.Forms.Button();
            this.brightnessHistogramLabel = new System.Windows.Forms.Label();
            this.brightnessHistogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equalizeLightnessButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.windowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.menuPanelLayout.SuspendLayout();
            this.modificatorsPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorAInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBInput)).BeginInit();
            this.plusMinusPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorAMultiplierInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRMultiplierInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGMultiplierInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBMultiplierInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerInput)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbHistogramChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessHistogramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // windowLayout
            // 
            this.windowLayout.ColumnCount = 2;
            this.windowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.windowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.windowLayout.Controls.Add(this.pictureView, 0, 1);
            this.windowLayout.Controls.Add(this.menuPanel, 0, 0);
            this.windowLayout.Controls.Add(this.modificatorsPanel, 1, 1);
            this.windowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowLayout.Location = new System.Drawing.Point(0, 0);
            this.windowLayout.Name = "windowLayout";
            this.windowLayout.RowCount = 2;
            this.windowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.windowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.windowLayout.Size = new System.Drawing.Size(930, 666);
            this.windowLayout.TabIndex = 0;
            // 
            // pictureView
            // 
            this.pictureView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureView.Location = new System.Drawing.Point(3, 49);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(566, 614);
            this.pictureView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureView.TabIndex = 0;
            this.pictureView.TabStop = false;
            // 
            // menuPanel
            // 
            this.menuPanel.AutoSize = true;
            this.menuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowLayout.SetColumnSpan(this.menuPanel, 2);
            this.menuPanel.Controls.Add(this.menuPanelLayout);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(3, 3);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(924, 40);
            this.menuPanel.TabIndex = 1;
            // 
            // menuPanelLayout
            // 
            this.menuPanelLayout.AutoSize = true;
            this.menuPanelLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanelLayout.Controls.Add(this.openButton);
            this.menuPanelLayout.Controls.Add(this.saveButton);
            this.menuPanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanelLayout.Location = new System.Drawing.Point(0, 0);
            this.menuPanelLayout.Name = "menuPanelLayout";
            this.menuPanelLayout.Size = new System.Drawing.Size(924, 40);
            this.menuPanelLayout.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.AutoSize = true;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.openButton.Location = new System.Drawing.Point(3, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 32);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.saveButton.Location = new System.Drawing.Point(84, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // modificatorsPanel
            // 
            this.modificatorsPanel.AutoScroll = true;
            this.modificatorsPanel.AutoSize = true;
            this.modificatorsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificatorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modificatorsPanel.Controls.Add(this.addLabel);
            this.modificatorsPanel.Controls.Add(this.colorPanel);
            this.modificatorsPanel.Controls.Add(this.plusMinusPanel);
            this.modificatorsPanel.Controls.Add(this.negateLabel);
            this.modificatorsPanel.Controls.Add(this.negateAlphaCheck);
            this.modificatorsPanel.Controls.Add(this.negateButton);
            this.modificatorsPanel.Controls.Add(this.multiplyLabel);
            this.modificatorsPanel.Controls.Add(this.flowLayoutPanel1);
            this.modificatorsPanel.Controls.Add(this.multiplyButton);
            this.modificatorsPanel.Controls.Add(this.powerLabel);
            this.modificatorsPanel.Controls.Add(this.powerInput);
            this.modificatorsPanel.Controls.Add(this.powerAlphaCheck);
            this.modificatorsPanel.Controls.Add(this.powerButton);
            this.modificatorsPanel.Controls.Add(this.logLabel);
            this.modificatorsPanel.Controls.Add(this.logAlphaCheck);
            this.modificatorsPanel.Controls.Add(this.logButton);
            this.modificatorsPanel.Controls.Add(this.linearContrastLabel);
            this.modificatorsPanel.Controls.Add(this.flowLayoutPanel2);
            this.modificatorsPanel.Controls.Add(this.linearContrastAlphaCheck);
            this.modificatorsPanel.Controls.Add(this.linearContrastButton);
            this.modificatorsPanel.Controls.Add(this.rgbHistogramLabel);
            this.modificatorsPanel.Controls.Add(this.rgbHistogramChart);
            this.modificatorsPanel.Controls.Add(this.separateEqualizeButton);
            this.modificatorsPanel.Controls.Add(this.brightnessHistogramLabel);
            this.modificatorsPanel.Controls.Add(this.brightnessHistogramChart);
            this.modificatorsPanel.Controls.Add(this.equalizeLightnessButton);
            this.modificatorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modificatorsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.modificatorsPanel.Location = new System.Drawing.Point(575, 49);
            this.modificatorsPanel.Name = "modificatorsPanel";
            this.modificatorsPanel.Size = new System.Drawing.Size(352, 614);
            this.modificatorsPanel.TabIndex = 2;
            this.modificatorsPanel.WrapContents = false;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.addLabel.Location = new System.Drawing.Point(3, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(145, 20);
            this.addLabel.TabIndex = 0;
            this.addLabel.Text = "Add color (ARGB)";
            // 
            // colorPanel
            // 
            this.colorPanel.AutoSize = true;
            this.colorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorPanel.Controls.Add(this.colorAInput);
            this.colorPanel.Controls.Add(this.colorRInput);
            this.colorPanel.Controls.Add(this.colorGInput);
            this.colorPanel.Controls.Add(this.colorBInput);
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorPanel.Location = new System.Drawing.Point(3, 23);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(344, 28);
            this.colorPanel.TabIndex = 1;
            this.colorPanel.WrapContents = false;
            // 
            // colorAInput
            // 
            this.colorAInput.AutoSize = true;
            this.colorAInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorAInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorAInput.Location = new System.Drawing.Point(3, 3);
            this.colorAInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorAInput.Name = "colorAInput";
            this.colorAInput.Size = new System.Drawing.Size(52, 22);
            this.colorAInput.TabIndex = 0;
            // 
            // colorRInput
            // 
            this.colorRInput.AutoSize = true;
            this.colorRInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorRInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorRInput.Location = new System.Drawing.Point(61, 3);
            this.colorRInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorRInput.Name = "colorRInput";
            this.colorRInput.Size = new System.Drawing.Size(52, 22);
            this.colorRInput.TabIndex = 1;
            // 
            // colorGInput
            // 
            this.colorGInput.AutoSize = true;
            this.colorGInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorGInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorGInput.Location = new System.Drawing.Point(119, 3);
            this.colorGInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorGInput.Name = "colorGInput";
            this.colorGInput.Size = new System.Drawing.Size(52, 22);
            this.colorGInput.TabIndex = 2;
            // 
            // colorBInput
            // 
            this.colorBInput.AutoSize = true;
            this.colorBInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorBInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorBInput.Location = new System.Drawing.Point(177, 3);
            this.colorBInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorBInput.Name = "colorBInput";
            this.colorBInput.Size = new System.Drawing.Size(52, 22);
            this.colorBInput.TabIndex = 3;
            // 
            // plusMinusPanel
            // 
            this.plusMinusPanel.AutoSize = true;
            this.plusMinusPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plusMinusPanel.Controls.Add(this.plusButton);
            this.plusMinusPanel.Controls.Add(this.minusButton);
            this.plusMinusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.plusMinusPanel.Location = new System.Drawing.Point(3, 57);
            this.plusMinusPanel.Name = "plusMinusPanel";
            this.plusMinusPanel.Size = new System.Drawing.Size(344, 38);
            this.plusMinusPanel.TabIndex = 7;
            // 
            // plusButton
            // 
            this.plusButton.AutoSize = true;
            this.plusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.plusButton.Location = new System.Drawing.Point(3, 3);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(31, 32);
            this.plusButton.TabIndex = 4;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.AutoSize = true;
            this.minusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.minusButton.Location = new System.Drawing.Point(40, 3);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(27, 32);
            this.minusButton.TabIndex = 5;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // negateLabel
            // 
            this.negateLabel.AutoSize = true;
            this.negateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.negateLabel.Location = new System.Drawing.Point(3, 98);
            this.negateLabel.Name = "negateLabel";
            this.negateLabel.Size = new System.Drawing.Size(112, 20);
            this.negateLabel.TabIndex = 2;
            this.negateLabel.Text = "Negate image";
            // 
            // negateAlphaCheck
            // 
            this.negateAlphaCheck.AutoSize = true;
            this.negateAlphaCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.negateAlphaCheck.Location = new System.Drawing.Point(3, 121);
            this.negateAlphaCheck.Name = "negateAlphaCheck";
            this.negateAlphaCheck.Size = new System.Drawing.Size(123, 21);
            this.negateAlphaCheck.TabIndex = 6;
            this.negateAlphaCheck.Text = "Negate alpha?";
            this.negateAlphaCheck.UseVisualStyleBackColor = true;
            // 
            // negateButton
            // 
            this.negateButton.AutoSize = true;
            this.negateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.negateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.negateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.negateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.negateButton.Location = new System.Drawing.Point(3, 148);
            this.negateButton.Name = "negateButton";
            this.negateButton.Size = new System.Drawing.Size(344, 29);
            this.negateButton.TabIndex = 5;
            this.negateButton.Text = "Negate";
            this.negateButton.UseVisualStyleBackColor = false;
            this.negateButton.Click += new System.EventHandler(this.negateButton_Click);
            // 
            // multiplyLabel
            // 
            this.multiplyLabel.AutoSize = true;
            this.multiplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.multiplyLabel.Location = new System.Drawing.Point(3, 180);
            this.multiplyLabel.Name = "multiplyLabel";
            this.multiplyLabel.Size = new System.Drawing.Size(173, 20);
            this.multiplyLabel.TabIndex = 8;
            this.multiplyLabel.Text = "Mutliply color (ARGB)";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.colorAMultiplierInput);
            this.flowLayoutPanel1.Controls.Add(this.colorRMultiplierInput);
            this.flowLayoutPanel1.Controls.Add(this.colorGMultiplierInput);
            this.flowLayoutPanel1.Controls.Add(this.colorBMultiplierInput);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 28);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // colorAMultiplierInput
            // 
            this.colorAMultiplierInput.AutoSize = true;
            this.colorAMultiplierInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorAMultiplierInput.DecimalPlaces = 3;
            this.colorAMultiplierInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorAMultiplierInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.colorAMultiplierInput.Location = new System.Drawing.Point(3, 3);
            this.colorAMultiplierInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorAMultiplierInput.Name = "colorAMultiplierInput";
            this.colorAMultiplierInput.Size = new System.Drawing.Size(80, 22);
            this.colorAMultiplierInput.TabIndex = 0;
            this.colorAMultiplierInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colorRMultiplierInput
            // 
            this.colorRMultiplierInput.AutoSize = true;
            this.colorRMultiplierInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorRMultiplierInput.DecimalPlaces = 3;
            this.colorRMultiplierInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorRMultiplierInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.colorRMultiplierInput.Location = new System.Drawing.Point(89, 3);
            this.colorRMultiplierInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorRMultiplierInput.Name = "colorRMultiplierInput";
            this.colorRMultiplierInput.Size = new System.Drawing.Size(80, 22);
            this.colorRMultiplierInput.TabIndex = 1;
            this.colorRMultiplierInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colorGMultiplierInput
            // 
            this.colorGMultiplierInput.AutoSize = true;
            this.colorGMultiplierInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorGMultiplierInput.DecimalPlaces = 3;
            this.colorGMultiplierInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorGMultiplierInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.colorGMultiplierInput.Location = new System.Drawing.Point(175, 3);
            this.colorGMultiplierInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorGMultiplierInput.Name = "colorGMultiplierInput";
            this.colorGMultiplierInput.Size = new System.Drawing.Size(80, 22);
            this.colorGMultiplierInput.TabIndex = 2;
            this.colorGMultiplierInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colorBMultiplierInput
            // 
            this.colorBMultiplierInput.AutoSize = true;
            this.colorBMultiplierInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorBMultiplierInput.DecimalPlaces = 3;
            this.colorBMultiplierInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.colorBMultiplierInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.colorBMultiplierInput.Location = new System.Drawing.Point(261, 3);
            this.colorBMultiplierInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorBMultiplierInput.Name = "colorBMultiplierInput";
            this.colorBMultiplierInput.Size = new System.Drawing.Size(80, 22);
            this.colorBMultiplierInput.TabIndex = 3;
            this.colorBMultiplierInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // multiplyButton
            // 
            this.multiplyButton.AutoSize = true;
            this.multiplyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiplyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.multiplyButton.Location = new System.Drawing.Point(3, 237);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(344, 29);
            this.multiplyButton.TabIndex = 10;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.powerLabel.Location = new System.Drawing.Point(3, 269);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(129, 20);
            this.powerLabel.TabIndex = 11;
            this.powerLabel.Text = "Power elements";
            // 
            // powerInput
            // 
            this.powerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.powerInput.DecimalPlaces = 3;
            this.powerInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.powerInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.powerInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.powerInput.Location = new System.Drawing.Point(3, 292);
            this.powerInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.powerInput.Name = "powerInput";
            this.powerInput.Size = new System.Drawing.Size(344, 22);
            this.powerInput.TabIndex = 13;
            this.powerInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // powerAlphaCheck
            // 
            this.powerAlphaCheck.AutoSize = true;
            this.powerAlphaCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.powerAlphaCheck.Location = new System.Drawing.Point(3, 320);
            this.powerAlphaCheck.Name = "powerAlphaCheck";
            this.powerAlphaCheck.Size = new System.Drawing.Size(116, 21);
            this.powerAlphaCheck.TabIndex = 12;
            this.powerAlphaCheck.Text = "Power alpha?";
            this.powerAlphaCheck.UseVisualStyleBackColor = true;
            // 
            // powerButton
            // 
            this.powerButton.AutoSize = true;
            this.powerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.powerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.powerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.powerButton.Location = new System.Drawing.Point(3, 347);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(344, 29);
            this.powerButton.TabIndex = 14;
            this.powerButton.Text = "Power";
            this.powerButton.UseVisualStyleBackColor = false;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.logLabel.Location = new System.Drawing.Point(3, 379);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(110, 20);
            this.logLabel.TabIndex = 15;
            this.logLabel.Text = "Log elements";
            // 
            // logAlphaCheck
            // 
            this.logAlphaCheck.AutoSize = true;
            this.logAlphaCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.logAlphaCheck.Location = new System.Drawing.Point(3, 402);
            this.logAlphaCheck.Name = "logAlphaCheck";
            this.logAlphaCheck.Size = new System.Drawing.Size(101, 21);
            this.logAlphaCheck.TabIndex = 16;
            this.logAlphaCheck.Text = "Log alpha?";
            this.logAlphaCheck.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            this.logButton.AutoSize = true;
            this.logButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.logButton.Location = new System.Drawing.Point(3, 429);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(344, 29);
            this.logButton.TabIndex = 17;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // linearContrastLabel
            // 
            this.linearContrastLabel.AutoSize = true;
            this.linearContrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linearContrastLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.linearContrastLabel.Location = new System.Drawing.Point(3, 461);
            this.linearContrastLabel.Name = "linearContrastLabel";
            this.linearContrastLabel.Size = new System.Drawing.Size(122, 20);
            this.linearContrastLabel.TabIndex = 18;
            this.linearContrastLabel.Text = "Linear contrast";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.contrastMinLabel);
            this.flowLayoutPanel2.Controls.Add(this.contrastMinInput);
            this.flowLayoutPanel2.Controls.Add(this.contrastMaxLabel);
            this.flowLayoutPanel2.Controls.Add(this.contrastMaxInput);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 484);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(344, 28);
            this.flowLayoutPanel2.TabIndex = 19;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // contrastMinLabel
            // 
            this.contrastMinLabel.AutoSize = true;
            this.contrastMinLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.contrastMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contrastMinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.contrastMinLabel.Location = new System.Drawing.Point(3, 0);
            this.contrastMinLabel.Name = "contrastMinLabel";
            this.contrastMinLabel.Size = new System.Drawing.Size(34, 28);
            this.contrastMinLabel.TabIndex = 16;
            this.contrastMinLabel.Text = "Min:";
            this.contrastMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contrastMinInput
            // 
            this.contrastMinInput.AutoSize = true;
            this.contrastMinInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.contrastMinInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.contrastMinInput.Location = new System.Drawing.Point(43, 3);
            this.contrastMinInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.contrastMinInput.Name = "contrastMinInput";
            this.contrastMinInput.Size = new System.Drawing.Size(52, 22);
            this.contrastMinInput.TabIndex = 0;
            // 
            // contrastMaxLabel
            // 
            this.contrastMaxLabel.AutoSize = true;
            this.contrastMaxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.contrastMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contrastMaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.contrastMaxLabel.Location = new System.Drawing.Point(101, 0);
            this.contrastMaxLabel.Name = "contrastMaxLabel";
            this.contrastMaxLabel.Size = new System.Drawing.Size(37, 28);
            this.contrastMaxLabel.TabIndex = 17;
            this.contrastMaxLabel.Text = "Max:";
            this.contrastMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contrastMaxInput
            // 
            this.contrastMaxInput.AutoSize = true;
            this.contrastMaxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.contrastMaxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.contrastMaxInput.Location = new System.Drawing.Point(144, 3);
            this.contrastMaxInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.contrastMaxInput.Name = "contrastMaxInput";
            this.contrastMaxInput.Size = new System.Drawing.Size(52, 22);
            this.contrastMaxInput.TabIndex = 3;
            this.contrastMaxInput.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // linearContrastAlphaCheck
            // 
            this.linearContrastAlphaCheck.AutoSize = true;
            this.linearContrastAlphaCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.linearContrastAlphaCheck.Location = new System.Drawing.Point(3, 518);
            this.linearContrastAlphaCheck.Name = "linearContrastAlphaCheck";
            this.linearContrastAlphaCheck.Size = new System.Drawing.Size(113, 21);
            this.linearContrastAlphaCheck.TabIndex = 21;
            this.linearContrastAlphaCheck.Text = "Affect alpha?";
            this.linearContrastAlphaCheck.UseVisualStyleBackColor = true;
            // 
            // linearContrastButton
            // 
            this.linearContrastButton.AutoSize = true;
            this.linearContrastButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.linearContrastButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.linearContrastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linearContrastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linearContrastButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.linearContrastButton.Location = new System.Drawing.Point(3, 545);
            this.linearContrastButton.Name = "linearContrastButton";
            this.linearContrastButton.Size = new System.Drawing.Size(344, 29);
            this.linearContrastButton.TabIndex = 20;
            this.linearContrastButton.Text = "Linear Contrast";
            this.linearContrastButton.UseVisualStyleBackColor = false;
            this.linearContrastButton.Click += new System.EventHandler(this.linearContrastButton_Click);
            // 
            // rgbHistogramLabel
            // 
            this.rgbHistogramLabel.AutoSize = true;
            this.rgbHistogramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rgbHistogramLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rgbHistogramLabel.Location = new System.Drawing.Point(3, 577);
            this.rgbHistogramLabel.Name = "rgbHistogramLabel";
            this.rgbHistogramLabel.Size = new System.Drawing.Size(129, 20);
            this.rgbHistogramLabel.TabIndex = 22;
            this.rgbHistogramLabel.Text = "RGB Histogram";
            // 
            // rgbHistogramChart
            // 
            this.rgbHistogramChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "RArea";
            chartArea2.Name = "BArea";
            chartArea3.Name = "GArea";
            this.rgbHistogramChart.ChartAreas.Add(chartArea1);
            this.rgbHistogramChart.ChartAreas.Add(chartArea2);
            this.rgbHistogramChart.ChartAreas.Add(chartArea3);
            this.rgbHistogramChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.rgbHistogramChart.Location = new System.Drawing.Point(3, 600);
            this.rgbHistogramChart.Name = "rgbHistogramChart";
            this.rgbHistogramChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.rgbHistogramChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Blue};
            series1.ChartArea = "RArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Name = "Series1";
            series2.ChartArea = "BArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Name = "Series2";
            series3.ChartArea = "GArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Name = "Series3";
            this.rgbHistogramChart.Series.Add(series1);
            this.rgbHistogramChart.Series.Add(series2);
            this.rgbHistogramChart.Series.Add(series3);
            this.rgbHistogramChart.Size = new System.Drawing.Size(344, 500);
            this.rgbHistogramChart.TabIndex = 23;
            // 
            // separateEqualizeButton
            // 
            this.separateEqualizeButton.AutoSize = true;
            this.separateEqualizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.separateEqualizeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.separateEqualizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.separateEqualizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.separateEqualizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.separateEqualizeButton.Location = new System.Drawing.Point(3, 1106);
            this.separateEqualizeButton.Name = "separateEqualizeButton";
            this.separateEqualizeButton.Size = new System.Drawing.Size(344, 29);
            this.separateEqualizeButton.TabIndex = 24;
            this.separateEqualizeButton.Text = "Equalize Components Separately";
            this.separateEqualizeButton.UseVisualStyleBackColor = false;
            this.separateEqualizeButton.Click += new System.EventHandler(this.separateEqualizeButton_Click);
            // 
            // brightnessHistogramLabel
            // 
            this.brightnessHistogramLabel.AutoSize = true;
            this.brightnessHistogramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brightnessHistogramLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.brightnessHistogramLabel.Location = new System.Drawing.Point(3, 1138);
            this.brightnessHistogramLabel.Name = "brightnessHistogramLabel";
            this.brightnessHistogramLabel.Size = new System.Drawing.Size(213, 20);
            this.brightnessHistogramLabel.TabIndex = 25;
            this.brightnessHistogramLabel.Text = "HSV Brightness Histogram";
            // 
            // brightnessHistogramChart
            // 
            this.brightnessHistogramChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "BrightnessArea";
            this.brightnessHistogramChart.ChartAreas.Add(chartArea4);
            this.brightnessHistogramChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.brightnessHistogramChart.Location = new System.Drawing.Point(3, 1161);
            this.brightnessHistogramChart.Name = "brightnessHistogramChart";
            this.brightnessHistogramChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.brightnessHistogramChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))))};
            series4.ChartArea = "BrightnessArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Name = "Series1";
            this.brightnessHistogramChart.Series.Add(series4);
            this.brightnessHistogramChart.Size = new System.Drawing.Size(344, 170);
            this.brightnessHistogramChart.TabIndex = 26;
            // 
            // equalizeLightnessButton
            // 
            this.equalizeLightnessButton.AutoSize = true;
            this.equalizeLightnessButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.equalizeLightnessButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.equalizeLightnessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalizeLightnessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalizeLightnessButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.equalizeLightnessButton.Location = new System.Drawing.Point(3, 1337);
            this.equalizeLightnessButton.Name = "equalizeLightnessButton";
            this.equalizeLightnessButton.Size = new System.Drawing.Size(344, 29);
            this.equalizeLightnessButton.TabIndex = 27;
            this.equalizeLightnessButton.Text = "Equalize Brightness";
            this.equalizeLightnessButton.UseVisualStyleBackColor = false;
            this.equalizeLightnessButton.Click += new System.EventHandler(this.equalizeBrightnessButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "PNG|*.png|JPEG|.jpg|BMP|*.bmp|TIFF|*.tiff|All files|*.*";
            this.openImageDialog.Title = "Select image to edit...";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.DefaultExt = "png";
            this.saveImageDialog.Filter = "PNG|*.png|JPEG|.jpg|BMP|*.bmp|TIFF|*.tiff|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(930, 666);
            this.Controls.Add(this.windowLayout);
            this.Name = "MainForm";
            this.Text = "Konstantin Tomashevich CG Lab 3";
            this.windowLayout.ResumeLayout(false);
            this.windowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.menuPanelLayout.ResumeLayout(false);
            this.menuPanelLayout.PerformLayout();
            this.modificatorsPanel.ResumeLayout(false);
            this.modificatorsPanel.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorAInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBInput)).EndInit();
            this.plusMinusPanel.ResumeLayout(false);
            this.plusMinusPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorAMultiplierInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRMultiplierInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGMultiplierInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBMultiplierInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerInput)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbHistogramChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessHistogramChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel windowLayout;
        private System.Windows.Forms.PictureBox pictureView;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.FlowLayoutPanel menuPanelLayout;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.FlowLayoutPanel modificatorsPanel;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.FlowLayoutPanel colorPanel;
        private System.Windows.Forms.NumericUpDown colorAInput;
        private System.Windows.Forms.NumericUpDown colorRInput;
        private System.Windows.Forms.NumericUpDown colorGInput;
        private System.Windows.Forms.NumericUpDown colorBInput;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label negateLabel;
        private System.Windows.Forms.Button negateButton;
        private System.Windows.Forms.FlowLayoutPanel plusMinusPanel;
        private System.Windows.Forms.CheckBox negateAlphaCheck;
        private System.Windows.Forms.Label multiplyLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown colorAMultiplierInput;
        private System.Windows.Forms.NumericUpDown colorRMultiplierInput;
        private System.Windows.Forms.NumericUpDown colorGMultiplierInput;
        private System.Windows.Forms.NumericUpDown colorBMultiplierInput;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.CheckBox powerAlphaCheck;
        private System.Windows.Forms.NumericUpDown powerInput;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.CheckBox logAlphaCheck;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label linearContrastLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label contrastMinLabel;
        private System.Windows.Forms.NumericUpDown contrastMinInput;
        private System.Windows.Forms.Label contrastMaxLabel;
        private System.Windows.Forms.NumericUpDown contrastMaxInput;
        private System.Windows.Forms.Button linearContrastButton;
        private System.Windows.Forms.CheckBox linearContrastAlphaCheck;
        private System.Windows.Forms.Label rgbHistogramLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart rgbHistogramChart;
        private System.Windows.Forms.Button separateEqualizeButton;
        private System.Windows.Forms.Label brightnessHistogramLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart brightnessHistogramChart;
        private System.Windows.Forms.Button equalizeLightnessButton;
    }
}

