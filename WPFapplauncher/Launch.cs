using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WPFapplauncher
{
    class Launch
    {
        public static void Installer()
        {
            // Install is the exectuable file that will download the msi from the webstie where Hereafter project would be there
            Process.Start("Install.exe");
        }

    }
    class Install
    {
        public static void Installer()
        {

        }
    }
}
