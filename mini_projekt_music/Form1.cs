using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace mini_projekt_music
{
    public partial class Form1 : Form
    {
        public static string pass2 = "";
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlCommand cmd2;
        string connect = "Host=mouse.db.elephantsql.com;Port=5432;Username=rzfiuqzk;Password=BCDVnN31-EQP3tQ2RF8oCTHZcaDTblrn;Database=rzfiuqzk";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButon_Click(object sender, EventArgs e)
        {
            this.Load += Form1_Load;

            if (UsernameLoginBox.Text != "" && PasswordLoginBox.Text!="")
            {

                connect1();
               try
                {
                    conn.Open();
                    string sql = String.Format("SELECT pass_uporabnika('" + PasswordLoginBox.Text + "') ");
                    cmd = new NpgsqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    string pass = "";
                    pass = reader.GetString(0);

                    conn.Close();
                    conn.Open();

                    string sql2 = String.Format("Select username_uporabnika('"+UsernameLoginBox.Text+"') ");
                    cmd2 = new NpgsqlCommand(sql2, conn);
                    var reader2 = cmd2.ExecuteReader();
                    reader2.Read();
                    pass2 = reader2.GetString(0);


                    if (pass2 == UsernameLoginBox.Text && pass == PasswordLoginBox.Text)
                    {
                        this.Visible = false;
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
               }
                catch
                {
                    MessageBox.Show("Vnesite pravilne podatke!!");
                }
                conn.Close();
            }
            wrongpassorusernamelabel.Text = "Napačno uporabniško ime ali geslo";
        }
        public void connect1()
        {
            conn = new NpgsqlConnection(connect);

        }
        private List<string> test()
        {
            List<string> uporabniki = new List<string>();
            connect1();
            conn.Open();
            string sql = String.Format("SELECT * FROM Uporabniki");
            cmd = new NpgsqlCommand(sql, conn);
           var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                uporabniki.Add(reader.GetString(1));
            
            }
            return uporabniki;
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = true;

        }

        private void LoginReegisterBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=textBox2.Text) 
            {
                connect1();
                conn.Open();
                string sql = String.Format("SELECT editam_geslo('"+textBox2.Text+"','"+textBox1.Text+"' )");
                cmd = new NpgsqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                textBox1.Text = "";
                textBox2.Text = "";

            }
        }
    }

}
