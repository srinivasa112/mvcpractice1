using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfDBfirstApproachExample.Models
{
    public class Category
    {
        [Key]
    [Display(Name = "Category ID")]
    public long CategoryID { get; set; }

    [Display(Name = "Category Name")]
    public string CategoryName { get; set; }
}
}