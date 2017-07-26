using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeracion
{
    public enum eGuitarras
    // para declarar una enumeracion hay que crear una clase, y luego cambiar su firma por "public enum eNombre"
    {
        ninguno,
        electrica,
        criolla,
        acustica,
        dobro

        // los literales toman los valores sucesivos de enteros comenzando por 0, excepto que se indique lo contrario
     
        
        //electrica, valdria 0
        //criolla = 15,
        //acustica, //valdria 16
        //dobro  //valdria 17
        
         
    }
}
