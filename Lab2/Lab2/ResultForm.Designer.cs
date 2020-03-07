namespace Lab2
{
    partial class ResultForm
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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.currentDirInfoLabel = new System.Windows.Forms.Label();
            this.scanOtherButton = new System.Windows.Forms.Button();
            this.currentDirLabel = new System.Windows.Forms.Label();
            this.readingProgressBar = new System.Windows.Forms.ProgressBar();
            this.informationView = new System.Windows.Forms.TreeView();
            this.mainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.AutoSize = true;
            this.mainTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainTable.ColumnCount = 3;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.74627F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.25373F));
            this.mainTable.Controls.Add(this.currentDirInfoLabel, 0, 0);
            this.mainTable.Controls.Add(this.scanOtherButton, 2, 0);
            this.mainTable.Controls.Add(this.currentDirLabel, 1, 0);
            this.mainTable.Controls.Add(this.readingProgressBar, 0, 2);
            this.mainTable.Controls.Add(this.informationView, 0, 1);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 3;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTable.Size = new System.Drawing.Size(800, 450);
            this.mainTable.TabIndex = 0;
            // 
            // currentDirInfoLabel
            // 
            this.currentDirInfoLabel.AutoSize = true;
            this.currentDirInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentDirInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDirInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.currentDirInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.currentDirInfoLabel.Name = "currentDirInfoLabel";
            this.currentDirInfoLabel.Size = new System.Drawing.Size(94, 48);
            this.currentDirInfoLabel.TabIndex = 0;
            this.currentDirInfoLabel.Text = "Current dir:";
            this.currentDirInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scanOtherButton
            // 
            this.scanOtherButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanOtherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanOtherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scanOtherButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.scanOtherButton.Location = new System.Drawing.Point(598, 3);
            this.scanOtherButton.Name = "scanOtherButton";
            this.scanOtherButton.Size = new System.Drawing.Size(199, 42);
            this.scanOtherButton.TabIndex = 1;
            this.scanOtherButton.Text = "Scan other";
            this.scanOtherButton.UseVisualStyleBackColor = true;
            this.scanOtherButton.Click += new System.EventHandler(this.scanOtherButton_Click);
            // 
            // currentDirLabel
            // 
            this.currentDirLabel.AutoSize = true;
            this.currentDirLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDirLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.currentDirLabel.Location = new System.Drawing.Point(103, 0);
            this.currentDirLabel.Name = "currentDirLabel";
            this.currentDirLabel.Size = new System.Drawing.Size(489, 48);
            this.currentDirLabel.TabIndex = 2;
            this.currentDirLabel.Text = "Dir not selected";
            this.currentDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // readingProgressBar
            // 
            this.mainTable.SetColumnSpan(this.readingProgressBar, 3);
            this.readingProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readingProgressBar.Location = new System.Drawing.Point(3, 424);
            this.readingProgressBar.Name = "readingProgressBar";
            this.readingProgressBar.Size = new System.Drawing.Size(794, 23);
            this.readingProgressBar.TabIndex = 3;
            this.readingProgressBar.Value = 100;
            this.readingProgressBar.Visible = false;
            // 
            // informationView
            // 
            this.informationView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainTable.SetColumnSpan(this.informationView, 3);
            this.informationView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.informationView.Location = new System.Drawing.Point(3, 51);
            this.informationView.Name = "informationView";
            this.informationView.Size = new System.Drawing.Size(794, 367);
            this.informationView.TabIndex = 4;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTable);
            this.Name = "ResultForm";
            this.Text = "Konstantn Tomashevich CG Lab 2";
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.Label currentDirInfoLabel;
        private System.Windows.Forms.Button scanOtherButton;
        private System.Windows.Forms.Label currentDirLabel;
        private System.Windows.Forms.ProgressBar readingProgressBar;
        private System.Windows.Forms.TreeView informationView;
    }
}

