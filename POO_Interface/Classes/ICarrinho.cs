namespace POO_Interface.Classes
{
    public interface ICarrinho
    {
        //create
        void Listar();

        //read
        void Cadastrar(Produto product);

        //update
        void Alterar(int code, Produto product);

        //delete
        void Deletar(Produto product);

    }
}