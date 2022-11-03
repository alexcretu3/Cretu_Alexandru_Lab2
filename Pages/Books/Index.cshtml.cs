﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cretu_Alexandru_Lab2.Data;
using Cretu_Alexandru_Lab2.Models;

namespace Cretu_Alexandru_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Cretu_Alexandru_Lab2.Data.Cretu_Alexandru_Lab2Context _context;

        public IndexModel(Cretu_Alexandru_Lab2.Data.Cretu_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .ToListAsync();
            }
        }
    }
}
