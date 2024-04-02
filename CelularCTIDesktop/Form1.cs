using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI.Model;
using CelularCTI.Model.Entidades;

namespace CelularCTIDesktop
{
    public partial class Form1 : Form
    {
        private List<Aparelho> aparelhos = new List<Aparelho>();
        private List<Fabricante> fabricantes = new List<Fabricante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.TodosFabricantes();
            cmbFabricante.DataSource = fabricantes;
            cmbFabricante.DisplayMember = "Name";
            cmbFabricante.ValueMember = "id_Fabricante";

            aparelhos = Servico.BuscarAparelho("");
            lstCelular.DataSource = aparelhos;
            
        }
    }
}
