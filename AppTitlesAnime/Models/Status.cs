using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class Status
{
    public short Id { get; set; }

    public string StatusName { get; set; } = null!;

    //навигационные свойства
    //Использование ICollection<TitlesStatus> позволяет работать с множеством связанных объектов, таких как добавление, удаление и перечисление статусов
    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}
