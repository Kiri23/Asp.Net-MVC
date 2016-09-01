using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1MVC.Models;

namespace Test1MVC.Controllers
{
    // esta clase derivada de Controller
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        // tiene un action(methods) que se llama Random-que creo que es el que esta abajo-El broweser busca este metodo. eso es como yo dijera get:Movies/Random con este ejmplo la internet vas a buscar un metodo(action) que se llama Random
        /** ActionResult is the base class for all Action
          las otras clase que tus derivas son subclase de ActionResult  **/
        public ActionResult Random()
        {
            /* * Este metodo de Return View le devuelve al servidor el archivo que le va a mostrar al usuario, so en view debe haber un archivo que se llama Random **/
            var movie = new Movie() { Name = "Godzilla", Id = 1 };
            /** Acontinuacion Distintas Formas de enviar un ActionResult View es un metodo inherido from la clase Controller- este metodo nos ayuda a crear un view Result(alternativo se puede crear return new ViewResult() **/

            // Devolver un ActionResult Differente return View(movie);

            //Esto solamente Devuelve Contennido(Text por ejemplo no rendered a View). return Content("Hello world From Content ");
            // Ta viene con un View Predeterminado para las paginas No encontradas. return HttpNotFound();

            //Para EmptyResult No hay un helper method se tiene que construir una instancia de EmptyResult. y Devuelve Nada una Pagina en Blanco. return new EmptyResult(); 

            //Primer Parametro es el Name of an Action and The Controller where is the action. Para pasar Informacion a el View se Ultiliza el Tercer Parametro con un anonymous Object e.g {} y esto se pone en la url y puedes coger de ahy .
            return RedirectToAction("Index","Home",new { page = 1 ,sortBy = "name" });

        }

       
 
    }

    /** La clase tienen que devolver un ActionResult but instead devuelve un viewResult pero lo que pasa que un action puede tener multiples return y por eso es que la clase no se puede especificar como un tipo de retun tiene que ser como que la root y todo lo que valla a darle Return tiene que ser un subType de ActionResult **/
}