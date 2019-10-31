using System;

namespace QuickBuy.Dominio.Entidades
{
    internal class List<T>
    {
        internal void Clear()
        {
            throw new NotImplementedException();
        }

        internal bool Any()
        {
            throw new NotImplementedException();
        }

        internal void Add(string mensagem)
        {
            if (mensagem is null)
            {
                throw new ArgumentNullException(nameof(mensagem));
            }

            throw new NotImplementedException();
        }
    }
}