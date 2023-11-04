using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities.EnumType;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CleanArchitecture.Domain.Entities
{
    public class Flight : BaseEntity
    {
        public long AirPortId { get; set; }
        public string Aircraft { get; set; }

        public DateTime? DepartureTime { get; set; }
        public short DepartureHeading { get; set; }

        [NotMapped]
        public Point DepartureLocation { get; set; }
        public bool? DepartureInfoFound { get; set; }

        public LaunchMethods LaunchMethod { get; set; }
        public DateTime? LaunchFinished { get; set; }

        public DateTime? ArrivalTime { get; set; }
        public short ArrivalHeading { get; set; }

        [NotMapped]
        public Point ArrivalLocation { get; set; }

        public bool? ArrivalInfoFound { get; set; }

        public Airport Airport { get; set; }
        public bool Completed => (DepartureInfoFound != null || DepartureTime != null) && (ArrivalInfoFound != null || ArrivalTime != null);
    }
   
}

