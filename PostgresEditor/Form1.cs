using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using Npgsql;

namespace PostgresEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxHaslo.PasswordChar = '*';
            textBoxServer.Text = "127.0.0.1";
            textBoxPort.Text = "5432";
            textBoxLogin.Text = "postgres";
            textBoxHaslo.Text = "michal";
            textBoxBD.Text = "postgres";
            richTextBoxZapytanie.Text = "SELECT * FROM klient";


            
            
               //dataGridView1.DataSourceChanged += new EventHandler((sender1, e) => { buttonZapisz.BackColor = Color.Red; });
               
           
        }

         
         public void Zapis() {

             buttonZapisz.BackColor = Color.Red;
                 
         
         }

         private void buttonCzytaj_Click(object sender, EventArgs e)
         {

             Conector.connectionStr = String.Format("Server={0};Port={1};" +
                         "User Id={2};Password={3};Database={4};",
                         textBoxServer.Text, textBoxPort.Text, textBoxLogin.Text,
                         textBoxHaslo.Text, textBoxBD.Text);
             string zap = "";

             for (int i = 0; i < richTextBoxZapytanie.Lines.Count(); i++)
             {

                

                 zap += String.Format(richTextBoxZapytanie.Lines[i]);
                 zap += String.Format(" ");

             }
             richTextBoxTabele.Text = zap;

             Conector.zapytanie = zap;

             try
             {
                 dataGridView1.DataSource = Conector.Connect();
             }
             catch (NpgsqlException ex)
             {

                 MessageBox.Show(ex.ToString());
             }
             finally
             {

                 Conector.MyConnection.Close();

             }

             dataGridView1.CellValueChanged += new DataGridViewCellEventHandler((asd, ea) => { buttonZapisz.BackColor = Color.Red; });      
                 
             
         }

         private void buttonZapisz_Click(object sender, EventArgs e)
         {
             try
             {
                 Conector.newdt = (DataTable)dataGridView1.DataSource;
                 Conector.Save();
                 MessageBox.Show("Zaktualizowano dane");
                 buttonZapisz.BackColor = Color.Gray;

             }
             catch (NpgsqlException ex)
             {

                 MessageBox.Show("Upss.. {0}", ex.ToString());
             }
             finally {

                 Conector.MyConnection.Close();

             }
         }

         private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
         {
             MessageBox.Show("michal.dziadosz@gmail.com");
              
         }
         
    }
}
