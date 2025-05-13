using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class AnimeTitle
{
    public int Id { get; set; }
    
    public short IdType { get; set; }

    public string OriginalName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short CountSeries { get; set; }

    public short Duration { get; set; }

    public string Studio { get; set; } = null!;

    public string? Poster { get; set; }

    public string? Description { get; set; }


    //навигационные свойства
    public virtual Type Type { get; set; } = null!;
    //у одного аниме может быть один тип

    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();
    //у одного аниме может быть несколько жанров

    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
    //у одного аниме может быть несколько статусов
}
