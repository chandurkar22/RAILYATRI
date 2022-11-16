namespace Railyatri
{
    public class Trainslist
    {
        public int id { get; set; }
        public string Trainname { get; set; }
        public int TrainNumber { get; set; }
        public string FromStation { get; set; }
        public string ToStation { get; set; }
        public ICollection<TrainSchedule> TrainSchedules { get; set; }
        public ICollection<AvailabilitySchedule> AvailabilitySchedules { get; set; }

    }
}
