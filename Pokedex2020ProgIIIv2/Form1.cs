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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            dgvPokemones.DataSource = negocio.listar();
            dgvPokemones.Columns[0].Visible = false;
            dgvPokemones.Columns[3].Visible = false;
            dgvPokemones.Columns[4].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPokemones_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Pokemon pokemon = new Pokemon();
                pokemon = (Pokemon)dgvPokemones.CurrentRow.DataBoundItem;
                pbPokemon.Load(pokemon.urlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
