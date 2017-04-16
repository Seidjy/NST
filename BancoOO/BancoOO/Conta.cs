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
            if (Saldo < valor)
            {
                if (valor < 1000)
                {
                    Saldo -= (valor + 0.10m);
                    return true;
                }
            }            
            return false;
        }

        public void Credito(decimal valor)
        {
            Saldo += valor;
        }



    }
}