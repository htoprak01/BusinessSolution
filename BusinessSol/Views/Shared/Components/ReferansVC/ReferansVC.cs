using BusinessSol.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusinessSol.Views.Shared.Components.ReferansVC
{
    public class ReferansVC:ViewComponent
    {
        private readonly OptimalDbContext _context;

        public ReferansVC(OptimalDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model= _context.RefCategories.Include("Referanslar").ToList();
            //var model = _dbContext.Categories.ToList();
            return View("referensliste", model);

        }
    }
}
