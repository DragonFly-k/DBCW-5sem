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

using System.Text.RegularExpressions;

namespace Client
{
    public partial class Auth : MaterialForm
    {
        public string fio { get; set; }
        public string adress { get; set; }
        public string phoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<Client> client = new List<Client>();
        public Auth()
        {
            InitializeComponent();
            registered.Visible = false;
            err.Visible = false;
            
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple300, Primary.DeepPurple500,Primary.DeepPurple300, Accent.DeepPurple400, TextShade.WHITE);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string patern = @"^(80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$";
            registered.Visible = false;
            if (String.IsNullOrEmpty(fioBox1.Text))
            {
                errorProvider4.SetError(fioBox1, "Не указано ФИО!");
            }
            else if (fioBox1.Text.Length < 15)
            {
                errorProvider4.SetError(fioBox1, "Слишком короткое ФИО!");
            }
            else if (String.IsNullOrEmpty(adressBox2.Text))
            {
                errorProvider4.SetError(adressBox2, "Не указан Адрес");
            }
            else if (String.IsNullOrEmpty(phNumBox3.Text))
            {
                errorProvider4.SetError(phNumBox3, "Не указан номер телефона");
            }
            else if (!Regex.IsMatch(phNumBox3.Text, patern, RegexOptions.IgnoreCase))
            {
                errorProvider4.SetError(phNumBox3, "Неверный формат номера телефона 80(xx)ххххххх");
            }
            else if (String.IsNullOrEmpty(loginBox4.Text))
            {
                errorProvider4.SetError(loginBox4, "Не указан логин");
            }
            else if (String.IsNullOrEmpty(passwBox5.Text))
            {
                errorProvider4.SetError(passwBox5, "Не указан пароль");
            }
            else if (checkLogin(loginBox4.Text) == "consists")
            {
                errorProvider4.SetError(loginBox4, "Пользователь с таким логином уже есть!");
            }
            else if (checkPhone(phNumBox3.Text) == "consists")
            {
                errorProvider4.SetError(phNumBox3, "Пользователь с таким номером уже есть!");
            }
            else
            {
                Client user = new Client()
                {
                    fio = fioBox1.Text,
                    adress = adressBox2.Text,
                    phoneNumber = phNumBox3.Text,
                    Login = loginBox4.Text,
                    Password = passwBox5.Text
                };

                client.Add(user);
                errorProvider4.Clear();
                createNewClient(client);
                registered.Visible = true;
                registered.ForeColor = Color.Lime;
                registered.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            }
        }
        string checkLogin(string login)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.getCountOfClientWithSameLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("checklogin", OracleDbType.NVarchar2).Value = login;
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
                fioBox1.Clear();
                adressBox2.Clear();
                phNumBox3.Clear();
                loginBox4.Clear();
                passwBox5.Clear();
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
            return "not constists";
        }
        string checkPhone(string phoneNumber)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.getCountOfClientWithSamePhone";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("checkphone", OracleDbType.NVarchar2).Value = phoneNumber;
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
                fioBox1.Clear();
                adressBox2.Clear();
                phNumBox3.Clear();
                loginBox4.Clear();
                passwBox5.Clear();
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
            return "not constists";
        }
        public void createNewClient(List<Client> user)
        {
            string fio = "", adress = "", phoneNumber = "", Login = "", Password = "";
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                foreach (var i in user)
                {
                    fio = i.fio;
                    adress = i.adress;
                    phoneNumber = i.phoneNumber;
                    Login = i.Login;
                    Password = i.Password;

                }
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.addclient";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("fullName", OracleDbType.NVarchar2).Value = fio;
                cmd.Parameters.Add("Adress", OracleDbType.NVarchar2).Value = adress;
                cmd.Parameters.Add("PhoneNumber", OracleDbType.NVarchar2).Value = phoneNumber;
                cmd.Parameters.Add("Login", OracleDbType.NVarchar2).Value = Login;
                cmd.Parameters.Add("Passw", OracleDbType.NVarchar2).Value = Password;

                cmd.ExecuteNonQuery();
                fioBox1.Clear();
                adressBox2.Clear();
                phNumBox3.Clear();
                loginBox4.Clear();
                passwBox5.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            err.Visible = false;
            err.ForeColor = Color.Red;
            err.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            if (String.IsNullOrEmpty(loginBox7.Text))
            {
                errorProvider3.SetError(loginBox7, "Не указан логин!");
            }
            else if (String.IsNullOrEmpty(passwBox6.Text))
            {
                errorProvider3.SetError(passwBox6, "Не указан пароль!");
            }
            else if (getClietnInfo(loginBox7.Text, passwBox6.Text) == "consists")
            {
                List<Client> newCl = new List<Client>();
                newCl.Add(getAllClientInfo());

                CForm clientForm = new CForm(loginBox7.Text, passwBox6.Text);
                clientForm.Show();

                this.Hide();
            }
            else
            {
                err.Visible = true;
            }
        }
        string getClietnInfo(string login, string password)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sed.cwClient.checkClientAccount";
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

            return "not consists";
        }
        Client getAllClientInfo()
        {
            Client user = new Client();

            return user;
        }

    }
}