using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWnd_Homework.Models;
public class Category : BaseModel
{
    [MaxLength(15)]
    public string CategoryName { get; set; }
    public string? Description { get; set; }
    public string? PictureUrl { get; set; }
}
