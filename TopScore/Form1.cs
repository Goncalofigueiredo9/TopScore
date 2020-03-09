﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TopScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = clique.Abrir;
        }


        Contador clique = new Contador();

        private void Button1_Click(object sender, EventArgs e)
        {
            clique.Move(sender);
            textBox1.Text = clique.Score();
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Text = clique.ComeçarPontos();
            textBox2.Text = clique.ComeçarTempo();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = clique.Tempo();
            clique.Gravar();
            Record.Text = clique.Ler;
        }
    }
}

