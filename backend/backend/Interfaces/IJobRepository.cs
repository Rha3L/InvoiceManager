using backend.Entities;
using backend.Persistence.Dtos.Job;

namespace backend.Interfaces
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllAsync();
        Task<Job?> GetByIdAsync(int id);
        Task<Job> CreateAsync(Job jobEntity);
        Task<Job?> UpdateAsync(int id, JobUpdateDto jobDto);
        Task<Job?> DeleteAsync(int id);
    }
}
