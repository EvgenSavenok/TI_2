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

    private void FillDataGrid(string data)
    { 
      const int numOfCols = 27;
      int curNumOfCols;
      if (data.Length > numOfCols)
        curNumOfCols = numOfCols;
      else
        curNumOfCols = data.Length;
      for (int i = 0; i < curNumOfCols; i++)
        keyDataGridView.Columns.Add("", "");
      int rowIndex = 0;
      for (int i = 0; i < data.Length; i++)
      {
        if (i % curNumOfCols == 0)
        {
          rowIndex++;
          keyDataGridView.Rows.Add();
        }
        keyDataGridView.Rows[rowIndex - 1].Cells[i % curNumOfCols].Value = data[i].ToString();
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      startStateTB.ContextMenu = new ContextMenu();
      keyDataGridView.ColumnHeadersVisible = false;
      keyDataGridView.RowHeadersVisible = false;
      string data = "1010101010001010100010101011001";
      FillDataGrid(data);
    }
  }
}
