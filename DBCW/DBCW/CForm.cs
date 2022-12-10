using MaterialSkin;
using MaterialSkin.Controls;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CForm : MaterialForm  
    {
        public List<Employee> employeesList = new List<Employee>();
        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }        
        public CForm(string login, string pass)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple300, Primary.DeepPurple500, Primary.DeepPurple300, Accent.DeepPurple400, TextShade.WHITE);
            Login = login;
            Password = pass;

            getClienIdAndName(Login, Password);
            insertEmployeeToCombobox();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = employeesList;

            comboBox1.DataSource = employeesList;
            comboBox1.DisplayMember = "fio";
            comboBox1.ValueMember = "Tempid";
        }
        public void checkm()
        {
            int d = int.Parse(comboBox1.SelectedValue.ToString());
        }
        public void insertEmployeeToCombobox()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.getNameAndIdEmp";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                OracleDataReader objReader = cmd.ExecuteReader();
                while (objReader.Read())
                {
                    Employee emp = new Employee()
                    {
                        Tempid = objReader.GetValue(0).ToString(),
                        fio = objReader.GetValue(1).ToString()
                    };
                    employeesList.Add(emp);
                }
                objReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public void getClienIdAndName(string login, string pass)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.getClienIdAndName";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Login", OracleDbType.NVarchar2).Value = Login;
                cmd.Parameters.Add("Passw", OracleDbType.NVarchar2).Value = Password;
                cmd.Parameters.Add("idd", OracleDbType.Int64).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("fio", OracleDbType.NVarchar2, 50).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                string name = cmd.Parameters["idd"].Value.ToString();
                string id = cmd.Parameters["fio"].Value.ToString();
                Name = id.ToString();
                UserLabel.Text = id.ToString();
                Id = int.Parse(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        private void makeOrder_Click(object sender, EventArgs e)
        {
            int equipId = 0;
            if (String.IsNullOrEmpty(nameBox1.Text))
            {
                errorProvider1.SetError(nameBox1, "Не указано наименование!");
            }
            else if (String.IsNullOrEmpty(seriaNumBox2.Text))
            {
                errorProvider1.SetError(seriaNumBox2, "Не указан серийный номер оборудования!");
            }
            else if (String.IsNullOrEmpty(descsBox3.Text))
            {
                errorProvider1.SetError(descsBox3, "Не указана неисправность оборудования!");
            }
            else if (String.IsNullOrEmpty(makerBox4.Text))
            {
                errorProvider1.SetError(makerBox4, "Не указан производитель оборудования!");
            }
            else if (String.IsNullOrEmpty(modelBox5.Text))
            {
                errorProvider1.SetError(modelBox5, "Не указана модель оборудования!");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Не выбран мастер!");
            }
            else
            {
                errorProvider1.Clear();
                fillEquipmentTable(nameBox1.Text, seriaNumBox2.Text, descsBox3.Text, makerBox4.Text, modelBox5.Text);
                equipId = getEquipmentId();
                Order(equipId, Id, int.Parse(comboBox1.SelectedValue.ToString()), 1, 0, DateTime.Now);
                nameBox1.Clear();
                seriaNumBox2.Clear();
                descsBox3.Clear();
                makerBox4.Clear();
                modelBox5.Clear();
            }
        }
        public void Order(int eq_Id, int client_Id, int empl_Id, int status_id, int maker_id, DateTime dateO)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.makeOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("eq_Id", OracleDbType.Int32).Value = eq_Id;
                cmd.Parameters.Add("client_Id", OracleDbType.Int32).Value = client_Id;
                cmd.Parameters.Add("empl_Id", OracleDbType.Int32).Value = empl_Id;
                cmd.Parameters.Add("status_id", OracleDbType.Int32).Value = status_id;
                cmd.Parameters.Add("dateO", OracleDbType.Date).Value = dateO;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public int getEquipmentId()
        {
            int result = 0;
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.getEpuipmentIdForOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("results", OracleDbType.Int64).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                string ct = cmd.Parameters["results"].Value.ToString();
                result = int.Parse(ct.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return result;
        }
        public void fillEquipmentTable(string nameBox1, string seriaNumBox2, string descsBox3, string makerBox4, string modelBox5)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.addEquipment";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("eqname", OracleDbType.NVarchar2).Value = nameBox1;
                cmd.Parameters.Add("sernum", OracleDbType.NVarchar2).Value = seriaNumBox2;
                cmd.Parameters.Add("descr", OracleDbType.NVarchar2).Value = descsBox3;
                cmd.Parameters.Add("eqmakers", OracleDbType.NVarchar2).Value = makerBox4;
                cmd.Parameters.Add("eqmodel", OracleDbType.NVarchar2).Value = modelBox5;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            checkm();
        }

        public void showCurrentClientOrders()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleDataAdapter objAdapter = new OracleDataAdapter();

                OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.showCurrentClientOrders";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("cl_id", OracleDbType.Int32).Value = int.Parse(Id.ToString());
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                objAdapter.SelectCommand = cmd;

                DataTable dtEmp = new DataTable();
                objAdapter.Fill(dtEmp);
                dataGridView1.DataSource = dtEmp;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            showCurrentClientOrders();
            showHistoryClientOrders();
        }
        public void showHistoryClientOrders()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleDataAdapter objAdapter = new OracleDataAdapter();

                OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.showHistoryClientOrders";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("cl_id", OracleDbType.Int32).Value = int.Parse(Id.ToString());
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                objAdapter.SelectCommand = cmd;

                DataTable dtEmp = new DataTable();
                objAdapter.Fill(dtEmp);
                dataGridView2.DataSource = dtEmp;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}