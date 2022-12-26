﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cretu_Alexandru_Lab2.Data;
using Cretu_Alexandru_Lab2.Models;

namespace Cretu_Alexandru_Lab2.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly Cretu_Alexandru_Lab2.Data.Cretu_Alexandru_Lab2Context _context;

        public DetailsModel(Cretu_Alexandru_Lab2.Data.Cretu_Alexandru_Lab2Context context)
        {
            _context = context;
        }

      public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);
            if (member == null)
            {
                return NotFound();
            }
            else 
            {
                Member = member;
            }
            return Page();
        }
    }
}
