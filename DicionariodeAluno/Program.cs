// Dicionário de Alunos
//Pedro Henrique de Souza Ramos
// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela
using System;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        string mensagemInicial = "Dicionário com lista de notas do Aluno!";
        Dictionary<string,List<float>> nomesRegistrados = new Dictionary<string, List<float>>();

        void ExibirTitulo()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine(mensagemInicial);
            Console.WriteLine("*******************************");
        }

        void opcoesMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar nome de um aluno");
            Console.WriteLine("Digite 2 para mostrar todas os nomes de alunos");
            Console.WriteLine("Digite 3 para avaliar nota de um aluno");
            Console.WriteLine("Digite 4 para exibir a média de um aluno");
            Console.WriteLine("Digite -1 para sair");
            Console.Write("\nDigite a sua opçao: ");

            string escolha = Console.ReadLine()!;
            int opcaoNumber = int.Parse(escolha);

            switch(opcaoNumber)
            {
                case 1: 
                    registraNomeAluno();
                    break;
                case 2:
                    mostrarNomes();
                    break;
                case 3:
                    avaliarNotas();
                    break;
                case 4:
                    mediadeNotas();
                    break;
                case -1:
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Você digitou uma opçao inválida: " + escolha);
                    break;
            }
        }
        void ExibiropcaoMenu(string titulo)
        {
            int quantLetras = titulo.Length;
            string caractEspec = string.Empty.PadLeft(quantLetras, '-');
            Console.WriteLine(caractEspec);
            Console.WriteLine(titulo);
            Console.WriteLine(caractEspec + "\n");
        }

        void registraNomeAluno()
        {
            Console.Clear();
            ExibiropcaoMenu("Registro de Nomes dos Alunos(as)");
            Console.Write("Digite o nome do aluno(a): ");
            string nomeAluno = Console.ReadLine()!;
            nomesRegistrados.Add(nomeAluno, new List<float>());
            Console.WriteLine($"Aluno(a) {nomeAluno} foi registrado com sucesso!");
            Thread.Sleep(2500);
            Console.Clear();
            ExibirTitulo();
            opcoesMenu();

        }

        void mostrarNomes()
        {
            Console.Clear();
            ExibiropcaoMenu("Exibindo todos os Nomes de Alunos(as) Registrados!");
            foreach(string nome in nomesRegistrados.Keys)
            {
                Console.WriteLine($"Nome: {nome}");
            }
            Console.Write("\nDigite uma tecla para voltar ao Menu Principal");
            Console.ReadKey();
            Console.Clear();
            ExibirTitulo();
            opcoesMenu();

        }

        void avaliarNotas()
        {
            Console.Clear();
            ExibiropcaoMenu("Avaliar Nota de Aluno!");
            Console.Write("Digite o nome do Aluno(a) que deseja avaliar: ");
            string nomeAluno = Console.ReadLine()!;

            if(nomesRegistrados.ContainsKey(nomeAluno))
            {
                Console.Write($"Qual a nota do aluno(a) {nomeAluno} : ");
                int nota = int.Parse(Console.ReadLine()!);
                nomesRegistrados[nomeAluno].Add(nota);
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o aluno(a) {nomeAluno}");
                Thread.Sleep(3000);
                Console.Clear();
                ExibirTitulo();
                opcoesMenu();
            }
            else
            {
                Console.WriteLine($"\nAluno(a) {nomeAluno} não foi encontrado.");
                Console.Write("\nDigite uma tecla para voltar ao Menu Principal");
                Console.ReadKey();
                Console.Clear();
                ExibirTitulo();
                opcoesMenu();
            }
        }

        void mediadeNotas()
        {
            Console.Clear();
            ExibiropcaoMenu("Media de Notas de Aluno(a)!");
            Console.Write("Digite o nome do Aluno(a) que deseja a media: ");
            string nomeAluno = Console.ReadLine()!;
            
            if (nomesRegistrados.ContainsKey(nomeAluno))
            {
                List<float> media = nomesRegistrados[nomeAluno];
                Console.WriteLine($"\nA media do aluno(a) {nomeAluno} e {media.Average()}");                
                Console.Write("\nDigite uma tecla para voltar ao Menu Principal");
                Console.ReadKey();
                Console.Clear();
                ExibirTitulo();
                opcoesMenu();
            }
            else
            {
                Console.WriteLine($"\nAluno(a) {nomeAluno} não foi encontrado.");
                Console.Write("\nDigite uma tecla para voltar ao Menu Principal");
                Console.ReadKey();
                Console.Clear();
                ExibirTitulo();
                opcoesMenu();
            }
        }

        ExibirTitulo();
        opcoesMenu();
    }
}
