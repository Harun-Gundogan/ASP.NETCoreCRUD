using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Video_icerik.Data;
using Video_icerik.Models;

namespace Video_icerik.Controllers
{
    public class IceriksController : Controller
    {
        private readonly VideoicerikContext _context;

        public IceriksController(VideoicerikContext context)
        {
            _context = context;
        }

        // GET: Iceriks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Icerik.ToListAsync());
        }

        // GET: Iceriks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik
                .FirstOrDefaultAsync(m => m.IcerikId == id);
            if (icerik == null)
            {
                return NotFound();
            }

            return View(icerik);
        }

        // GET: Iceriks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Iceriks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IcerikId,YouTubeVideoId,Baslik,UretimTarihi,EgitmeninNotlari,KullanilanTeknolojiler,Kategori")] Icerik icerik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(icerik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(icerik);
        }

        // GET: Iceriks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik.FindAsync(id);
            if (icerik == null)
            {
                return NotFound();
            }
            return View(icerik);
        }

        // POST: Iceriks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IcerikId,YouTubeVideoId,Baslik,UretimTarihi,EgitmeninNotlari,KullanilanTeknolojiler,Kategori")] Icerik icerik)
        {
            if (id != icerik.IcerikId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(icerik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IcerikExists(icerik.IcerikId))
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
            return View(icerik);
        }

        // GET: Iceriks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik
                .FirstOrDefaultAsync(m => m.IcerikId == id);
            if (icerik == null)
            {
                return NotFound();
            }

            return View(icerik);
        }

        // POST: Iceriks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var icerik = await _context.Icerik.FindAsync(id);
            if (icerik != null)
            {
                _context.Icerik.Remove(icerik);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IcerikExists(int id)
        {
            return _context.Icerik.Any(e => e.IcerikId == id);
        }
    }
}
