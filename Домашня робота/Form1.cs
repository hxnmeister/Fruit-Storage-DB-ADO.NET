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
using System.Reflection;

namespace Домашня_робота
{
    public partial class Form1 : Form
    {
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

        private DbCommand ParameterizedRequest(string request, string parameterName, string parameter1Name = null)
        {
            DbCommand cmd = providerFactory.CreateCommand();
            DbParameter parameter = cmd.CreateParameter();

            cmd.Connection = adapter.SelectCommand.Connection;
            cmd.CommandText = request;
            parameter.ParameterName = $"@{parameterName}";
            parameter.Value = ParametersTextBox.Text.ToString();
            cmd.Parameters.Add(parameter);

            if(parameter1Name != null)
            {
                DbParameter parameter1 = cmd.CreateParameter();
                parameter1.ParameterName = $"@{parameter1Name}";
                parameter1.Value = ParametersTextBox1.Text.ToString();
                cmd.Parameters.Add(parameter1);
            }

            return cmd;
        }

        private void ExecuteCMDButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                adapter = providerFactory.CreateDataAdapter();
                adapter.SelectCommand = providerFactory.CreateCommand();
                adapter.SelectCommand.Connection = conn;

                switch (OptionsComboBox.SelectedIndex)
                {
                    case 0:
                        adapter.SelectCommand.CommandText = "select* from OverallInfo";
                        break;
                    case 1:
                        adapter.SelectCommand.CommandText = "select Name from OverallInfo";
                        break;
                    case 2:
                        adapter.SelectCommand.CommandText = "select Color from OverallInfo";
                        break;
                    case 3:
                        adapter.SelectCommand.CommandText = "select max(Calories) as [Max Calories] from OverallInfo";
                        break;
                    case 4:
                        adapter.SelectCommand.CommandText = "select min(Calories) as [Min Calories] from OverallInfo";
                        break;
                    case 5:
                        adapter.SelectCommand.CommandText = "select avg(Calories) as [Average Calories] from OverallInfo";
                        break;
                    case 6:
                        adapter.SelectCommand.CommandText = "select count(Type) as [Amount of Vegetables] from OverallInfo where Type = 0";
                        break;
                    case 7:
                        adapter.SelectCommand.CommandText = "select count(Type) as [Amount of Fruits] from OverallInfo where Type = 1";
                        break;
                    case 8:
                        adapter.SelectCommand = ParameterizedRequest("select count(*) as [Amount of FaV] from OverallInfo where Color = @colorName","colorName");

                        ParametersTextBox.Clear();
                        ParametersTextBox.Enabled = false;
                        break;
                    case 9:
                        adapter.SelectCommand.CommandText = "select Color, Count(*) as Amount from OverallInfo group by Color";
                        break;
                    case 10:
                        adapter.SelectCommand = ParameterizedRequest("select * from OverallInfo where Calories < @less","less");

                        ParametersTextBox.Clear();
                        ParametersTextBox.Enabled = false;
                        break;
                    case 11:
                        adapter.SelectCommand = ParameterizedRequest("select * from OverallInfo where Calories > @more", "more");

                        ParametersTextBox.Clear();
                        ParametersTextBox.Enabled = false;
                        break;
                    case 12:
                        adapter.SelectCommand = ParameterizedRequest("select * from OverallInfo where Calories between @less and @more","less","more");

                        ParametersTextBox.Clear();
                        ParametersTextBox.Enabled = false;
                        ParametersTextBox1.Visible = false;
                        break;
                    case 13:
                        adapter.SelectCommand.CommandText = "select * from OverallInfo where Color in ('Red','Yellow')";
                        break;
                }

                adapter.Fill(dt);
                FaVDataGridView.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = OptionsComboBox.SelectedIndex;

            if(selectedIndex == 8 || selectedIndex == 10 || selectedIndex == 11 || selectedIndex == 12)
            {
                ParametersTextBox.Enabled = true;
                ParametersTextBox.Focus();

                if (selectedIndex == 12)
                {
                    ParametersTextBox1.Clear();
                    ParametersTextBox1.Visible = true;
                }
            }

            ExecuteCMDButton.Enabled = true;
        }

        private void DBTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvider = DBTypeComboBox.SelectedItem.ToString();
            providerFactory = DbProviderFactories.GetFactory(selectedProvider);
            conn = providerFactory.CreateConnection();

            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                if(item.ProviderName == selectedProvider)
                {
                    conn.ConnectionString = item.ConnectionString;
                    OptionsComboBox.Enabled = true;
                    break;
                }
            }
        }
    }
}
