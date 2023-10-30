using System;
using System.ComponentModel.DataAnnotations;
using Validador.Attributes;

namespace Validador.Models
{
    public class Event
    {
        [FutureDate(ErrorMessage = "La fecha del evento no puede ser en el futuro.")]
        public DateTime EventDate { get; set; }
    }
}
