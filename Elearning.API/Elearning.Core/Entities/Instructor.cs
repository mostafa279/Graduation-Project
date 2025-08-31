using Elearning.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Core.Entities
{
    public class Instructor : ApplicationUser
    {
        public int years_experience {  get; set; }
        public string education_background {  get; set; } =string.Empty;
        public string certifications { get; set; } = string.Empty;
        public decimal average_rating { get; set; }
        public string ImgURL { get; set; } = string.Empty;
        public bool is_available { get; set; }
        public int total_reviews {  get; set; }

    }
}
