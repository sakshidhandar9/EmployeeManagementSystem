using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MontCrestEmployeeProject.Models;
using MontCrestEmployeeProject.Models.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MontCrestEmployeeProject.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EmployeeController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee, IFormFile ImageFile)
        {
                if (ImageFile != null && ImageFile.Length > 0)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                    string extension = Path.GetExtension(ImageFile.FileName);
                    fileName = fileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + extension;

                    string path = Path.Combine(wwwRootPath, "images", fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(stream);
                    }

                    employee.Photo = "/images/" + fileName;
                }

            if (ModelState.IsValid)
            {

                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Success");
            }
            return View(employee);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}

