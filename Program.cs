// --------------- lISTA DE EXERCICIOS  -------------- //

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Exercicio 01

        Console.Write("Insira seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"\nOla {nome}! Seja muito bem-vindo!");


        // Exercicio 02

        Console.Write("Insira seu nome: ");
        string primeiroNome = Console.ReadLine();

        Console.Write("Insira seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine("\nNome completo: " + primeiroNome + " " + sobrenome);


        // Exercicio 03

        double numero1, numero2;

        Console.Write("Insira o primeiro numero: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.Write("Insira o segundo numero: ");
        numero2 = double.Parse(Console.ReadLine());

        if( numero2 == 0)
        {
            Console.WriteLine("\nERRO DIVISÃO POR 0!");
            return;
        }

        Console.WriteLine($"\nSoma entre os numeros: {numero1 + numero2}");
        Console.WriteLine($"Subtração entre os numeros: {numero1 - numero2}");
        Console.WriteLine($"Multiplicação entre os numeros: {numero1 * numero2}");
        Console.WriteLine($"Divisão entre os numeros: {numero1 / numero2}");
        Console.WriteLine($"Media entre os numeros: {(numero1 + numero2) / 2}");


        // Exercicio 04

        Console.Write("Insira uma ou mais palavras: ");
        string palavra = Console.ReadLine();

        palavra = palavra.Replace(" ", "");

        Console.WriteLine($"Quantidade de caracteres: {palavra.Length}");


        // Exercicio 05

        Console.Write("Insira a placa do veiculo: ");
        string placa = Console.ReadLine();

        bool qtdDigitos = false, 
             tresPrimeirosDig = false,
             quatroUltimosDig = false;

        if (placa.Length != 7)
        {
            qtdDigitos = true;
        }

        for (int i = 0; i < 3; i++)
        {
            var testeTresPrimeirosDigitos = placa[i];

            if (char.IsDigit(testeTresPrimeirosDigitos))
            {
                tresPrimeirosDig = true;
            }

            for (int j = 3; j < 7; j++)
            {
                var testeQuatroUltimosDigitos = placa[j];

                if (!char.IsDigit(testeQuatroUltimosDigitos))
                {
                    quatroUltimosDig = true;
                }
            } 
        }


        if (qtdDigitos || tresPrimeirosDig || quatroUltimosDig)
        {
            Console.WriteLine("\nFalso");
        }
        else
        {
            Console.WriteLine("\nVerdadeiro");
        }


        // Exercicio 06

        DateTime dataAgora = new DateTime(2024, 08, 12, 18, 43, 20);

        string diaSemana = dataAgora.ToString("dddd"),
            diaMes = dataAgora.ToString("dd"),
            mes = dataAgora.ToString("MM"),
            mesExtenso = dataAgora.ToString("MMMM"),
            ano = dataAgora.ToString("yyyy"),
            hora = dataAgora.ToString("HH"),
            minuto = dataAgora.ToString("mm"),
            segundo = dataAgora.ToString("ss");


        string formatoCompleto = "(dia da semana (" + diaSemana +"), dia do mês (" + diaMes + "), mês (" + mes + "), ano (" + ano + "), hora (" + hora + "), minutos (" + minuto + "), segundos (" + segundo + "): ";
        string formatoPadrao = $"{diaMes}/{mes}/{ano}";
        string horaPadrao = $"{hora}:{minuto}:{segundo}";
       

        Console.Write($"Insira a data atual no formato completo {formatoCompleto}");
        string dataCompletaUser = Console.ReadLine();

        Console.Write($"\nInsira a data atual no formato padrão \"{formatoPadrao}\": ");
        string dataUser = Console.ReadLine();

        Console.Write($"\nInsira a hora atual no formado de 24 horas \"{horaPadrao}\": ");
        string horaUser = Console.ReadLine();

        Console.Write($"\nInsira a data com o mês por extenso \"{diaMes}/{mesExtenso}/{ano}\": ");


    }
}