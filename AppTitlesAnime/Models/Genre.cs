using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class Genre
{
    // Уникальный идентификатор 
    public short Id { get; set; }

    // название  жанров аниме (не может быть null)
    public string GenreName { get; set; } = null!;


    //навигационные свойства
    //Использование ICollection<TitlesGenre> позволяет работать с множеством связанных объектов, таких как добавление, удаление и перечисление жанров
    //new List<TitlesGenre>() — это способ создания новой коллекции, которая может хранить объекты типа TitlesGenre
    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();
}
