using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace TPSynthese_MaximeDery_JeanSebastienBeaulne
{
    class connextionBD
    {
        private OleDbConnection conn = null;
        private OleDbDataAdapter daEmploye;
        private OleDbDataAdapter daMagasin;
        private DataSet ds;
        private string chemin = AppDomain.CurrentDomain.BaseDirectory + "\\";
        private string bd = "TablesMagasin.mbd";

        private string reqSQL1 = "select NoMagasin, NomMagasin, Ville group by Ville from Magasin";
        private string reqSQL2 = "";

        int max_ligne = 0;


        public DataTable peuplerListBoxMagasin()
        {
            string connString = "Provider=Microsfot.Jet.OLEBD.4.0;Data Source= " + chemin + bd + ";Persist Security Info=False";
            DataTable maTable = new DataTable();

            conn = new OleDbConnection();
            ds = new DataSet();

            conn.ConnectionString = connString;
            daMagasin = new OleDbDataAdapter(reqSQL1, conn);

            conn.Open();

            daEmploye.Fill(ds, "Magasin");

            conn.Close();

            tabMagasins

            foreach (DataRow dr in ds.Tables["Magasin"].Rows)
            {
                
            }

            /*
            daMagasin.Fill(ds, "Magasin");

            conn.Close();

            max_ligne = ds.Tables["Magasin"].Rows.Count;


            if(max_ligne > 0)
            {
                maTable = ds.Tables[0];

            } else
            {
               // reqSQL1 = "Aucune ligne sélectionné dans la base de données";
            }




            return maTable;*/
        }
    }
}
