using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkProjesi_1.Models
{
    public class WebItem : BaseModel
    {
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }

        public int? UpperId { get; set; }
    }
}