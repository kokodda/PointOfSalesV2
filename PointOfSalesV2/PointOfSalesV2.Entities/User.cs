using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class User : CommonData
    {
        [NotMapped]
        public override long Id { get => base.Id; set => base.Id = value; }
        [Key]
        public Guid UserId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Key]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Password { get; set; }

        [NotMapped]
        public string TokenKey { get; set; }
    }
}
