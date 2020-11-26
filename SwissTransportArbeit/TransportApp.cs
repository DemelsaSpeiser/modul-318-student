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
    // Variable für Endstation
    // Variable für Verbindung
    // Transport Klasse instantierung
    // Ausgabe der Verbindungen

    string Von;
    string Nach;
    Transport Datenzugriff;
    Connections Verbindungen;
    string Ausgabe;
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
        lbxAusgabe.Items.Add(aktVerbindung.From.Station.Name + " " + aktVerbindung.To.Station.Name);
      }

    }
  }
}
