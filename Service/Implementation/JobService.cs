using AutoMapper;
using Contracts;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class JobService: IJobService
    {

        public JobService(IRepositoryManger repositoryManger, IMapper mapper)
        {

        }

        public int Add(JobDto Job)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobDto> GetJobs(bool EnableTracking)
        {
            throw new NotImplementedException();
        }

        public JobDto GetJobsById(int Id, bool EnableTracking)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobDto> GetJobsByName(string Name, bool EnableTracking)
        {
            throw new NotImplementedException();
        }

        public int Update(JobDto Job)
        {
            throw new NotImplementedException();
        }
    }
}
