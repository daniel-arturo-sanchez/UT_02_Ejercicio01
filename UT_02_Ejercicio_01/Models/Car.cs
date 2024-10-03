using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace UT_02_Ejercicio_01.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20,ErrorMessage = "Este campo debe contener entre 3 y 20 caracteres.", MinimumLength = 3)]
        [DisplayName("Modelo")]
        public string Model { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Este campo debe contener entre 3 y 15 caracteres.", MinimumLength = 3)]
        [DisplayName("Marca")]
        public string Brand { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de lanzamiento")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(5000,30000,ErrorMessage = "El precio del coche debe estar comprendido entre 5000 y 30000")]
        [DisplayName("Precio")]
        public decimal Price { get; set; }
    }
}
