namespace Pokedex2020ProgIIIv2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPokemones = new System.Windows.Forms.DataGridView();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemones
            // 
            this.dgvPokemones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemones.Location = new System.Drawing.Point(13, 13);
            this.dgvPokemones.Name = "dgvPokemones";
            this.dgvPokemones.Size = new System.Drawing.Size(240, 150);
            this.dgvPokemones.TabIndex = 0;
            this.dgvPokemones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvPokemones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPokemones_MouseClick);
            // 
            // pbPokemon
            // 
            this.pbPokemon.Location = new System.Drawing.Point(259, 13);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(164, 150);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokemon.TabIndex = 1;
            this.pbPokemon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 172);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.dgvPokemones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemones;
        private System.Windows.Forms.PictureBox pbPokemon;
    }
}

