namespace Railyatri.Repository
{
    public interface ITrainRepository
    {
        Trainslist AddMember(Trainslist details);
        Task<IList<Trainslist>> GetAllTrainslist(Trainslist list);
    }
}
