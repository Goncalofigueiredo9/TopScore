using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TopScore
{
    class Contador
    {
        private int _pontos;
        private int _tempo;
        private static string _path = Application.StartupPath + "\\Resources\\Record.txt";
        private int _rec = Int32.Parse(File.ReadAllText(_path));

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
            {
                Random r = new Random();
                int _x = int.Parse(r.Next(500).ToString());
                int _y = int.Parse(r.Next(250).ToString());
                Point pt = new Point(_x, _y);
                Button b = (Button)sender;
                b.Location = pt; 
            }
        }
        public string Abrir
        {
            get
            {
                string _texto = File.ReadAllText(_path);
                return _texto;
            }
        }
        public void Gravar(string valor)
        {
            File.WriteAllText(_path, valor);
        }
        public void Record(object pontos, object record)
        {
            {
                TextBox _pontos = (TextBox)pontos;
                TextBox _record = (TextBox)record;
                int _max = Convert.ToInt32(_record.Text);
                int _pts = Convert.ToInt32(_pontos.Text);
                if (_max < _pts)
                {
                    _record.Text = _pontos.Text;
                    this.Gravar(_record.Text);
                }
            }
        }
        public void Gravar()
        {
            if (_pontos > _rec)
            {
                File.WriteAllText(_path, _pontos.ToString());
            }
        }
        public string Ler
        {
            get
            {
                _rec = Int32.Parse(File.ReadAllText(_path));
                return _rec.ToString();
            }
        }
    }
}
