namespace Encapsulamento.Classes
{
    public class Cartao
    {
        private string numero;
        private string bandeira = "Mastercard";
        protected string token = "qwertyui";
        private string cvv;
        protected float limite = 5000;

        //Get e Set
        public string Numero{
            get{return numero;}
            set{numero = value;}
        }
        public string Bandeira{
            get{return bandeira;}
        }
        public string Token{
            get{return token;}
        }
        public string Cvv{
            get{return cvv;}
            set{cvv = value;}
        }
        public float Limite{
            get{return limite;}
        }

        //metodos
        public string RegistrarConta(bool validado){
            return "";
        }
        private bool ValidarCompra(float saldo){
            return true;
        }
        protected string ValidarToken(string token){
            return "";
        }        
    }
}