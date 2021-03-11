using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        //private readonly ICategoryRepository _categoryRepository;

        /*public IActionResult Index()
        {
            return View();
        }*/
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this._pieRepository = pieRepository;
            this._categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Cheese Cakes";
            return View(piesListViewModel);
        }
    }
}
