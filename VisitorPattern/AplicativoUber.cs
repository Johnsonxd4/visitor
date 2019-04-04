using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class AplicativoUber
    {
        private List<UsuarioUber> _usuariosUber = new List<UsuarioUber>();

        public void Attach(UsuarioUber usuario)
        {
            _usuariosUber.Add(usuario);
        }

        public void Detach(UsuarioUber usuario)
        {
            _usuariosUber.Remove(usuario);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (UsuarioUber e in _usuariosUber)
            {
                e.Accept(visitor);
            }
        }
    }
}
