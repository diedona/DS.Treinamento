using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Treinamento.Inicial.Dominio
{
    public class Loja
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{{ Id: {Id}, Nome: {Nome} }}";
        }
    }
}
