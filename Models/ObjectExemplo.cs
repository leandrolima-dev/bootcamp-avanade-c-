using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    //Toda classe herda de Object, por exemplo: seria como se a classe fosse - public class ObjectExemplo : Object
    public class ObjectExemplo
    {
        public override string ToString()
        {
            return "Metodo ToString() da classe Object sobrescrito";
        }
    }
}