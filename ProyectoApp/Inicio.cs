﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void DesplegarMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 150)
            {
                MenuVertical.Width = 0;
            }
            else
            {
                MenuVertical.Width = 150;
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Ventana.Visible = true;
        }

        private void Ventana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Ventana.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtLecciones_Click(object sender, EventArgs e)
        {
            LeccionesForm Frm = new LeccionesForm();
            Frm.TopLevel = false;
            Cuerpo.Controls.Add(Frm);
            Frm.Show();
        }

        private void Cabeza_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
