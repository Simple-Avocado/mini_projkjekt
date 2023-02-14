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
    public partial class Form3 : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlCommand cmd2;

      
        string connect = "Host=mouse.db.elephantsql.com;Port=5432;Username=rzfiuqzk;Password=BCDVnN31-EQP3tQ2RF8oCTHZcaDTblrn;Database=rzfiuqzk";
    
        public Form3()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (RegisterImeBox.Text != "" && RegisterUsernameBox.Text != "" && RegisterPasswordBox.Text != "" && RegisterKrajBox.Text!="")
            {
                try
                {
                    connect1();
                    conn.Open();
                    string sql = String.Format("SELECT uzamem_id_kraja('"+RegisterKrajBox.Text+"')");
                    cmd = new NpgsqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    int krajid = 0;
                    krajid = reader.GetInt32(0);

                    conn.Close();
                    conn.Open();
                    string sql2 = String.Format("Select insertam_now_uporabnik('"+ RegisterImeBox.Text + "','"+RegisterPriimekBox.Text+"','"+RegisterUsernameBox.Text+"','"+RegisterPasswordBox.Text+"','"+RegisterOpisBox.Text+"','"+krajid+"')");
                        cmd2 = new NpgsqlCommand(sql2, conn);
                    var reader2 = cmd2.ExecuteReader();
                    conn.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                catch {
                    MessageBox.Show("Vnesite pravilen kraj v Sloveniji!!!   :/");
                }

            }
            ObveznoLbl.Visible = true;
            ObveznoLbl2.Visible = true;
            ObveznoLbl3.Visible = true;
            label1.Visible = true;
        }








        public void connect1()
        {
            conn = new NpgsqlConnection(connect);

        }
    }
}
