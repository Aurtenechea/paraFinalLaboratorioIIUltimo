using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{

    // operador is, gettyoe, typeof... 

    // casteo directo para centralita ((local) item).nombreMetodo


    // temas parcial
    // como se crea un constructor, correctos e incorrectos identificar. *
    // sobrecarga de operadores implicito y explicito. 
    // arrays crear y recorrer.
    // metodo de instancia y estatico.. utilizacion del this.
    // constructores static..
    // prop de lectura, escritura.
    // diferencias e igualdades...metodo de instancia y estatico... constructores y metodos... propiedades y atributos..
    // errores de sintaxis,

    // que muestra:
    // alumno abstract = new alumno();
    // a.nombre = "jose";
    // alumno b = (string)"pepe";
    // alumno c = new alumno();
    // c.nombre = "maria";
    // alumno d = new Alumno();
    // b=a;
    // d=b;
    // a.nombre = "natalia";
    // console.write(d);  (muestra natalia.)


    //alumno persona = new persona();
    //alumno a; a=new alumno;
    //alumno persona = persona();
    
    class Program
    {
        static void Main(string[] args)
        {
            Producto ProductoUno = new Producto(666,"JamonDelDiablo", eTipoComestible.Solido,2);
            Producto ProductoDos = new Producto(33, "JamonDeDios", eTipoComestible.Solido,10);
            Producto ProductoTres = new Producto(55, "Sprite", eTipoComestible.Liquido, 10);
            Producto ProductoCuatro = new Producto(666, "JamonDelDiablo", eTipoComestible.Solido);
            Container ContenerdorUno = new Container(2, "Skanka");
            Container ContenerdorDos = new Container(3, "Skanka");
            List<Producto> listaProducto = new List<Producto>();
            ContenerdorUno.Agregar(ProductoUno);
            ContenerdorUno.Agregar(ProductoDos);
            if(! ContenerdorUno.Agregar(ProductoTres)) {
                Console.WriteLine("No se pudo");
            }
            ContenerdorDos.Agregar(ProductoUno);
            ContenerdorDos.Agregar(ProductoDos);
            if (!ContenerdorDos.Agregar(ProductoCuatro)) {
                Console.WriteLine("No se pudo");
            }
            ContenerdorDos.Agregar(ProductoTres);
            Container.Mostrar(ContenerdorUno);
            Container.Mostrar(ContenerdorDos);
            listaProducto = ContenerdorDos - eTipoComestible.Liquido;
            Console.WriteLine(" Lista Extraida ");
            foreach (Producto item in listaProducto)
            {
                item.mostrar();
            }
            Console.ReadLine();
        }
    }
}
