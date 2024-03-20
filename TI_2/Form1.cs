using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_2
{
  public partial class Form1 : Form
  {
    private string _startStateOfRegister;
    private byte[] _fileBytes;
    private string _fileExtension;
    int[] _sourceFileBits;
    List<byte> _xoredBytes = new List<byte>();
    List<byte> _listOfFileBytes = new List<byte>();
    private byte[] _keyBytes;
    private int[] _keyBits;
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
      cipherGrid.ColumnHeadersVisible = false;
      cipherGrid.RowHeadersVisible = false;
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
            _fileBytes = null;
          }
        }          
      }
    }
    private int[] FillListOfBites(byte[] data)
    {
      List<int> bitsList = new List<int>();
      if (data != null)
      {
        foreach (byte b in data)
          for (int i = 0; i < 8; i++)
            bitsList.Add((byte)(b >> i) & 1);
      }
      return bitsList.ToArray();
    }
    private void FillDataGrid(DataGridView grid, byte[] data)
    {
      if (data != null)
      {
        const int maxBytesToShow = 30;
        const int numOfCols = 8; 
        int curNumOfCols = Math.Min(data.Length, numOfCols);
        for (int i = 0; i < curNumOfCols; i++)
          grid.Columns.Add("", "");
        int rowIndex = 0;
        for (int i = 0; i < data.Length; i++)
        {
          if (rowIndex > maxBytesToShow)
            return;
          for (int j = 0; j < numOfCols; j++)
          {
            int bit = (data[i] >> j) & 1;
            if (grid.Rows.Count <= rowIndex)
              grid.Rows.Add();
            grid.Rows[rowIndex].Cells[j].Value = bit;
          }
          rowIndex++;
        }
      }
    }
    private void HandleOpenedFile()
    {
      string openedFileName;
      DialogResult result = openFileDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        openedFileName = openFileDialog.FileName;
        ReadFromFile(openedFileName);
      }
    }
    private void ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      HandleOpenedFile();
      _sourceFileBits = FillListOfBites(_fileBytes);
      FillDataGrid(sourceDataGrid, _fileBytes);
    }
    private void SaveBytesAsFile(string path)
    {
      using (FileStream fs = new FileStream(path, FileMode.Create))
      {
        using (BinaryWriter bw = new BinaryWriter(fs))
        {
          byte[] byteArray = _listOfFileBytes.ToArray();
          bw.Write(byteArray);
        }
      }
    }
    private void HandleSavedFile()
    {
      string savedFileName;
      DialogResult result = saveFileDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        if (!saveFileDialog.FileName.Contains("."))
          savedFileName = saveFileDialog.FileName + _fileExtension;
        else
          savedFileName = saveFileDialog.FileName;
        SaveBytesAsFile(savedFileName);
      }
    }
    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      HandleSavedFile();
    }

    private bool CheckKeyTB()
    {
      if (startStateTB.Text.Length < 23)
      {
        MessageBox.Show("Длина регистра должна быть равна 23!");
        return false;
      }
      _startStateOfRegister = startStateTB.Text;
      return true;
    }
    
    private void FillDataGridByKey(DataGridView grid, string key)
    {
      if (key != null)
      {
        const int maxBytesToShow = 30;
        const int numOfCols = 8;
        int rowIndex = 0;
        int count = 0;
        int curNumOfCols = Math.Min(key.Length, numOfCols);
        for (int i = 0; i < curNumOfCols; i++)
          grid.Columns.Add("", "");
        for (int i = 0; i < key.Length; i++)
        {
          if (rowIndex > maxBytesToShow)
            return;
          for (int j = 0; j < numOfCols; j++)
          {
            if (grid.Rows.Count <= rowIndex)
              grid.Rows.Add();
            grid.Rows[rowIndex].Cells[j].Value = key[count];
            count++;
          }
          rowIndex++;
        }
      }
    }
    
    private void GenerateKey()
    {
      if (CheckKeyTB())
      {
        List<int> polynomous = new List<int> { 23, 5 };
        LFSR lfsr = new LFSR(polynomous, _startStateOfRegister, _sourceFileBits);
        string key = lfsr.StartLFSR();
        _keyBits = GetKeyBits(key);
        FillDataGridByKey(keyDataGridView, key);
        cipherBtn.Enabled = true;
        decipherBtn.Enabled = true;
      }
    }
    private void getKeyBtn_Click(object sender, EventArgs e)
    {
      GenerateKey();
    }

    private int[] GetKeyBits(string key)
    {
      List<int> keyBits = new List<int>();
      foreach (var keyChar in key)
      {
        keyBits.Add(Convert.ToInt32(keyChar - '0'));
      }
      return keyBits.ToArray();
    }

    private void FillCipheredDataGrid(DataGridView grid, byte[] data)
    {
      if (data != null)
      {
        const int maxBytesToShow = 30;
        const int numOfCols = 8; 
        int curNumOfCols = Math.Min(data.Length, numOfCols);
        for (int i = 0; i < curNumOfCols; i++)
          grid.Columns.Add("", "");
        int rowIndex = 0;
        int count = 0;
        for (int i = 0; i < data.Length; i++)
        {
          if (rowIndex > maxBytesToShow)
            return;
          for (int j = 0; j < numOfCols; j++)
          {
            if (grid.Rows.Count <= rowIndex)
              grid.Rows.Add();
            grid.Rows[rowIndex].Cells[j].Value = data[count];
            count++;
          }
          rowIndex++;
        }
      }
    }
    private void StartCiphering()
    {
      for (int i = 0; i < _sourceFileBits.Length; i++)
      {
        byte xoredBit = (byte)(_sourceFileBits[i] ^ _keyBits[i]); 
        _xoredBytes.Add(xoredBit);
      }
      FillCipheredDataGrid(cipherGrid, _xoredBytes.ToArray());
    }
    private void cipherBtn_Click(object sender, EventArgs e)
    {
      StartCiphering();
    }

    private byte ConvertToByte(byte[] bits)
    {
      byte result = 0;
      for (int i = 0; i < 8; i++)
      {
        byte bitValue = (byte)(bits[i] << i);
        result |= bitValue;
      }
      return result;
    }
    private void StartDeciphering()
    {
      _listOfFileBytes.Clear();
      List<byte> bites = new List<byte>();
      int countOfBits = 0;
      for (int i = 0; i < _xoredBytes.Count; i++)
      {
        if (countOfBits > 7)
        {
          countOfBits = 0;
          _listOfFileBytes.Add(ConvertToByte(bites.ToArray()));
          bites.Clear();
        }
        byte decipheredBit = (byte)(_xoredBytes[i] ^ _keyBits[i]);
        bites.Add(decipheredBit);
        countOfBits++;
      }
    }
    private void decipherBtn_Click(object sender, EventArgs e)
    {
      StartDeciphering();
    }
  }
}
