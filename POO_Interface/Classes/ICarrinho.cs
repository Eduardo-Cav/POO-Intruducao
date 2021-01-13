namespace POO_Interface.Classes
{
    //nao se instacia interclasse, usada apenas para implementar metódos
    public interface ICarrinho
    {
        //create - cadastrar
        void Cadastrar(Produto product);

        //read - ler 
        void Listar();

        //update - alterar/atualizar
        void Alterar(int code, Produto product);

        //delete - deletar/apagar
        void Deletar(Produto product);

    }
}