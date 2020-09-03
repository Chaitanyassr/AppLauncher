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
        public static void PlayGame()
        {
            Process.Start("app.exe");
        }
    }
}
