﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TopScore
{
    class Contador
    {
        private int _pontos;
        private int _tempo;
        
        public string Score()
        {
            if (_tempo > 0)
            {
                _pontos += 1;
            }
            return _pontos.ToString();
        }

        public string Tempo()
        {
            if (_tempo > 0)
            {
                _tempo -= 1;
            }
            return _tempo.ToString();
        }

        public string ComeçarPontos()
        {
            _pontos = 0;
            return (_pontos).ToString();
        }

        public string ComeçarTempo()
        {
            _tempo = 60;
            return (_tempo).ToString();
        }
        public void Move(object sender)
        {
            if (_tempo > 0)
            {
                Random r = new Random();
                int _x = int.Parse(r.Next(500).ToString());
                int _y = int.Parse(r.Next(250).ToString());
                Point pt = new Point(_x, _y);
                Button b = (Button)sender;
                b.Location = pt;
            }
        }
    }
}
