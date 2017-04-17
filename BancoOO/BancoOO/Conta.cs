namespace BancoOO
{
    public class Conta
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public decimal Saldo { get; set; }
        public string Tipo { get; set; }

        public virtual bool Saque(decimal valor)
        {
            if(valor > Saldo)
            {
                return false;
            }
            Saldo -= valor;
            return true;
        }

        public void Debito(decimal valor)
        {
            Saldo += valor;
        }
    }
}