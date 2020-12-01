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
    // Variablen für Verbindung
    Transport Datenzugriff;
    Connections Verbindungen;
    Connection aktVerbindung;

    private void BtnGo_Click(object sender, EventArgs e)
    {
      // Variablendefiniton für Von
      Von = Convert.ToString(txtVon.Text);
      // Variablendefinition für Nach
      Nach = Convert.ToString(txtNach.Text);
      // Instanziierung
      Datenzugriff = new Transport();
      Verbindungen = Datenzugriff.GetConnections(Von, Nach);

      // Ausgabe der Verbindung
      for(int i = 0; i < 4; i++)
      {
        // Mithilfe von i auf die einzelnen Verbindungen zugreifen
        aktVerbindung = Verbindungen.ConnectionList[i];
        // Ausgabe
        lbxAusgabeVon.Items.Add(aktVerbindung.From.Station.Name); // Startpunkt
        lbxAusgabeNach.Items.Add(aktVerbindung.To.Station.Name);  // Zielpunkt
        lbxZeitVon.Items.Add(Convert.ToDateTime(aktVerbindung.From.Departure).ToString("HH:mm")); // Abfahrtszeit
        lbxZeitNach.Items.Add(Convert.ToDateTime(aktVerbindung.To.Arrival).ToString("HH:mm"));    // Ankunftszeit
      }

    }

    // Eingaben bereinigen
    private void BtnClear_Click(object sender, EventArgs e)
    {
      lbxAusgabeNach.Items.Clear();
      lbxAusgabeVon.Items.Clear();
      lbxZeitNach.Items.Clear();
      lbxZeitVon.Items.Clear();
      txtVon.ResetText();
      txtNach.ResetText();
    }
  }
}
