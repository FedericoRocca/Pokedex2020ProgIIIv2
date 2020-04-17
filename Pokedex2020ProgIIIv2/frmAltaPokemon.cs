using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2020ProgIIIv2
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                cmbTipo.DataSource = negocio.listar();
                Pokemon poke = new Pokemon();
                poke.nombre = txtNombre.Text.Trim();
                //poke.tipo = cmbTipo.SelectedItem;
                
                //Tengo que overridear a tipo.tostring()
                //public override string ToString()
                //{
                //    return Descripcion;
                //}
    }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
