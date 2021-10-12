using Domain.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Recuest : EntityB
    {
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(10)]
        public string IdentityNumber { get; set; }
        [Range(0, 99, ErrorMessage = "Please enter valid age.")]
        public int Age { get; set; }        
        public string House { get; set; }
    }
}
