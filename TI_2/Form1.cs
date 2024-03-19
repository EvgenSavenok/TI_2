using System;
using System.Windows.Forms;

namespace TI_2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      
    }

    private void startStateTB_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
      {
        e.Handled = true;
      }
      if (e.KeyChar == 22)
        e.Handled = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      startStateTB.ContextMenu = new ContextMenu();
      keyDataGridView.ColumnHeadersVisible = false; 
      keyDataGridView.RowHeadersVisible = false;
      keyDataGridView.Columns.Add("Column1", "Column1 Header");
      keyDataGridView.Columns.Add("Column2", "Column2 Header");
      keyDataGridView.Columns.Add("Column3", "Column3 Header");

      // Добавляем строки с данными
      keyDataGridView.Rows.Add("Value1", "Value2", "Value3");
      keyDataGridView.Rows.Add("Value4", "Value5", "Value6");
      keyDataGridView.Rows.Add("Value7", "Value8", "Value9");
    }
  }
}
