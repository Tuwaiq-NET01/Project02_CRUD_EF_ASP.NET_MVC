using System;
using System.Collections.Generic;

namespace animeik.Models
{
    public class User
    {
        public int id { get; set; }

        public string username { get; set; }
        // public List<Anime> Fav;

        // public User(int id, string user)
        // {
        //     this.id = id;
        //     this.username = user;
        //     // Fav = new List<Anime>();
        // }
        // public void addToFav(Anime anime)
        // {
        //     Fav.Add(anime);
        // }
        // public void removeFav(int animeid)
        // {
        //     Fav.Remove(Fav.Find(an => an.id == animeid));
        // }
    }
}