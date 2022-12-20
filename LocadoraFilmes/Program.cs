
using LocadoraFilmes.Facade;
using LocadoraFilmes.Model;

namespace LocadoraFilmes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMovieFacade _movieFacade = new MovieFacade();

            _movieFacade.InsertMovie(new Movie() { 
                MovieDuration = 2.15F,
                MovieName = "A espera de uma mate",
                MovieDescription = "Pessoas esperam mates, enquanto o mundo está sofrendo um ataque alienígena, apenas os bagual conseguirão sobreviver"
            });


            Console.WriteLine("Escolha uma Opção");
            Console.WriteLine(GetMenu());

            string? opcao = Console.ReadLine();

            if (!string.IsNullOrEmpty(opcao))
                switch (opcao)
                {
                    case "C":
                        Console.WriteLine("Voce escolheu inserir um filme");
                        break;
                    case "R":
                        Console.WriteLine("Voce escolheu buscar um filme");
                        break;
                    case "U":
                        Console.WriteLine("Voce escolheu atualizar um filme");
                        break;
                    case "D":
                        Console.WriteLine("Voce escolheu deletar um filme");
                        break;
                    default:
                        Console.WriteLine("OPCAO INVALIDA");
                        break;
                }
            else
                Console.WriteLine("VOCE PRECISA INSERIR UMA OPCAO");

        }


        public static string GetMenu()
            => $@"
                ---------------------------------------------
                |            LOCADORA BAGUAL                |
                |                                           |
                |   C - Inserir Filme                       |
                |   R - Buscar Filme                        |
                |   U - Atualizar Filme                     |
                |   D - Deletar Filme                       |
                |                                           |
                |                                           |
                |           by Marcus & Wiliam              |
                ---------------------------------------------
                ";
    }
}