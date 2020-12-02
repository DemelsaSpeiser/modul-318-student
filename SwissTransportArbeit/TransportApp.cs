using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportArbeit
{
  public partial class TransportApp : Form
  {
    public TransportApp()
    {
      InitializeComponent();
    }

    // Variable für Startstation
    string Von;
    // Variable für Endstation
    string Nach;
    // Variable für Datum
    string Datum;
    // Variable für Zeit
    string Zeit;
    // Variablen für Verbindung
    Transport Datenzugriff;
    Connections Verbindungen;
    Connection aktVerbindung;

    private void BtnGo_Click(object sender, EventArgs e)
    {
      // Variablendefiniton für Von
      // Fehler Meldung
      if (cbxVon.Text == "" && cbxNach.Text == "")
      {
        string message = "Bitte überprüfen Sie Ihre Eingaben.";
        string title = "Eingabefehler";
        MessageBox.Show(message, title);
        return;
      }
      else if (cbxNach.Text == "")
      {
        string message = "Bitte geben sie einen Stationsname bei Nach ein.";
        string title = "Eingabefehler Nach";
        MessageBox.Show(message, title);
        return;
      }
      else if (cbxVon.Text == "")
      {
        string message = "Bitte geben sie einen Stationsname bei Von ein";
        string title = "Eingabefehler Von";
        MessageBox.Show(message, title);
        return;
      }
      else
      {
        // Textfeld 
        Von = Convert.ToString(cbxVon.Text);
        Nach = Convert.ToString(cbxNach.Text);
        // Zeit und Datum vergleichen
        Datum = Convert.ToString(dtpDate.Value.ToString("yyyy-MM-dd"));
        Zeit = Convert.ToString(dtpTime.Value.ToString("HH:mm"));
        // Instanziierung
        Datenzugriff = new Transport();
        Verbindungen = Datenzugriff.GetConnections(Von, Nach, Datum, Zeit);

        if (Verbindungen.ConnectionList == null || Verbindungen.ConnectionList.Count == 0)
        {
          string message = "Keine mögliche Verbindungen. Bitte wählen Sie ein anderes Datum.";
          string title = "Datumsfehler";
          MessageBox.Show(message, title);
          return;
        }
        else
        {
          // Ausgabe der Verbindung
          for (int i = 0; i < 4; i++)
          {
            // Mithilfe von i auf die einzelnen Verbindungen zugreifen
            aktVerbindung = Verbindungen.ConnectionList[i];
            // Ausgabe
            lbxZeitVon.Items.Add(Convert.ToDateTime(aktVerbindung.From.Departure).ToString("HH:mm"));
            lbxAusgabeVon.Items.Add(aktVerbindung.From.Station.Name);

            lbxZeitNach.Items.Add(Convert.ToDateTime(aktVerbindung.To.Arrival).ToString("HH:mm"));
            lbxAusgabeNach.Items.Add(aktVerbindung.To.Station.Name);
          }
        }
      }
    }

    // Eingaben bereinigen
    private void BtnClear_Click(object sender, EventArgs e)
    {
      lbxAusgabeNach.Items.Clear();
      lbxAusgabeVon.Items.Clear();
      lbxZeitNach.Items.Clear();
      lbxZeitVon.Items.Clear();
      cbxVon.ResetText();
      cbxNach.ResetText();
      dtpDate.ResetText();
      dtpTime.ResetText();


    }

    // Zeit und Datum auf aktuell stellen
    private void BtnJetzt_Click(object sender, EventArgs e)
    {
      dtpDate.ResetText();
      dtpTime.ResetText();
    }

    private void BtnAddVon_Click(object sender, EventArgs e)
    {
      cbxVon.Items.Add(cbxVon.Text);
    }

    private void BtnAddNach_Click(object sender, EventArgs e)
    {
      cbxNach.Items.Add(cbxNach.Text);
    }
  }
}
