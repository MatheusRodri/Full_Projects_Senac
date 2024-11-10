using Aula08._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09._3
{
    public class Camera
    {
        public void show(Funcionario funcionario)
        {
            Console.WriteLine($"{funcionario.nome} acessou a camera publica");
        }
    }
}
