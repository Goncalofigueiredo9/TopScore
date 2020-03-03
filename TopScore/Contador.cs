using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string ResetarPontos()
        {
            _pontos = 0;
            return (_pontos).ToString();
        }

        public string ResetarTempo()
        {
            _tempo = 60;
            return (_tempo).ToString();
        }
    }
}
