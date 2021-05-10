using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioWebApi.MVC.Models
{
    public class PokemonList
    {
        [JsonProperty("results")]
        public Pokemon[] Pokemons { get; set; }
    }


    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]

        public string Url { get; set; }

    }

    public class PokemonInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("height")]
        public float Height { get; set; }

        [JsonProperty("weight")]
        public float Weight { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sprites")]
        public Sprite Sprite { get; set; }
    } 

    public class Sprite
    {
        public string front_default { get; set; }

    }


}