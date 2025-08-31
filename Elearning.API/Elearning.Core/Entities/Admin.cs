using Elearning.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Core.Entities
{
    public class Admin : ApplicationUser
    {
        public string permissions {  get; set; } = string.Empty;
        public string ImgURL { get; set; } = string.Empty;
        public DateTime last_login { get; set; } 

    }
}
