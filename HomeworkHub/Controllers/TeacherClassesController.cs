using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeworkHub.Data;
using HomeworkHub.Models;

namespace HomeworkHub.Controllers
{
    public class TeacherClassesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherClassesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TeacherClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeacherClasses.ToListAsync());
        }

        // GET: TeacherClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherClass = await _context.TeacherClasses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacherClass == null)
            {
                return NotFound();
            }

            return View(teacherClass);
        }

        // GET: TeacherClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeacherClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeacherId,ClassId")] TeacherClass teacherClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacherClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacherClass);
        }

        // GET: TeacherClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherClass = await _context.TeacherClasses.FindAsync(id);
            if (teacherClass == null)
            {
                return NotFound();
            }
            return View(teacherClass);
        }

        // POST: TeacherClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeacherId,ClassId")] TeacherClass teacherClass)
        {
            if (id != teacherClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacherClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherClassExists(teacherClass.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(teacherClass);
        }

        // GET: TeacherClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherClass = await _context.TeacherClasses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacherClass == null)
            {
                return NotFound();
            }

            return View(teacherClass);
        }

        // POST: TeacherClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacherClass = await _context.TeacherClasses.FindAsync(id);
            if (teacherClass != null)
            {
                _context.TeacherClasses.Remove(teacherClass);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherClassExists(int id)
        {
            return _context.TeacherClasses.Any(e => e.Id == id);
        }
    }
}
