using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCEC.Data.Models.DB
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UniversityId { get; set; }
        public string Place { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime OrganizedDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string? Description { get; set; }
        public int? ClubId { get; set; }
        public int? DepartmentId { get; set; }
        public string Qr { get; set; }
        public int Status { get; set; }

    }
}
