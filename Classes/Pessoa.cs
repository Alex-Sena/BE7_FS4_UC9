using BE7_FS4_UC9.Interfaces;

namespace BE7_FS4_UC9.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?name { get; set; }
        public string ?endereco { get; set; }
        public string ?rendimento { get; set; }

        
        public abstract float PagarImposto(float reindimento);
        
    }
}