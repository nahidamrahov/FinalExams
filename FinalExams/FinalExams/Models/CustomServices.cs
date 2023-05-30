using FinalExams.Models.Base;
using Microsoft.AspNetCore.Mvc;

namespace FinalExams.Models
{
    [Area("FinalAdmin")]
    public class CustomServices : BaseEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

    }
}
