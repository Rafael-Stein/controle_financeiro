using controle_financeiro.view.receitas;
using System.Drawing;
using System.Windows.Forms;

namespace controle_financeiro
{

  public partial class PrincipalUI : Form
  {
    private CobrancasUI cobrancasUI;

    public PrincipalUI()
    {
      this.InitializeComponent();
    }

    private void menuItemReceitasCobrancas_Click(object sender, System.EventArgs e)
    {

      if (this.cobrancasUI == null || this.cobrancasUI.IsDisposed) 
      {
        this.cobrancasUI = new CobrancasUI();
        this.cobrancasUI.MdiParent = this;
      }

      this.cobrancasUI.Location = new Point(0, 0);
      this.cobrancasUI.BringToFront();
      this.cobrancasUI.Show();


    }

  }

}
