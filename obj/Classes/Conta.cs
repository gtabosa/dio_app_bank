namespace Dio.bank
{
    public class Conta
    {
        // Atributos
		private TipoConta TipoConta { get; set; }
		private double Saldo { get; set; }
		private double Credito { get; set; }
		private string Nome { get; set; }

		// Métodos
		public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
		{
			this.TipoConta = tipoConta;
			this.Saldo = saldo;
			this.Credito = credito;
			this.Nome = nome;
		}

        public bool Sacar (double valorSaque)
        {
            //Validação de saldo insuficiente
            if(this.saldo - valorSaque <(this.Credito*-1)
                {
                Console.WriteLine("Saldo insuficiente");
                return false;
                }
             )
             this.Saldo -=valorSaque;
             Console.WriteLine("Saldo atual da conta de {0} e de {1}",this.Nome,this.Saldo);
             return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo+=valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} e de {1}",this.Nome,this.Saldo);
        }

        public void Transferir(double valorTransferencia,Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }
    }
}