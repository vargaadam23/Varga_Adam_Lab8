﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Varga_Adam_Lab8.Data;
using Varga_Adam_Lab8.Models;

namespace Varga_Adam_Lab8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Varga_Adam_Lab8.Data.Varga_Adam_Lab8Context _context;

        public DetailsModel(Varga_Adam_Lab8.Data.Varga_Adam_Lab8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
