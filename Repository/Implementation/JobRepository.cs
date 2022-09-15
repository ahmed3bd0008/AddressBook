using Contracts.Interface;
using Entities;
using Entities.Modal;
using Entities.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
  public  class JobRepository:BaseRepository<Job>,IJobRepository
    {
        private readonly RepoDbContext _context;


        public JobRepository(RepoDbContext repoDbContext) : base(repoDbContext)
        {
            _context = repoDbContext;
        }
        public void CreateJob(Job Job)
        {
            Create(Job);
        }

        public void DeleteJob(Job Job)
        {
            Delete(Job);
        }
        public Job GetJobtById(int Id, bool EnableTrackingChange)
        {
            return GetFilter(x => x.JobId == Id, EnableTrackingChange).FirstOrDefault();
        }

        public void UpdateJob(Job Job)
        {
            Update(Job);
        }

        IEnumerable<JobDto> IJobRepository.GetJobAll(bool EnableTrackingChange)
        {
            return GetAll(EnableTrackingChange).
                Select(x => new JobDto() { JobName = x.JobName, JobId = x.JobId }).
                ToList();
        }

        IEnumerable<JobDto> IJobRepository.GetJobByName(string Name, bool EnableTrackingChange)
        {
            return GetFilter(x => x.JobName.Contains(Name), EnableTrackingChange).
                Select(x => new JobDto() { JobName = x.JobName, JobId = x.JobId }).
                ToList();
        }
    }
}
