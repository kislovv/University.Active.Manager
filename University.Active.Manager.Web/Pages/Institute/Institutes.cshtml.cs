using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Contracts;

namespace University.Active.Manager.Web.Pages.Institute
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

        public List<Entity.Institute> Institutes { get; set; }

        [BindProperty]
        public InstituteModel InstituteModel { get; set; }
        public async Task OnGetAsync()
        {
            Institutes = await _instituteRepository.GetAllInstitutes();
        }

        public async Task OnPostAsync()
        {
            var institute = _mapper.Map<Entity.Institute>(InstituteModel);
            await _instituteRepository.AddInstitute(institute);
            
            Institutes = await _instituteRepository.GetAllInstitutes();
        }
        
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var institute = await _instituteRepository.GetInstituteById(id);
 
            if (institute != null)
            {
                await _instituteRepository.RemoveInstitute(institute);
            }
 
            return RedirectToPage();
        }

    }
}
