using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _Compi1_P2_201612331
{
    /// <summary>
    /// Sistema de Comunicacion Chatbot, Integracion de Compilacion, y ejecucion de Codigo
    /// </summary>
    [WebService(Namespace = "http://chatbot.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {


        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public string Bienvenido(String nombre)
        {
            return "Bienvenido, " + nombre;
        }
        [WebMethod]
        public string Probar(String texto)
        {
            Gramatica grammar = new Gramatica();
            LanguageData lenguaje = new LanguageData(grammar);
            Parser p = new Parser(lenguaje);
            ParseTree arbol = p.Parse(texto);
            if (arbol != null)
            {
               if(arbol.ParserMessages.Count > 0)
                {
                    String Salida = "Compilacion Cancelada, Errores no permiten su Compilacion Correcta \n";
                    for(int a =0; a<arbol.ParserMessages.Count; a++)
                    {
                        Salida += "-[BLACKY RESPONSE]-> " + arbol.ParserMessages[a].Message + ", Linea: " + arbol.ParserMessages[a].Location.Line + " Columna: " + arbol.ParserMessages[a].Location.Column + "\n";
                    }
                    Salida += " Tiempo de Ejecucion: " + arbol.ParseTimeMilliseconds.ToString() + " millisegundos";
                    return Salida;

                }
                else
                {
                    String Salida = "Build Succes, Tiempo de Ejecucion: " + arbol.ParseTimeMilliseconds.ToString()+ " millisegundos";
                    return Salida;
                }
               
                
            }
            else
            {
                return "false";
            }
        }
    }
}
