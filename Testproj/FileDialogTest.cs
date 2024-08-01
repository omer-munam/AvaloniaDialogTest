using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproj
{
    public class FileDialogTest
    {
        public void OpenDialog()
        {
            var d = new Microsoft.Win32.OpenFileDialog()
            {
                Title = "Test",
                InitialDirectory = Environment.CurrentDirectory,
                ValidateNames = true,
            };
            d.ShowDialog();
        }
    }
}
