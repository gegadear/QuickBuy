﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
   public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        ///<sumary>
        /// Um usuario pode ter nenhum ou muitos pedido
        /// </sumary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não informa");
        }
    }
}
