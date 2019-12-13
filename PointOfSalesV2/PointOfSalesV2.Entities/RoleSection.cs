using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace PointOfSalesV2.Entities
{
    public class RoleSection : CommonData
    {
        public long RoleId { get; set; }
        public string JsonData { get; set; } = "[]";

        public List<RoleSectionData> Permissions
        {
            get

            {
                return JsonConvert.DeserializeObject<List<RoleSectionData>>(this.JsonData);
            }
        }

    }
}
