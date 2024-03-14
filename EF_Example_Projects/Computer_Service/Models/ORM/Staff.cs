﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Service.Models.ORM;
public class Staff:BaseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime HireDate { get; set; }
}
