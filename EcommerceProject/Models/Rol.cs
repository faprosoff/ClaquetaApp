using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.Models
{
    [Table("Roles")]
    public class Rol
    {
        public Rol()
        {
            this.Usuarios = new HashSet<Usuario>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public String Nombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}