using System;

namespace VisitorPattern
{
    public class MeLevaPraCasa : IVisitor
    {
        public void Visit(Element element)
        {
            var usuarioUber = element as UsuarioUber;
            Console.WriteLine($"Levando usuario {usuarioUber.Nome} de {usuarioUber.OndeEstou} para casa que fica em {usuarioUber.Casa}");
            usuarioUber.OndeEstou = usuarioUber.Casa;
        }
    }
}
