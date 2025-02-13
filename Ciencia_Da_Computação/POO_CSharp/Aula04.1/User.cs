using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04._1
{
    public class User
    {
        public int id;
        public string nome;
        public string cpf;
        public List<Bilhete> bilhetes = new List<Bilhete>(); 

        public User(string nome,string cpf) 
        {
            
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
