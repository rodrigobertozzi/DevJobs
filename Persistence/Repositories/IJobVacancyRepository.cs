using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevJobs.API.Entities;

namespace DevJobs.API.Persistence.Repositories
{
    public interface IJobVacancyRepository
    {
        List<JobVacancy> GetaAll();
        JobVacancy GetById(int id);
        void Add(JobVacancy jobVacancy);
        void Update(JobVacancy jobVacancy);
        void AddApplication(JobApplication jobApplication);
    }
}