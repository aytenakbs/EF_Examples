using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Service.Models.ORM;
public class ServiceStatus:BaseModel
{
    public string StatusName { get; set; }
    public string Description { get; set; }
}
