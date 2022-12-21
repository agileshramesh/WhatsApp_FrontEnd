using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsApp.Controls
{
    /// <summary>
    /// Hide or Show Status bar.
    /// Go to Android and IOS project to see implementations.
    /// </summary>
    public interface IStatusBar
    {
        void HideStatusBar();
        void ShowStatusBar();
    }
}
