using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_perimetro
{
    public class Figura
    {
        protected double _area;  
        protected double _perimetro;
        public List<Figura> Lista = new();

        public void Criar()
        {
            Circulo circulo;
            Retangulo retangulo;
            int figura;
            int quero;
            Console.WriteLine("Bem vindo ao Catálogo de Figuras");
            Console.WriteLine("Vamos adicional algumas figuras...");
            do
            {
                Console.WriteLine("Quer adicionar:\n [1] Círculo \n [2] Retângulo");
                figura = Convert.ToInt32(Console.ReadLine());
                if (figura == 1)
                {
                    Console.WriteLine("Digite o valor do raio do círculo");
                    double raio = Convert.ToDouble(Console.ReadLine());
                    circulo = new(raio);
                    Lista.Add(circulo);
                    Console.Clear();
                    Console.WriteLine("Círculo criado!");
                }
                else if (figura == 2)
                {
                    Console.WriteLine("Digite o valor da base");
                    double baase = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    retangulo = new Retangulo(baase, altura);
                    Lista.Add(retangulo);
                    Console.Clear();
                    Console.WriteLine("Retângulo criado!");
                }
                else
                {
                    Console.WriteLine("Entre com um valor válido, por favor");
                }
                
                Console.WriteLine("Deseja continuar adicionando figuras?\n [1] Sim \n [outro] Não");
                quero = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }
            while (quero == 1);
        }
        public void Listar()
        {
            Console.Clear();
            Console.WriteLine("Eis sua lista de figuras:");
            int local = 1;
            foreach (var elemento in Lista)
            {
                Console.WriteLine("Figura nº " + local);
                Console.WriteLine("Área:\t"+elemento.Area);
                Console.WriteLine("Perímetro:\t"+elemento.Perimetro);
                local++;
            }
            Console.WriteLine("\n \nEssa foi a lista das figuras adicionadas");
        }

        public double Area 
        {
            get { return this._area; }
        }

        public double Perimetro  
        {
            get { return this._perimetro; }
        }

        public static void Tchau()
        {
            var sim = new string[] { "sim", "Sim", "ok", "Ok", "OK", "s", "S",};
            var nao = new string[] { "não", "Não", "nao", "Nao", "n", "N",};
            string quero;
            Console.WriteLine("\n \nTudo feito. Encerrarei minhas atividades agora, ok?");
            quero = Console.ReadLine();
            if (sim.Contains(quero))
            {
                Console.WriteLine("\n \n \nOk então... Até a próxima!\n \n \n \n \n");
            }          
            else if (nao.Contains(quero))
            {
                Console.WriteLine("\n \n \nFoi uma pergunta retórica, espertão... Até a próxima!\n \n \n \n \n");
            }            
            else
            {
                Console.WriteLine("\n \n \nComo? não entendi o que você disse... Ah, tanto faz. Até a próxima!\n \n \n \n \n");
            }
        }

    }
}
