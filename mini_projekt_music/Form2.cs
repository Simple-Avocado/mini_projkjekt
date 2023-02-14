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
    public partial class Form2 : Form
    {

        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlCommand cmd2;
        NpgsqlCommand cmd3;
        NpgsqlCommand cmd4;
        NpgsqlCommand cmd19;

        string connect = "Host=mouse.db.elephantsql.com;Port=5432;Username=rzfiuqzk;Password=BCDVnN31-EQP3tQ2RF8oCTHZcaDTblrn;Database=rzfiuqzk";
        string idiji = "";
        public Form2()
        {
            InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {

            idiji = "0";

            usernameLable.Text = Form1.pass2;
            string njegovId = usernameLable.Text;
            connect1();
            /*     conn.Open();
                 string sql8 = String.Format("SELECT stevilo_tvojih_iger('" + njegovId + "');");
                 cmd19 = new NpgsqlCommand(sql8, conn);
                 var reader8 = cmd19.ExecuteReader();
                 reader8.Read();
                int integer= reader8.GetInt32(0);
                 conn.Close();
                 for (int i = 0; i <integer ;  i++) {*/

            conn.Open();
            string sql = String.Format("Select * from uzamem_id_uporabnika('" + njegovId + "')");
            cmd = new NpgsqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();


            try
            {

                while (reader.Read())
                {

                    idiji = idiji + reader.GetInt32(0) + ",";

                }


            }
            catch
            {
                idiji = "0";
            }
            conn.Close();
            //    }

            conn.Open();
            idiji = idiji.TrimEnd(',');
            if (idiji != "0")
            {
                string sql54 = String.Format("Select stevilo_tvojih_iger('" + njegovId + "');");
                cmd2 = new NpgsqlCommand(sql54, conn);
                var reader55 = cmd2.ExecuteReader();
                reader55.Read();


                int[] idiji_sespreminjajo = new int[reader55.GetInt32(0)];
                conn.Close();
                conn.Open();
                string sql2 = String.Format("SELECT * FROM string_to_integer_list('" + idiji + "');");
                cmd2 = new NpgsqlCommand(sql2, conn);
                var reader2 = cmd2.ExecuteReader();
                reader2.Read();


                for (int i = 0; i < idiji_sespreminjajo.Length; i++)
                {
                    idiji_sespreminjajo[i] = reader2.GetInt32(0);
                    reader2.Read();
                }


                /*     foreach (int i  in idiji_sespreminjajo)
                         {



                             idiji_sespreminjajo[i] = reader2.GetInt32(0);

                         reader2.Read();



                     }*/
                conn.Close();

                for (int i = 0; i < idiji_sespreminjajo.Length; i++)
                {
                    conn.Open();
                    string sql15 = String.Format("Select uzamem_ime_igre(" + idiji_sespreminjajo[i] + ");");
                    cmd19 = new NpgsqlCommand(sql15, conn);
                    var reader6 = cmd19.ExecuteReader();

                    while (reader6.Read())
                    {
                        UrGamesRichBox.Text = UrGamesRichBox.Text + (reader6.GetString(0)) + Environment.NewLine;
                    }
                    conn.Close();
                }

            }

            conn.Open();
            string sql3 = String.Format("SELECT ime from igre");
            cmd3 = new NpgsqlCommand(sql3, conn);
            var reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                AllGamesRIchBox.Text = AllGamesRIchBox.Text + (reader3.GetString(0)) + Environment.NewLine;
            }
            conn.Close();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();

        }
        public void connect1()
        {
            conn = new NpgsqlConnection(connect);

        }

        private void DodajanjeIgreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string dodigre = DodajanjeIgreBox.Text;
                string imeuporabnika = usernameLable.Text;


                if (dodigre != "")
                {
                    int igre;
                    connect1();
                    conn.Open();
                    string sql4 = String.Format("SELECT  uzamem_id_igre('%" + dodigre + "%')");
                    cmd4 = new NpgsqlCommand(sql4, conn);
                    var reader4 = cmd4.ExecuteReader();
                    reader4.Read();
                    igre = reader4.GetInt32(0);
                    conn.Close();

                    UrGamesRichBox.Text = "";

                    conn.Open();
                    string sql = String.Format("SELECT uzamem_id_up('" + imeuporabnika + "') ");
                    cmd = new NpgsqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    int igre2;
                    igre2 = reader.GetInt32(0);
                    conn.Close();
                    conn.Open();
                    string sql2 = String.Format("select insertam_ig_up('" + igre + "','" + igre2 + "')");
                    cmd2 = new NpgsqlCommand(sql2, conn);
                    var reader2 = cmd2.ExecuteReader();
                    conn.Close();
                    AllGamesRIchBox.Text = "";
                    UrGamesRichBox.Text = "";
                    AllGamesRIchBox.Text = "";

                    Form2_Load(1, e);

                    /* conn.Open();
                     string sql8 = String.Format("SELECT uzamem_id_uporabnika('" + imeuporabnika + "')");
                     cmd19 = new NpgsqlCommand(sql8, conn);
                     var reader15 = cmd19.ExecuteReader();
                     reader15.Read();
                     try
                     {
                         if (reader15.GetString(0) != "")
                         {
                             while (reader15.Read())
                             {
                                 idiji = idiji + reader15.GetInt32(0) + ",";
                             }
                             idiji = idiji.TrimEnd(',');
                         }
                     }
                     catch
                     {
                         idiji = "0";
                     }

                     conn.Close();


                     conn.Open();
                     if (idiji!="0")
                     {
                         string sql3 = String.Format("SELECT uzamem_ime_igre('" + idiji + "')");
                         cmd2 = new NpgsqlCommand(sql3, conn);
                         var reader3 = cmd2.ExecuteReader();
                         while (reader3.Read())
                         {
                             UrGamesRichBox.Text = UrGamesRichBox.Text + (reader3.GetString(0)) + Environment.NewLine;
                         }
                     }
                     conn.Close();*/
                    DodajanjeIgreBox.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Ta igra ne obstaja");
            }

     }

        private void RemoveGameBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string imeuporabnika = usernameLable.Text;
                string imeigre = DeleteGameBOX.Text;

                connect1();
                conn.Open();
                string sql3 = String.Format("SELECT uzamem_id_igre('%" + imeigre + "%')");
                cmd3 = new NpgsqlCommand(sql3, conn);
                var reader3 = cmd3.ExecuteReader();
                reader3.Read();
                int igre;
                igre = reader3.GetInt32(0);
                conn.Close();
                conn.Open();
                string sql = String.Format("SELECT id_uporabnik_uzamem_jst('" + imeuporabnika + "') ");
                cmd = new NpgsqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                reader.Read();
                int igre2;
                igre2 = reader.GetInt32(0);
                conn.Close();
                DialogResult result = MessageBox.Show("Ali zares želite odstraniti to igro?", "Potrditev ", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    string sql2 = String.Format("SELECT izbrisem_igro(" + igre + "," + igre2 + ") ");
                    cmd2 = new NpgsqlCommand(sql2, conn);
                    var reader2 = cmd2.ExecuteReader();
                    conn.Close();
                    AllGamesRIchBox.Text = "";
                    UrGamesRichBox.Text = "";
                    DeleteGameBOX.Text = "";
                    Form2_Load(0, e);
                }
                else
                {
                    DeleteGameBOX.Text = "";
                }
            }
            catch {
                MessageBox.Show("Ta igra ni med tvojimi igrami");
            }

        }
    }
}
