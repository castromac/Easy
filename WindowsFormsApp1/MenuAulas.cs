﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuAulas : Form
    {
        public MenuAulas()
        {
            InitializeComponent();
            
        }

        private void btOuvir_Click(object sender, EventArgs e)
        {
            MenuPrincipal novo = new MenuPrincipal();
            novo.Visible=false;
            axWindowsMediaPlayer1.URL = "C:/Users/Mauricio/source/repos/Easy/WindowsFormsApp1/gifs/video.mp4";
            Aula1 nova = new Aula1();
            nova.Show();
           
            this.Hide();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void MenuAulas_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuPrincipal novo = new MenuPrincipal();
            novo.Visible = false;
            //axWindowsMediaPlayer1.URL = "C:/Users/Mauricio/source/repos/Easy/WindowsFormsApp1/gifs/video.mp4";
            Aula2 nova = new Aula2();
            nova.Show();

            this.Hide();


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}