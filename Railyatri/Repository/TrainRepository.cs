using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Railyatri.Repository
{
    public class TrainRepository:ITrainRepository
    {
        
        public Trainslist AddMember(Trainslist details)
        {
            var Data = new Traindb();

            var List = new Trainslist()
            {
                Trainname = details.Trainname,
                FromStation = details.FromStation,
                ToStation = details.ToStation,

            };

            Data.Trainslist.Add(List);

            Data.SaveChanges();

            return List;

        }
        public async Task<IList<Trainslist>> GetAllTrainslist(Trainslist list)
        {

            IList<Trainslist> Traislist = null;

            using (var Data = new Traindb())
            {
                Traislist = await Data.Trainslist.Where(s => s.FromStation == list.FromStation && s. ToStation == list.ToStation)
                                                    .Include(s => s.TrainSchedules)
                                                    .Include(s => s.AvailabilitySchedules)
                                                    .ToListAsync();
            }
            

            if (Traislist == null)
            {
                return null;
            }

            return Traislist;
        }
    }
}
