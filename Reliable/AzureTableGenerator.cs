using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using System.IO;

namespace Reliable
{
    public partial class AzureTableGenerator : Form
    {
        public MobileServiceClient Client { get; set; }
        public IMobileServiceSyncTable<InventoryCountTable> inventoryCountTable;
        public IMobileServiceSyncTable<NewBarcodesTable> newBarcodesTable;
        public AzureTableGenerator()
        {
            InitializeComponent();
        }

        private async void queryButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Client = new MobileServiceClient("http://rmpinventorymanagement.azurewebsites.net");

            var documentspath = "Z:\\Reliable Application\\syncstore.db";

            var store = new MobileServiceSQLiteStore(documentspath);

            store.DefineTable<InventoryCountTable>();
            store.DefineTable<NewBarcodesTable>();

            await Client.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

            inventoryCountTable = Client.GetSyncTable<InventoryCountTable>();
            newBarcodesTable = Client.GetSyncTable<NewBarcodesTable>();

            await inventoryCountTable.PullAsync("allCounts", inventoryCountTable.CreateQuery());
            await newBarcodesTable.PullAsync("allBarcodes", newBarcodesTable.CreateQuery());

            await Client.SyncContext.PushAsync();

            this.Cursor = Cursors.Default;

            MessageBox.Show("Synchronization Complete");
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
