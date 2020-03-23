using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomerInfoChartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerInfoChartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerInfoCharts
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomerInfoCharts.ToListAsync());
        }

        // GET: CustomerInfoCharts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerInfoChart = await _context.CustomerInfoCharts
                .FirstOrDefaultAsync(m => m.CustomerInfoChartId == id);
            if (customerInfoChart == null)
            {
                return NotFound();
            }

            return View(customerInfoChart);
        }

        // GET: CustomerInfoCharts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerInfoCharts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerInfoChartId,CustomerDayOfWeek,PickUpConfirm,CustomerPickUpCharge")] CustomerInfoChart customerInfoChart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerInfoChart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerInfoChart);
        }

        // GET: CustomerInfoCharts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerInfoChart = await _context.CustomerInfoCharts.FindAsync(id);
            if (customerInfoChart == null)
            {
                return NotFound();
            }
            return View(customerInfoChart);
        }

        // POST: CustomerInfoCharts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerInfoChartId,CustomerDayOfWeek,PickUpConfirm,CustomerPickUpCharge")] CustomerInfoChart customerInfoChart)
        {
            if (id != customerInfoChart.CustomerInfoChartId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerInfoChart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerInfoChartExists(customerInfoChart.CustomerInfoChartId))
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
            return View(customerInfoChart);
        }

        // GET: CustomerInfoCharts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerInfoChart = await _context.CustomerInfoCharts
                .FirstOrDefaultAsync(m => m.CustomerInfoChartId == id);
            if (customerInfoChart == null)
            {
                return NotFound();
            }

            return View(customerInfoChart);
        }

        // POST: CustomerInfoCharts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerInfoChart = await _context.CustomerInfoCharts.FindAsync(id);
            _context.CustomerInfoCharts.Remove(customerInfoChart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerInfoChartExists(int id)
        {
            return _context.CustomerInfoCharts.Any(e => e.CustomerInfoChartId == id);
        }
    }
}
