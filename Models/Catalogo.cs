using System.ComponentModel.DataAnnotations;

namespace netTest.Models
{
    public class Catalogo
    {
        [Key] //llave primaria
        //campos de la base de datos
        public int IdCatalogo { get; set; }

        public string Descripcion { get; set; }	
    }
}