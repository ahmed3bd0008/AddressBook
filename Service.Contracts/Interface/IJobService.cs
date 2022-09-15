using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IJobService
    {
        public IEnumerable<JobDto> GetJobs(bool EnableTracking);
        public IEnumerable<JobDto> GetJobsByName(string Name, bool EnableTracking);
        JobDto GetJobsById(int Id, bool EnableTracking);
        void Delete(int Id);
        int Update(JobDto Job);
        int Add(JobDto Job);
    }
}
