using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Management;
using System.Net;
using System.Configuration;

namespace AssetTrackingPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetNextEntryNumber();
        }

        private string GetAssetType(ushort[] chassisTypes)
        {
            if (chassisTypes == null || chassisTypes.Length == 0)
                return "Unknown";

            foreach (ushort type in chassisTypes)
            {
                switch (type)
                {
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 15:
                    case 16:
                        return "Desktop";

                    case 8:
                    case 9:
                    case 10:
                    case 14:
                        return "Laptop";

                    case 11:
                    case 12:
                        return "Portable";

                    case 23:
                        return "Server";

                    default:
                        continue;
                }
            }

            return "Unknown";
        }

        //reads how many assets there are and generates a unique id based on it.
        private void GetNextEntryNumber()
        {
            mssql2500520DataSet myDB = new mssql2500520DataSet();
            mssql2500520DataSetTableAdapters.EmployeesTableAdapter adapter =
                new mssql2500520DataSetTableAdapters.EmployeesTableAdapter();

            mssql2500520DataSet.EmployeesDataTable table = adapter.GetData();

            int nextNumber = table.Rows.Count + 1;

            txtID.Text = nextNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //system Name
                txtSystemName.Text = Environment.MachineName;

                //model and manufacturer
                using (ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(
                        "SELECT Model, Manufacturer FROM Win32_ComputerSystem"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        txtModel.Text = obj["Model"]?.ToString() ?? "";
                        txtManufacturer.Text = obj["Manufacturer"]?.ToString() ?? "";
                    }
                }

                //asset type
                using (ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(
                        "SELECT ChassisTypes FROM Win32_SystemEnclosure"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        ushort[] chassisTypes = (ushort[])obj["ChassisTypes"];

                        txtAssetType.Text = GetAssetType(chassisTypes);
                    }
                }

                //ip address
                string ipAddress = "";

                foreach (var address in Dns.GetHostAddresses(
                    Environment.MachineName))
                {
                    if (address.AddressFamily ==
                        System.Net.Sockets.AddressFamily.InterNetwork &&
                        !IPAddress.IsLoopback(address))
                    {
                        ipAddress = address.ToString();
                        break;
                    }
                }

                txtIPAddress.Text = ipAddress;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error retrieving device information: " + ex.Message,
                    "Device Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        
    }
}
