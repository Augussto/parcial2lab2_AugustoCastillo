using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnCamisa_CheckedChanged(object sender, EventArgs e)
        {
            cboxBermuda.Enabled = false;
            cboxBermuda.Checked = false;
            cboxMangaCorta.Enabled = true;
        }

        private void rbtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            cboxMangaCorta.Enabled = false;
            cboxMangaCorta.Checked = false;
            cboxBermuda.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbtnCamisa.Checked || rbtnPantalon.Checked)
            {
                if(rbtnPremium.Checked || rbtnStandard.Checked)
                {
                    if (Utiles.validaCampos(txtPrecio.Text))
                    {
                        if(Utiles.validaCampos(txtCantidad.Text)){

                            //CAMISAS

                            if (rbtnCamisa.Checked)
                            {
                                Camisa c = new Camisa();
                                c.MangaCorta = cboxMangaCorta.Checked;
                                c.Premium = rbtnPremium.Checked;
                                c.Standard = rbtnStandard.Checked;
                                c.Precio = Convert.ToInt32(txtPrecio.Text);
                                c.Cantidad = Convert.ToInt32(txtCantidad.Text);

                                MessageBox.Show("El Precio a pagar es de "+ c.calcularPrecio());

                            }

                            //PANTALONES

                            if (rbtnPantalon.Checked)
                            {
                                Pantalon p = new Pantalon();
                                p.Bermuda = cboxBermuda.Checked;
                                p.Premium = rbtnPremium.Checked;
                                p.Standard = rbtnStandard.Checked;
                                p.Precio = Convert.ToInt32(txtPrecio.Text);
                                p.Cantidad = Convert.ToInt32(txtCantidad.Text);

                                MessageBox.Show("El Precio a pagar es de " + p.calcularPrecio());

                            }

                        }
                        else
                        {
                            MessageBox.Show("Error al Ingresar Cantidad");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al Ingresar Precio");
                    }
                }
                else
                {
                    MessageBox.Show("Calidad de Prenda no Ingresada");
                }
            }
            else
            {
                MessageBox.Show("Tipo de Prenda no Ingresado");
            }
        }
    }
}
