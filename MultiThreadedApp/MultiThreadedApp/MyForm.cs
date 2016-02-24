using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Inv = Inventor;

namespace MultiThreadedApp
{
  public partial class MyForm : Form
  {
    string exeFolder;

    public MyForm()
    {
      InitializeComponent();

      exeFolder = System.IO.Path.GetDirectoryName(
        System.Reflection.Assembly.GetExecutingAssembly().Location);
    }

    delegate void AddToListDelegate(string text);
    private void AddToList(string text)
    {
      if (filesListBox.InvokeRequired)
      {
        filesListBox.Invoke(new AddToListDelegate(AddToList), text);
      }
      else
      {
        filesListBox.Items.Add(text); 
      }
    }

    private string GetPropertiesLocal(string filePath)
    {
      string result = "";

      try
      {
        Inv.ApprenticeServerComponent asc = new Inv.ApprenticeServerComponent();
        Inv.ApprenticeServerDocument asd = asc.Open(filePath);

        // "Inventor Summary Information"
        Inv.PropertySet ps = asd
          .PropertySets["{F29F85E0-4FF9-1068-AB91-08002B27B3D9}"];

        foreach (Inv.Property p in ps)
        {
          result += string.Format("{0}={1};",
              p.DisplayName,
              p.Value);
        }

        asd.Close();
      }
      catch (Exception ex)
      {
        return ex.Message;
      }

      return result;
    }

    private void GetProperties(string filePath, bool useInProcess)
    {
      var fileName = Path.GetFileName(filePath); 

      AddToList(string.Format("starting thread ({0}) at {1}", fileName, DateTime.Now));

      if (useInProcess)
      {
        var result = GetPropertiesLocal(filePath);

        AddToList(string.Format("result ({0}): {1}", fileName, result));
      }
      else
      {
        var proc = new Process();
        proc.StartInfo.FileName = exeFolder + "\\GetProperties.exe";
        // Needs to be wrapped in "" in case the path contains spaces
        proc.StartInfo.Arguments = "\"" + filePath + "\"";
        proc.StartInfo.UseShellExecute = false;
        // Don't need windows popping up
        proc.StartInfo.CreateNoWindow = true;
        // We want to catch the things this writes
        proc.StartInfo.RedirectStandardOutput = true;
        proc.Start();

        var result = proc.StandardOutput.ReadToEnd();

        AddToList(string.Format("result ({0}): {1}", fileName, result));

        proc.WaitForExit();
      }

      AddToList(string.Format("ending thread ({0}) at {1}", fileName, DateTime.Now)); 
    }

    private void folderButton_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      DialogResult result = fbd.ShowDialog();

      if (result != System.Windows.Forms.DialogResult.OK)
        return;

      folderBox.Text = fbd.SelectedPath;
      filesListBox.Items.Clear(); 

      IEnumerable<string> files = Directory
        .EnumerateFiles(fbd.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
        .Where(s => s.EndsWith(".ipt") || s.EndsWith(".iam") || s.EndsWith(".idw"));

      foreach (string fileName in files)
      {
        // Get the properties on separate threads
        var t = new Thread(() => GetProperties(fileName, useInProcess.Checked));
        if (useInProcess.Checked)
          t.SetApartmentState(ApartmentState.STA);

        t.Start();
      }
    }
  }
}
