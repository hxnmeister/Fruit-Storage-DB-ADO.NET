using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Diagnostics;
using System.Configuration;

namespace Домашня_робота
{
    public partial class Form1 : Form
    {
        DataTable dt = null;
        DbConnection conn = null;
        DbDataAdapter adapter = null;
        DbProviderFactory providerFactory = null;

        public Form1()
        {
            InitializeComponent();

            foreach(DataRow item in DbProviderFactories.GetFactoryClasses().Rows)
            {
                DBTypeComboBox.Items.Add(item["InvariantName"].ToString());
            }
        }

        private void ExecuteCMDButton_Click(object sender, EventArgs e)
        {

        }

        private void OptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteCMDButton.Enabled = true;
        }

        private void DBTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvider = DBTypeComboBox.SelectedItem.ToString();
            providerFactory = DbProviderFactories.GetFactory(selectedProvider);
            conn = providerFactory.CreateConnection();

            foreach(ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                if(item.ProviderName == selectedProvider)
                {
                    conn.ConnectionString = item.ConnectionString;
                    MessageBox.Show(conn.ConnectionString);
                }
            }

            OptionsComboBox.Enabled = true;
        }
    }
}
