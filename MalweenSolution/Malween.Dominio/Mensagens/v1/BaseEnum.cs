using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.Mensagens.v1
{
    public class BaseEnum<T, Y> where T : BaseEnum<T, Y>
    {
        public int Codigo { get; protected set; }
        public Y Valor { get; protected set; }

        protected BaseEnum(int codigo, Y valor)
        {
            Codigo = codigo;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Codigo}|{Valor}";
        }
    }
}
