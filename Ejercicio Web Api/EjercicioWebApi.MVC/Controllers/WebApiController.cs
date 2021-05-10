using EjercicioWebApi.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EjercicioWebApi.MVC.Controllers
{
    public class WebApiController : Controller
    {
        public async Task<ActionResult> Index()
        {

            try
            {

                var client = new HttpClient();
                var json = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/?limit=50");
                var pokemonList = JsonConvert.DeserializeObject<PokemonList>(json);
                var list = new List<Pokemon>(pokemonList.Pokemons);
                
                return View(list);
            }
            
            catch (Exception ex)
            {
                return RedirectToAction("WebApi","Error");
            }
        }

      
        public async Task<ActionResult> GetInfo(string url)
        {
            try
            {
                var client = new HttpClient();
                var json = await client.GetStringAsync(url);
                var pokemonInfo = JsonConvert.DeserializeObject<PokemonInfo>(json);

                return View(pokemonInfo);
            }

                catch (Exception ex)
            {
                return RedirectToAction("WebApi", "Error");
            }
        }
      
    }
}