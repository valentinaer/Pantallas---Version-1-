﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TP
{
    public partial class SolicitudDeServicio : Form
    {
        public SolicitudDeServicio()
        {
            InitializeComponent();
        }

        private void cmbRangoPeso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSucursalesDestino.Items.Add("1- Cordoba 6571, CABA");

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }


        private void lblMenuPrincipal_Click(object sender, EventArgs e)
        {

        }


        private void rboRecibeSucursal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void grpCotizacion_Enter(object sender, EventArgs e)
        {

        }

        private void SolicitudDeServicioNacional_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int tracking = Autonumerar();
            MessageBox.Show($"La solicitud de servicio se registro de forma exitosa. \n " +
                $"Su numero de trackeo es: tracking");
        }

        private int Autonumerar()
        {
            Random r = new Random();
            return r.Next(0001, 9999);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProvinciaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvinciaOrigen.Text == "BUENOS AIRES")
            {
                cmbCiudadOrigen.Items.Clear();
                cmbCiudadOrigen.Items.Add("Mar del Plata");
                cmbCiudadOrigen.Items.Add("Quilmes");
                cmbCiudadOrigen.Items.Add("Bahia Blanca");
                cmbCiudadOrigen.Items.Add("Salto");
            }
            else if (cmbProvinciaOrigen.Text != "BUENOS AIRES")
            {
                cmbCiudadOrigen.Items.Clear();
                cmbCiudadOrigen.Items.Add("NO IMPLEMENTADO");
            }
        }


        private void cmbRegionI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegionI.Text == "Europa")
            {
                cmbPaisCiudadDestino.Items.Clear();
                cmbPaisCiudadDestino.Items.Add("Madrid España");
                cmbPaisCiudadDestino.Items.Add("Paris, Francia");
                cmbPaisCiudadDestino.Items.Add("Roma, Italia");
                cmbPaisCiudadDestino.Items.Add("Berlin, Alemania");
            }
            else if (cmbProvinciaDestino.Text != "Europa")
            {
                cmbPaisCiudadDestino.Items.Clear();
                cmbPaisCiudadDestino.Items.Add("NO IMPLEMENTADO");
            }
        }

        private void cmbProvinciaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvinciaDestino.Text == "BUENOS AIRES")
            {
                cmbCiudadDestino.Items.Clear();
                cmbCiudadDestino.Items.Add("Mar del Plata");
                cmbCiudadDestino.Items.Add("Quilmes");
                cmbCiudadDestino.Items.Add("Bahia Blanca");
                cmbCiudadDestino.Items.Add("Salto");
            }
            else if (cmbProvinciaDestino.Text != "BUENOS AIRES")
            {
                cmbCiudadDestino.Items.Clear();
                cmbCiudadDestino.Items.Add("NO IMPLEMENTADO");
            }
        }
    }
}
