using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1MVC.Models;
using Test1MVC.ViewModel;

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
            //Object Initialization Synatx 
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer { Name = "Customer 2"},
                new Customer { Name = "Customer 3"},
                new Customer { Name = "Customer 4"},
                new Customer { Name = "Customer 5"},
                new Customer { Name = "Customer 6"}


            };
            
            // La clase RandomMovieViewModel se incializa con un Objeto Movie y una Lista de Customer 
            var viewModel = new RandomMovieViewModel
            {
             //Movie es la propiedad entro de la clase RandommMovieViewModel y le asigno la variable movie
             Movie = movie,
             Customers = customers

              


            };
             
            // Instead of sending the movie we are going to send la clase que contiene los dos Objeto Movie Y Customers
            return View(viewModel);


            /** segunda Forma de Como Mostar un ViewData
            ViewData["Movie"] = movie;
            // segunda Forma es usando ViewBag.Movie = Movie
            return View(); **/


            /** Acontinuacion Distintas Formas de enviar un ActionResult View es un metodo inherido from la clase Controller- este metodo nos ayuda a crear un view Result(alternativo se puede crear return new ViewResult() **/

            // Devolver un ActionResult Differente return View(movie);

            //Esto solamente Devuelve Contennido(Text por ejemplo no rendered a View). return Content("Hello world From Content ");
            // Ta viene con un View Predeterminado para las paginas No encontradas. return HttpNotFound();

            //Para EmptyResult No hay un helper method se tiene que construir una instancia de EmptyResult. y Devuelve Nada una Pagina en Blanco. return new EmptyResult(); 

            //Primer Parametro es el Name of an Action and The Controller where is the action. Para pasar Informacion a el View se Ultiliza el Tercer Parametro con un anonymous Object e.g {} y esto se pone en la url y puedes coger de ahy . return RedirectToAction("Index","Home",new { page = 1 ,sortBy = "name" });

        }

        public ActionResult Edit(int id)
        {

            return Content("Id= " + id);
        }

        // Tambien se puede crear Actiones con Parametros Optionales, que no van a ser Necesario Ponerlos
        //This is Action is going tocall when we navigate to the Movie/
        //Para hacer un parametro Optional se pone un questionMark y eso significa que es de clase Nullable ya string de por ya es Nullable.
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //Inside the action we will see is this parameter has not set a value 
            if (!pageIndex.HasValue)
            {
                //if it has nno values we initializing to one
                pageIndex = 1;
            }
            // si la string es Nulla la inicializamos a name
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            // el string.Format es una forma de formatear los Strings.{numero=indica el parametro de la String que se va a Compartir}e.g{0}- convertir a String el primer parametro.
            return Content(string.Format("pageIndex={0} & sortBy={1}",pageIndex,sortBy));

        }

        //To apply Constraint se tiene que hacer despues de los :(dos puntos).Regex es como una funcion que se llama y entreParentisis se pasa la regex Expresion.//-> es para skip a character.Regex Expresion No son String.Range to set the Rnage of the number(Validar los numeros)
        [Route("movies/released/{year}/{month:regex(\\d{2)}:range(1,12)")]

        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }

    }

    








    /** La clase tienen que devolver un ActionResult but instead devuelve un viewResult pero lo que pasa que un action puede tener multiples return y por eso es que la clase no se puede especificar como un tipo de retun tiene que ser como que la root y todo lo que valla a darle Return tiene que ser un subType de ActionResult **/

    
}