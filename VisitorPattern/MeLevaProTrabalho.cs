using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class MeLevaProTrabalho : IVisitor
    {
        public void Visit(Element element)
        {
            var usuarioUber = element as UsuarioUber;
            Console.WriteLine($"Levando usuario uber de {usuarioUber.OndeEstou} para o trabalho que fica em {usuarioUber.Trabalho}");
            usuarioUber.OndeEstou = usuarioUber.Trabalho;
        }
    }
}
