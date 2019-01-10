using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Data.Common;
using SchoolApp.Data.Models;
using SchoolApp.Services.Mapping;
using SchoolApp.Services.Models.Council;

namespace SchoolApp.Services.DataServices.Council
{
    public class CouncilService : ICouncilService
    {
        private readonly IRepository<Person> councilRepository;

        public CouncilService(IRepository<Person> councilRepository)
        {
            this.councilRepository = councilRepository;
        }

        public async Task<List<CouncilDetailsViewModel>> GetCouncilAsync()
        {
            var people = 
                await this.councilRepository.All()
                .Where(x => x.Role == Role.Director || x.Role == Role.DeputyDirector)
                .To<CouncilDetailsViewModel>()
                .ToListAsync();
            //Direktor ili zam. direktor

            return people;
        }
    }
}
