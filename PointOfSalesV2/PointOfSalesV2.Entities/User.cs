using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class User : CommonData
    {
        [NotMapped]
        public override long Id { get => base.Id; set => base.Id = value; }
        [Key]
        public Guid UserId { get; set; }
       

        [NotMapped]
        public string TokenKey { get; set; }

        [MaxLength(30)]
        [DataMember]
        [Required]
        public string Name { get; set; }


        [MaxLength(30)]
        [DataMember]
        [Required]
        public string LastName { get; set; }

        [DataMember]
        public DateTime? BirthDay { get; set; }

        [DataMember]
        public short GenereId { get; set; }

        [DataMember]
        [MaxLength(15)]
        public string Phone { get; set; }

        [MaxLength(15)]
        [DataMember]
        public string Movil { get; set; }

        [MaxLength(200)]
        [DataMember]
        public string Address { get; set; }


        [MaxLength(30)]
        [DataMember]
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [DataMember]
        [Required]
        public string Password { get; set; }

        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        [DataMember]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public byte[] ImageData { get; set; }
        [MaxLength(15)]
        public string ContentType { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }

        public double? Size { get; set; }




        [NotMapped]
        public string FullName => Name + "  " + LastName;

        public virtual char Gender { get; set; }

       

      
    }
}
