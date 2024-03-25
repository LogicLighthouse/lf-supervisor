namespace SMNS.Services
{
    public interface ISupervisorService
    {
        Task<IEnumerable<string>> GetSupervisorsAsync();
    }
}
