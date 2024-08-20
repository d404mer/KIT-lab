using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HorseClub.Models;

public partial class EVENTPLUSUSER
{
    [Key] public int LIST_ID { get; set; }

    [Column("CURR_USER_ID")]
    public int? CURR_USER_ID { get; set; }

    [Column("CURR_EVENT_ID")]
    public int? CURR_EVENT_ID { get; set; }
}
