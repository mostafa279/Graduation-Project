using Elearning.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Core.Entities
{
    public class Student : ApplicationUser
    {
        public int Grade_level { get; set; }
        public DateOnly Date_of_birth { get; set; }
        public string ImgURL { get; set; }=string.Empty;


    }
}
