﻿namespace TI_2
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
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.startStateTB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.файлToolStripMenuItem });
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.сохранитьToolStripMenuItem });
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
      this.сохранитьToolStripMenuItem.Text = "Сохранить";
      // 
      // startStateTB
      // 
      this.startStateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startStateTB.Location = new System.Drawing.Point(12, 91);
      this.startStateTB.MaxLength = 23;
      this.startStateTB.Name = "startStateTB";
      this.startStateTB.Size = new System.Drawing.Size(325, 34);
      this.startStateTB.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(451, 33);
      this.label1.TabIndex = 2;
      this.label1.Text = "Начальное состояние регистра:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.startStateTB);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "ТИ_2";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.TextBox startStateTB;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;

    #endregion
  }
}
