using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using MvcDB.Web.Data;

namespace MvcDB.Web.Models
{
    public class Team
    {
        [Key]
        [MaxLength(30)]
        [Display(Name = "Team")]
        [Required(ErrorMessage = "{0} is mandatory")]
        public string? TeamName { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public string? City { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public string? Province { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [MinLength(2)]
        [MaxLength(30)]
        public string? Country { get; set; }

        public List<Player>? Players { get; set; }

        public static async Task<List<Team>> GetTeams(ApplicationDbContext context)
        {
            return await context.Teams
                .Include(t => t.Players)
                .ToListAsync();
        }
    }
}
