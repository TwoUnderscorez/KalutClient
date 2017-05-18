using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using KalutClient.Objects;
using Communicator;
using Newtonsoft.Json;

namespace KalutClient
{
    class RefreshListBox : ListBox
    {
        public void RefreshItemsText()
        {
            base.RefreshItems();
        }
    }
}
