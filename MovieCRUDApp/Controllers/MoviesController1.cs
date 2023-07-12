using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCRUDApp.Models;
using MovieCRUDApp.ViewModels;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCRUDApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IToastNotification _toastNotification;
        private List<string> _AllowedExtentions = new List<string> { ".jpg", ".png" };
        private long _MaxPosterSize = 1048576;

        public MoviesController(ApplicationDBContext applicationDBContext, IToastNotification toastNotification)
        {
            _context = applicationDBContext;
            _toastNotification = toastNotification;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _context.movies.OrderByDescending(m=>m.Rate).ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> Create()
        {
            var ViewModel = new MovieFromViewModel
            {
                genres = await _context.genres.OrderBy(m=>m.Name).ToListAsync(),
            };

            return View("MovieForm", ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieFromViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.genres = await _context.genres.OrderBy(m => m.Name).ToListAsync();
                return View(model);
            }
            var files = Request.Form.Files;
            if (!files.Any())
            {
                model.genres = await _context.genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Please Select Poster...!");
                return View(model);
            }
            var poster = files.FirstOrDefault();
            if (!_AllowedExtentions.Contains(Path.GetExtension(poster.FileName).ToLower()))
            {
                model.genres = await _context.genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Only .JPG and .PNG are Allowed......!");
                return View(model);
            }

            if (poster.Length > _MaxPosterSize)
            {
                model.genres = await _context.genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Poster Cann`t be more than 1 MB ......!");
                return View(model);
            }

            using var datastream = new MemoryStream();
            await poster.CopyToAsync(datastream);

            var moive = new Movie
            {
                Title = model.Title,
                GenreId = model.GenreId,
                Rate = model.Rate,
                Storyline = model.Storyline,
                Year = model.Year,
                Poster = datastream.ToArray(),
            };
            _context.movies.Add(moive);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Movie Created Successfully");
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();

            var movie = await _context.movies.FindAsync(id);
            if (movie == null) return NotFound();

            var ViewModel = new MovieFromViewModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Poster = movie.Poster,
                Rate = movie.Rate,
                Storyline = movie.Storyline,
                Year = movie.Year,
                GenreId = movie.GenreId,
                genres = await _context.genres.OrderBy(m => m.Name).ToListAsync(),
            };

            return View("MovieForm", ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MovieFromViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.genres = await _context.genres.OrderBy(m => m.Name).ToListAsync();
                return View(model);
            }

            var movie = await _context.movies.FindAsync(model.Id);
            if (movie == null) return NotFound();

            var files = Request.Form.Files;
            if (files.Any())
            {
                var poster = files.FirstOrDefault();
                using var datastrem = new MemoryStream();
                await poster.CopyToAsync(datastrem);

                model.Poster = datastrem.ToArray();

                if (!_AllowedExtentions.Contains(Path.GetExtension(poster.FileName).ToLower()))
                {
                    model.genres = await _context.genres.OrderBy(m => m.Name).ToListAsync();
                    ModelState.AddModelError("Poster", "Only .JPG and .PNG are Allowed......!");
                    return View("MovieForm",model);
                }

                if (poster.Length > _MaxPosterSize)
                {
                    model.genres = await _context.genres.OrderBy(m => m.Name).ToListAsync();
                    ModelState.AddModelError("Poster", "Poster Cann`t be more than 1 MB ......!");
                    return View("MovieForm", model);

                }
                movie.Poster = model.Poster;
            }

            movie.Title = model.Title;
            movie.Rate=model.Rate;
            movie.Storyline = model.Storyline;
            movie.Year = model.Year;
            movie.GenreId = model.GenreId;

            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Movie Updated Successfully");
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null) return BadRequest();
            var movie = await _context.movies.Include(m=>m.Genre).SingleOrDefaultAsync(m=> m.Id == Id);
            if (movie == null) return NotFound();

            return View(movie);
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return BadRequest();
            var movie = await _context.movies.SingleOrDefaultAsync(m => m.Id == Id);
            if (movie == null) return NotFound();
            _context.movies.Remove(movie);
            _context.SaveChanges();

            return Ok();
        }

    }
}
