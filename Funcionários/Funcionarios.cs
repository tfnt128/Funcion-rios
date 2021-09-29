using System.Globalization;

namespace Funcionários
{
    class Funcionarios
    {
        //adição das propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        //construtor padrão
        public Funcionarios()
        {
        }

        //construtor
        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        //método do aumento
        public void aumentarSalario(double porcen)
        {
            Salario = Salario + (Salario * porcen / 100.0);
        }

        //conversor para string
        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
