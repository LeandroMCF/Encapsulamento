namespace Encapsulamento.Classes
{
    public class Mastercard : Cartao
    {
        private int parcelas;

        //Get e Set
        public int Parcelas{
            get{ return parcelas;} //Pegar dados
            set{ parcelas = value;} //Inserir dados
        }

        //metodos
        public string ComprarComDesconto(){

            return "";

        }
    }
}