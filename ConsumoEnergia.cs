using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergiaCondomínio
{
    
    public partial class ConsumoEnergia : Form
    {
        private IList<Leitura> leituras = new BindingList<Leitura>();
        private BindingSource leituraSource = new BindingSource();
        public ConsumoEnergia()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dvgResumo.DataSource = leituraSource;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistraConsumo(txtNCasa.Text, Convert.ToDouble(txtConsumo.Text));
        }

        private void RegistraConsumo(string casa, double consumo)
        {
            Leitura leitura = new Leitura(casa, consumo);
            if (leituras.Contains(leitura))
                MessageBox.Show("A leitura para esta casa já foi registrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                this.leituras.Add(leitura);
                IniciarFormulario();
            }
        }

        private void IniciarFormulario()
        {
            txtNCasa.Clear();
            txtConsumo.Clear();
            txtNCasa.Focus();
        }

        private void btnProcessarDados_Click(object sender, EventArgs e)
        {
            ProcessarLeituras(dvgResumo);
        }

        private void ProcessarLeituras(DataGridView dvg)
        {
            DataGridViewCell cell = dvgResumo.Rows[0].Cells[0];
            this.leituras.Add(new Leitura("Total", 0));

            for (int i = 0; i < 3; i++)
            {
                dvg.Rows[dvgResumo.Rows.Count - 1].Cells[i].Style.BackColor = Color.Blue;
                dvg.Rows[dvgResumo.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Yellow;
                dvg.Rows[dvgResumo.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }

            double totalCounsumo = 0.0, totalDisconto = 0.0;

            foreach (var leitura in leituras)
            {
                totalCounsumo += leitura.Consumo;
                totalDisconto += leitura.Disconto;
            }

            dvg[0, dvg.Rows.Count - 1].Value = "Total";
            dvg[1, dvg.Rows.Count - 1].Value = totalCounsumo;
            dvg[2, dvg.Rows.Count - 1].Value = totalDisconto;
            lblResultado.Text = "Total de consumo sem disconto: " + (totalCounsumo - totalDisconto).ToString("N");
        }
    }
}
