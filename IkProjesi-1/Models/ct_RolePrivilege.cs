using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkProjesi_1.Models
{
    public class ct_RolePrivilege : BaseModel
    {
        public int RoleId { get; set; }
        public int WebItemId { get; set; }
    }
}