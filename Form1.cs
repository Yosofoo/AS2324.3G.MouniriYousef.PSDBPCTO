using System.Data;
using System.Data.SQLite;


namespace AS2324._3G.MouniriYousef.PSDBPCTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElencaIta_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data Source=" + @"C:\Users\mouni\Desktop\c#\Windows Form\awasdada\DB\MotoGP.db" + ";Version=3;";

            DataTable dtDati = new DataTable();

            query = "SELECT Piloti.nome, Piloti.cognome, Piloti.Nazionalita FROM Piloti WHERE Nazionalita='ITA' ORDER BY nome, cognome";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvGriglia.DataSource = dtDati;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGare_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data Source=" + @"C:\Users\mouni\Desktop\c#\Windows Form\awasdada\DB\MotoGP.db" + ";Version=3;";

            DataTable dtDati = new DataTable();

            query = "SELECT Circuiti.nome, Gare.data, Gare.Punteggio FROM Gare " +
                "INNER JOIN Circuiti ON Circuiti.IdCircuiti = Gare.idCircuiti " +
                "ORDER BY Gare.punteggio DESC";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvGriglia.DataSource = dtDati;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data Source=" + @"C:\Users\mouni\Desktop\c#\Windows Form\awasdada\DB\MotoGP.db" + ";Version=3;";

            DataTable dtDati = new DataTable();

            switch (cmbScelta.Text)
            {
                case "Elenco squadre non italiane ordinate per nome":
                    query = "SELECT Squadre.nome FROM Squadre WHERE Squadre.nazionalita<>'ITA' ORDER BY Squadre.nome";
                    break;
                case "Elenco piloti Ducati ordinati per cognome e nome":
                    query = "SELECT Piloti.nome, Piloti.cognome FROM Piloti WHERE Piloti.IdSquadre=30 ORDER BY Piloti.nome, Piloti.cognome";
                    break;
            }

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvGriglia.DataSource = dtDati;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
