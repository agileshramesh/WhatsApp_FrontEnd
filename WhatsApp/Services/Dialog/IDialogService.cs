using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Services.Dialog
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
    }
}
