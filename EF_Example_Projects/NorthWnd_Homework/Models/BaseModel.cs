using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWnd_Homework.Models;
public class BaseModel
{
    public int Id { get; set; }
    public DateTime AddDate { get; set; }
    public bool IsActive { get; set; }
}
