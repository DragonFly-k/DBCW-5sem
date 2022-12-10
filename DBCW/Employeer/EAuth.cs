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

namespace Employeer
{
    public partial class EAuth : MaterialForm
    {
        public EAuth()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple300, Primary.DeepPurple500, Primary.DeepPurple300, Accent.DeepPurple400, TextShade.WHITE);

            err.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            err.Visible = false;
            if (String.IsNullOrEmpty(loginBox7.Text))
            {
                errorProvider1.SetError(loginBox7, "Не указан логин!");
            }
            else if (String.IsNullOrEmpty(passwBox6.Text))
            {
                errorProvider1.SetError(passwBox6, "Не указан пароль!");
            }
            else if (getEmployeeInfo(loginBox7.Text, passwBox6.Text) == "consists")
            {
                List<Employee> newEmp = new List<Employee>();
                newEmp.Add(getAllEmpInfo());

                //EmployeeForm employee = new EmployeeForm(loginBox7.Text, passwBox6.Text);
                EForm employee = new EForm(loginBox7.Text, passwBox6.Text);
                employee.Show();

                this.Hide();
            }
            else
            {
                err.Visible = true;
                err.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                err.ForeColor = System.Drawing.Color.Red;
            }
        }
        string getEmployeeInfo(string login, string password)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwEmpl.checkEmpAccount";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("login", OracleDbType.NVarchar2).Value = login;
                cmd.Parameters.Add("pass", OracleDbType.NVarchar2).Value = password;
                cmd.Parameters.Add("results", OracleDbType.Int64).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                string ct = cmd.Parameters["results"].Value.ToString();
                if (int.Parse(ct) > 0)
                {
                    return "consists";
                }
                else
                {
                    return "not consists";
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex);
                MessageBox.Show(ex.StackTrace);
                switch (ex.Number)
                {
                    case 1:
                        MessageBox.Show("Error attempting to insert duplicate data.");
                        break;
                    case 12545:
                        MessageBox.Show("The database is unavailable.");
                        break;
                    default:
                        MessageBox.Show("Database error: " + ex.Message.ToString());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return "not consists";
        }
        Employee getAllEmpInfo()
        {
            Employee emp = new Employee();
            return emp;
        }

    }
}