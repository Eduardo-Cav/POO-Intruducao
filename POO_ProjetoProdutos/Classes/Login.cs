using System;

namespace ProjetoProdutos.Classes
{
    public class Login
    {
        public bool Logado { get; set; }
        

        public Login(){
            Logar();

            if(Logado == true){
                Menu();
            }
        }

        public void Menu(){

            Produto p = new Produto();
            Marca m = new Marca();

            string opcao = "n";
            do
            {
                Console.WriteLine($"O que você deseja realizar?");
                
                Console.WriteLine($"[1] - Cadastrar marca");
                Console.WriteLine($"[2] - Listar marca ");
                Console.WriteLine($"[3] - Excluir marcas");
                Console.WriteLine($"[4] - Cadastrar produto");
                Console.WriteLine($"[5] - Listar produtos");
                Console.WriteLine($"[6] - Excluir produto");
                Console.WriteLine($"[0] - Sair");
                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                    m.Cadastrar();
                        break;

                    case "2":
                    m.Listar();
                        break;

                    case "3":
                    Console.WriteLine($"Qual o código da marca que deseja excluir? ");
                    int codeMarca = int.Parse(Console.ReadLine());
                    m.Deletar(codeMarca);
                        break;

                    case "4":
                    p.Cadastrar();
                        break;

                    case "5":
                    p.Listar();
                        break;

                    case "6":
                    Console.WriteLine($"Qual o código do produto que deseja excluir? ");
                    int codeProduto = int.Parse(Console.ReadLine());
                    m.Deletar(codeProduto);
                        break;

                    default:
                        break;
                }
                
                
            } while (opcao != "0");

        }

        public void Logar(){
            Usuario user = new Usuario();

            Console.WriteLine("Digite seu Email: ");
            string logarEmail = Console.ReadLine();
            
            Console.WriteLine($"Digite sua senha: ");
            string logarSenha = Console.ReadLine();
            
            if(logarEmail == user.Email && logarSenha == user.Senha){
                Logado = true;
                Console.WriteLine($"Login concluido!");    
            }else{
                Console.WriteLine($"Falha no login, tente novamente."); 
            }
        }

        public void Deslogar(){
            Logado = false;
        }
    }
}