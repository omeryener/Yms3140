﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_InheritanceSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();
            Departman d = new Departman();
            d.DemirbasSayisi = 5;
            d.Ad = "BT";
            d.DepartmanSorumlusu = "Fatih";
            p.Departman = d;
        }
    }
}
