namespace TI_2
{
  partial class Form1
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.startStateTB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.keyDataGridView = new System.Windows.Forms.DataGridView();
      this.cipherBtn = new System.Windows.Forms.Button();
      this.decipherBtn = new System.Windows.Forms.Button();
      this.getKeyBtn = new System.Windows.Forms.Button();
      this.sourceDataGrid = new System.Windows.Forms.DataGridView();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.label3 = new System.Windows.Forms.Label();
      this.cipherGrid = new System.Windows.Forms.DataGridView();
      this.label4 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.keyDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sourceDataGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cipherGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.ToolStripMenuItem });
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1123, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // ToolStripMenuItem
      // 
      this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.открытьToolStripMenuItem, this.сохранитьToolStripMenuItem });
      this.ToolStripMenuItem.Name = "ToolStripMenuItem";
      this.ToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
      this.ToolStripMenuItem.Text = "Файл";
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
      this.сохранитьToolStripMenuItem.Text = "Сохранить";
      this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
      // 
      // startStateTB
      // 
      this.startStateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startStateTB.Location = new System.Drawing.Point(43, 80);
      this.startStateTB.MaxLength = 23;
      this.startStateTB.Name = "startStateTB";
      this.startStateTB.Size = new System.Drawing.Size(325, 34);
      this.startStateTB.TabIndex = 1;
      this.startStateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startStateTB_KeyPress);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(43, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(451, 33);
      this.label1.TabIndex = 2;
      this.label1.Text = "Начальное состояние регистра:";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(513, 135);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Ключ:";
      // 
      // keyDataGridView
      // 
      this.keyDataGridView.AllowUserToAddRows = false;
      this.keyDataGridView.AllowUserToDeleteRows = false;
      this.keyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.keyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.keyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.keyDataGridView.Location = new System.Drawing.Point(433, 183);
      this.keyDataGridView.Name = "keyDataGridView";
      this.keyDataGridView.ReadOnly = true;
      this.keyDataGridView.RowTemplate.Height = 24;
      this.keyDataGridView.Size = new System.Drawing.Size(261, 275);
      this.keyDataGridView.TabIndex = 5;
      // 
      // cipherBtn
      // 
      this.cipherBtn.Enabled = false;
      this.cipherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cipherBtn.Location = new System.Drawing.Point(43, 481);
      this.cipherBtn.Name = "cipherBtn";
      this.cipherBtn.Size = new System.Drawing.Size(261, 55);
      this.cipherBtn.TabIndex = 6;
      this.cipherBtn.Text = "Зашифровать";
      this.cipherBtn.UseVisualStyleBackColor = true;
      this.cipherBtn.Click += new System.EventHandler(this.cipherBtn_Click);
      // 
      // decipherBtn
      // 
      this.decipherBtn.Enabled = false;
      this.decipherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.decipherBtn.Location = new System.Drawing.Point(815, 481);
      this.decipherBtn.Name = "decipherBtn";
      this.decipherBtn.Size = new System.Drawing.Size(261, 55);
      this.decipherBtn.TabIndex = 7;
      this.decipherBtn.Text = "Дешифровать";
      this.decipherBtn.UseVisualStyleBackColor = true;
      this.decipherBtn.Click += new System.EventHandler(this.decipherBtn_Click);
      // 
      // getKeyBtn
      // 
      this.getKeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.getKeyBtn.Location = new System.Drawing.Point(433, 481);
      this.getKeyBtn.Name = "getKeyBtn";
      this.getKeyBtn.Size = new System.Drawing.Size(261, 55);
      this.getKeyBtn.TabIndex = 8;
      this.getKeyBtn.Text = "Получить ключ";
      this.getKeyBtn.UseVisualStyleBackColor = true;
      this.getKeyBtn.Click += new System.EventHandler(this.getKeyBtn_Click);
      // 
      // sourceDataGrid
      // 
      this.sourceDataGrid.AllowUserToAddRows = false;
      this.sourceDataGrid.AllowUserToDeleteRows = false;
      this.sourceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.sourceDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.sourceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.sourceDataGrid.Location = new System.Drawing.Point(43, 183);
      this.sourceDataGrid.Name = "sourceDataGrid";
      this.sourceDataGrid.ReadOnly = true;
      this.sourceDataGrid.RowTemplate.Height = 24;
      this.sourceDataGrid.Size = new System.Drawing.Size(261, 275);
      this.sourceDataGrid.TabIndex = 9;
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "openFileDialog";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.Filter = "All files (*.*)|*.*";
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(65, 135);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(213, 30);
      this.label3.TabIndex = 10;
      this.label3.Text = "Исходный файл:";
      // 
      // cipherGrid
      // 
      this.cipherGrid.AllowUserToAddRows = false;
      this.cipherGrid.AllowUserToDeleteRows = false;
      this.cipherGrid.AllowUserToResizeRows = false;
      this.cipherGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.cipherGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.cipherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cipherGrid.Location = new System.Drawing.Point(815, 183);
      this.cipherGrid.Name = "cipherGrid";
      this.cipherGrid.ReadOnly = true;
      this.cipherGrid.RowTemplate.Height = 24;
      this.cipherGrid.Size = new System.Drawing.Size(261, 275);
      this.cipherGrid.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(798, 135);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(294, 37);
      this.label4.TabIndex = 12;
      this.label4.Text = "Зашифрованный файл:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1123, 565);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cipherGrid);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.sourceDataGrid);
      this.Controls.Add(this.getKeyBtn);
      this.Controls.Add(this.decipherBtn);
      this.Controls.Add(this.cipherBtn);
      this.Controls.Add(this.keyDataGridView);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.startStateTB);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ТИ_2";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.keyDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sourceDataGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cipherGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.DataGridView cipherGrid;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;

    private System.Windows.Forms.DataGridView sourceDataGrid;

    private System.Windows.Forms.Button getKeyBtn;

    private System.Windows.Forms.Button cipherBtn;
    private System.Windows.Forms.Button decipherBtn;

    private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;

    private System.Windows.Forms.DataGridView keyDataGridView;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox startStateTB;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;

    #endregion
  }
}

