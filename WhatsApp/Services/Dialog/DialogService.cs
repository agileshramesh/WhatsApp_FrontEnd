using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Services.Dialog
{
    public class DialogService : IDialogService
    {
        public Task ShowAlertAsync(string message, string title, string buttonLabel)
        {
            //return UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
            return null;
        }
    }
}
