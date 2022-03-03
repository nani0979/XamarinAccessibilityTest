using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccessibilityTesting.Interface
{
    public interface ILauncher
    {
        Task<bool> Launcher(string url);
    }
}
