using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _001_MyFirstWebAPI.Controllers
{
    public class MyFirstController : ApiController
    {
        /// <summary>
        /// Hier wird nach der Nameskonvetion gesucht. Wenn eine Methode mit dem Preffix Get anfängt, wird diese Methode auch als Get-Methode interpretiert. 
        /// </summary>
        /// <returns></returns>
        /// 



        //Wichtig! Wenn zwei Methoden als Get-Methoden gelten können, wird ein Fehler ausgegeben -> Alternativ kann man mit [NonAction] eine Methode mit dem Präffix Get deaktivieren. (siehe unten Beispiel)
        public string GetHelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// Wenn man eigene Methodennamen verwendet, kann man mit HTTP-Verbs die Methode flankieren.
        /// </summary>
        /// <returns></returns>

        //[HttpGet]
        //public string GebeMirHelloWorld()
        //{
        //    return "Hello World 2";
        //}

        /// <summary>
        /// Ausgelagerte Methoden die mit 'Get' - anfangen um irgendwelche Daten zu laden...ist erstmal schlechter Code. Wenn man das allerdings verwenden möchte, bitte das Verb- [NoAction] verwenden
        /// </summary>
        /// <returns></returns>
        [NonAction]
        public string GetPrivateDaten()
        {
            return "irgendwas";
        }
    }
}
