using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace TI_2
{
  public partial class Form1 : Form
  {
    private string _startStateOfRegister;
    private byte[] _fileBytes;
    private string _fileExtension;
    List<List<int>> _bitsList = new List<List<int>>();
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
      sourceDataGrid.ColumnHeadersVisible = false;
      sourceDataGrid.RowHeadersVisible = false;
    }
    private void ReadFromFile(string path)
    {
      using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read)) {
        using (var reader = new BinaryReader(stream)) {
          try
          {
            _fileBytes = reader.ReadBytes((int) stream.Length);
            _fileExtension = Path.GetExtension(path);
          }
          catch (Exception)
          {
            Console.WriteLine("Не удалось прочитать файл!");
          }
        }          
      }
    }
    
    private void FillSourceDataGrid(byte[] data, DataGridView grid)
    { 
      const int maxBytesToShow = 100; 
      const int numOfCols = 8;
      int curNumOfCols = Math.Min(data.Length, numOfCols);  
      for (int i = 0; i < curNumOfCols; i++)
        grid.Columns.Add("", "");
      int rowIndex = 0;
      for (int i = 0; i < data.Length; i++)
      {
        if (rowIndex > maxBytesToShow)
          return;
        List<int> bits = new List<int>();
        for (int j = 0; j < numOfCols; j++)
        {
          int bit = (data[i] >> j) & 1;
          bits.Add(bit);
          if (grid.Rows.Count <= rowIndex)
            grid.Rows.Add();
          grid.Rows[rowIndex].Cells[j].Value = bit;
        }
        _bitsList.Add(bits);
        rowIndex++;
      }
    }
    private void HandleOpenedFile()
    {
      string openedFileName;
      DialogResult result = openFileDialog.ShowDialog();
      if ((result == DialogResult.OK) && (result != DialogResult.Cancel))
      {
        openedFileName = openFileDialog.FileName;
        ReadFromFile(openedFileName);
      }
    }
    private void ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      HandleOpenedFile();
      FillSourceDataGrid(_fileBytes, sourceDataGrid);
    }

    private byte[] ConvertToByteArray()
    {
      List<byte> byteArray = new List<byte>();
      foreach (List<int> row in _bitsList)
      {
        byte currentByte = 0;
        for (int i = 0; i < row.Count; i++)
          currentByte |= (byte)(row[i] << i);
        byteArray.Add(currentByte);
      }
      return byteArray.ToArray();
    }
    private void SaveBytesAsFile(string path)
    {
      using (FileStream fs = new FileStream(path, FileMode.Create))
      {
        using (BinaryWriter bw = new BinaryWriter(fs))
        {
          byte[] byteArray = ConvertToByteArray();
          bw.Write(byteArray);
        }
      }
    }
    private void HandleSavedFile()
    {
      string savedFileName;
      DialogResult result = saveFileDialog.ShowDialog();
      if ((result == DialogResult.OK) && (result != DialogResult.Cancel))
      {
        savedFileName = saveFileDialog.FileName + _fileExtension;
        SaveBytesAsFile(savedFileName);
      }
    }
    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      HandleSavedFile();
    }
    private void GenerateKey()
    {
      _startStateOfRegister = startStateTB.Text;
      
    }
    private void getKeyBtn_Click(object sender, EventArgs e)
    {
      GenerateKey();
    }
  }
}
