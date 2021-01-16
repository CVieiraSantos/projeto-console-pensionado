using System.Text;
using System;
namespace Genericos.Entities
{
    public class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }
        
        
        
        public Estudante(string name, string email, int quarto)
        {
            Name = name;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Quartos ocupados");
            sb.Append(Quarto);
            sb.Append(": ");
            sb.Append(Name);
            sb.Append(", ");
            sb.AppendLine(Email);
                                    
            return sb.ToString();

           
                        
        }

        
    }
}