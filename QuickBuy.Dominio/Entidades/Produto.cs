namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string preco { get; set; }

        public override void Validate()
        {
            if(string.IsNullOrEmpty(preco))
                AdicionarCritica("Não foi informado o preco");
        }
    }
}
