using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_perimetro
{
    public class Retangulo : Figura
    {
        private double _base;  
        private double _altura;
        public double Base  
        {
            get
            {
                return this._base;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Base inválida");
                }
                else
                {
                    this._base = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Altura  
        {
            get
            {
                return this._altura;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura inválida");
                }
                else
                {
                    this._altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Retangulo (double baase, double altura)
        {
            this.Base = baase;
            this.Altura = altura;
        }
        private void AtualizarArea()
        {
            this._area =this._base*this._altura;
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = 2* this._base + 2*this._altura;
        }
    }
}
