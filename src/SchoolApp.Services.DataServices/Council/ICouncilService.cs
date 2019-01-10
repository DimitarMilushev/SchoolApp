using SchoolApp.Services.Models.Council;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolApp.Services.DataServices.Council
{
    public interface ICouncilService
    {
        Task<List<CouncilDetailsViewModel>> GetCouncilAsync();
    }
}
