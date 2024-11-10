using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula08;


namespace Aula09._3
{
    
    public class CameraDeSeguranca
    {
        public void show(IAcesso acesso)
        {
            Console.WriteLine($"{acesso.Nome()} Esteve aqui");
        }

    }
}
