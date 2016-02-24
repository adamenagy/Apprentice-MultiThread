using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;

namespace GetProperties
{
  class Program
  {

    // STAThread is needed because Apprentice does not support
    // multi-threading
    [STAThread]
    static void Main(string[] args)
    {
      try
      {
        var filePath = args[0];

        if (!System.IO.File.Exists(filePath))
        {
          System.Console.Write(
            string.Format("File ({0}) does not exist.", filePath));

          return;
        }

        ApprenticeServerComponent asc = new ApprenticeServerComponent();
        ApprenticeServerDocument asd = asc.Open(filePath);

        // "Inventor Summary Information"
        PropertySet ps = asd
          .PropertySets["{F29F85E0-4FF9-1068-AB91-08002B27B3D9}"];

        foreach (Property p in ps)
        {
          System.Console.Write(
            string.Format("{0}={1};",
              p.DisplayName,
              p.Value)
          );
        }

        asd.Close();
      }
      catch (Exception ex)
      {
        System.Console.WriteLine(ex.Message);
      }
    }
  }
}
