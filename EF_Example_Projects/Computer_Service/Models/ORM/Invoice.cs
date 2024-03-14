using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Service.Models.ORM;
public class Invoice : BaseModel
{
    public DateTime CreationDate { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal TotalAmount { get; set; }
    public int ServiceRecordId { get; set; }
    public ServiceRecord ServiceRecords { get; set; }
}
