namespace VisitorPattern
{
    public class UsuarioUber : Element
    {

        public UsuarioUber(string nome,string casa, string trabalho, string ondeEstou)
        {
            Nome = nome;
            Casa = casa;
            Trabalho = trabalho;
            OndeEstou = ondeEstou;
        }

        public string Nome { get; set; }
        public string Casa { get; set; }
        public string Trabalho { get; set; }
        public string OndeEstou { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

