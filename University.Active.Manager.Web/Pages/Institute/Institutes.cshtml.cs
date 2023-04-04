using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Contracts;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Web.Pages.Account
{
    public class InstitutesModel : PageModel
    {
        private readonly IInstituteRepository _instituteRepository;
        private readonly IMapper _mapper;

        public InstitutesModel(IInstituteRepository instituteRepository, IMapper mapper)
        {
            _instituteRepository = instituteRepository;
            _mapper = mapper;
        }

        public List<Institute> Institutes { get; set; }

        [BindProperty]
        public InstituteModel InstituteModel { get; set; }
        public async Task OnGetAsync()
        {
            Institutes = await _instituteRepository.GetAllInstitutes();
        }

        public async Task OnPostAsync()
        {
            var institute = _mapper.Map<Institute>(InstituteModel);
            await _instituteRepository.AddInstitute(institute);
        }

    }
}
