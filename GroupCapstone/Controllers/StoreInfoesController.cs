﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroupCapstone.Data;
using GroupCapstone.Models;

namespace GroupCapstone.Controllers
{
    public class StoreInfoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StoreInfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StoreInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.StoreInfo.ToListAsync());
        }

        // GET: StoreInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeInfo = await _context.StoreInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (storeInfo == null)
            {
                return NotFound();
            }

            return View(storeInfo);
        }

        // GET: StoreInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StoreInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StreetAddress,AddressCity,AddressState,AddressZip,StoreHours,PhoneNumber,Logo,CompanyVision,Email,Latitude,Longitude")] StoreInfo storeInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storeInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(storeInfo);
        }

        // GET: StoreInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeInfo = await _context.StoreInfo.FindAsync(id);
            if (storeInfo == null)
            {
                return NotFound();
            }
            return View(storeInfo);
        }

        // POST: StoreInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StreetAddress,AddressCity,AddressState,AddressZip,StoreHours,PhoneNumber,Logo,CompanyVision,Email,Latitude,Longitude")] StoreInfo storeInfo)
        {
            if (id != storeInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storeInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoreInfoExists(storeInfo.Id))
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
            return View(storeInfo);
        }

        // GET: StoreInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeInfo = await _context.StoreInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (storeInfo == null)
            {
                return NotFound();
            }

            return View(storeInfo);
        }

        // POST: StoreInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var storeInfo = await _context.StoreInfo.FindAsync(id);
            _context.StoreInfo.Remove(storeInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoreInfoExists(int id)
        {
            return _context.StoreInfo.Any(e => e.Id == id);
        }
    }
}
