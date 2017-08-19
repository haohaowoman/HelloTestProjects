using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer:
        DropCreateDatabaseAlways<MusicStoreDBContext>
    {
        #region Override

        protected override void Seed(MusicStoreDBContext context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album()
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 99.9m,
                Title = "Caravan",
                AlbumArtUrl = "~/App_Data/Find-Previous.png"
                
            });
            context.Albums.Add(new Album()
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 99.9m,
                Title = "Raravan",
                AlbumArtUrl = "~/App_Data/Find-Previous.png"

            });
            context.Albums.Add(new Album()
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 99.9m,
                Title = "Naravan",
                AlbumArtUrl = "~/App_Data/Find-Previous.png"

            });
            base.Seed(context);
        }

        #endregion
    }
}