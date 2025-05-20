using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;
// это директива, которая определяет пространство имен для классов и других типов, находящихся в данном файле

public partial class AnimeTitle
{
    // Уникальный идентификатор аниме
    //Метод get используется для получения значения свойства
    //Метод set используется для установки значения свойства
    public int Id { get; set; }

    // Идентификатор типа аниме
    public short IdType { get; set; }

    // Оригинальное название аниме (не может быть null)
    public string OriginalName { get; set; } = null!;

    // Название аниме (не может быть null)
    public string Name { get; set; } = null!;

    // Количество серий
    public short CountSeries { get; set; }

    // Продолжительность (например, в минутах)
    public short Duration { get; set; }

    // Студия, выпустившая аниме (не может быть null)
    public string Studio { get; set; } = null!;

    // Ссылка на постер аниме (может быть null)
    public string? Poster { get; set; }

    // Описание аниме (может быть null)
    public string? Description { get; set; }


    // Навигационные свойства

    // Тип аниме (у одного аниме может быть один тип)
    public virtual Type Type { get; set; } = null!;

    // Жанры аниме (у одного аниме может быть несколько жанров)
    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();

    // Статусы аниме (у одного аниме может быть несколько статусов)
    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}

