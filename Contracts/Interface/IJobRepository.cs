using Entities.Modal;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
   public interface IJobRepository
    {
        IEnumerable<JobDto> GetJobAll(bool EnableTrackingChange);
        IEnumerable<JobDto> GetJobByName(string Name, bool EnableTrackingChange);
        Job GetJobtById(int Id, bool EnableTrackingChange);
        void CreateJob(Job JobtDto);
        void DeleteJob(Job JobtDto);
        void UpdateJob(Job JobtDto);
    }
}
