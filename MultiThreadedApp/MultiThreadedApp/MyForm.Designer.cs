namespace MultiThreadedApp
{
  partial class MyForm
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
      this.folderButton = new System.Windows.Forms.Button();
      this.folderBox = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.filesListBox = new System.Windows.Forms.ListBox();
      this.useInProcess = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Controls.Add(this.folderButton, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.folderBox, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.filesListBox, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.useInProcess, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 249);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // folderButton
      // 
      this.folderButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.folderButton.Location = new System.Drawing.Point(366, 3);
      this.folderButton.Name = "folderButton";
      this.folderButton.Size = new System.Drawing.Size(24, 24);
      this.folderButton.TabIndex = 0;
      this.folderButton.Text = "...";
      this.folderButton.UseVisualStyleBackColor = true;
      this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
      // 
      // folderBox
      // 
      this.folderBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.folderBox.Location = new System.Drawing.Point(3, 3);
      this.folderBox.Name = "folderBox";
      this.folderBox.ReadOnly = true;
      this.folderBox.Size = new System.Drawing.Size(357, 20);
      this.folderBox.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.tableLayoutPanel1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(7);
      this.panel1.Size = new System.Drawing.Size(407, 263);
      this.panel1.TabIndex = 1;
      // 
      // filesListBox
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.filesListBox, 2);
      this.filesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.filesListBox.FormattingEnabled = true;
      this.filesListBox.Location = new System.Drawing.Point(3, 63);
      this.filesListBox.Name = "filesListBox";
      this.filesListBox.Size = new System.Drawing.Size(387, 183);
      this.filesListBox.TabIndex = 2;
      // 
      // useInProcess
      // 
      this.useInProcess.AutoSize = true;
      this.useInProcess.Location = new System.Drawing.Point(3, 33);
      this.useInProcess.Name = "useInProcess";
      this.useInProcess.Size = new System.Drawing.Size(150, 17);
      this.useInProcess.TabIndex = 3;
      this.useInProcess.Text = "Use Apprentice in-process";
      this.useInProcess.UseVisualStyleBackColor = true;
      // 
      // MyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(407, 263);
      this.Controls.Add(this.panel1);
      this.Name = "MyForm";
      this.Text = "File Properties";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button folderButton;
    private System.Windows.Forms.TextBox folderBox;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ListBox filesListBox;
    private System.Windows.Forms.CheckBox useInProcess;
  }
}

