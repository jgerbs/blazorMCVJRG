using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using MvcDB.Web.Data;
namespace MvcDB.Web.Models;

public class Player {
    [Display (Name = "ID")]
    public int PlayerId { get; set; }

    [Display (Name = "Jersey")]
    public int JerseyNumber { get; set; }

    [Display (Name = "First Name")]
    public string? FirstName { get; set; }

    [Display (Name = "Last Name")]
    public string? LastName { get; set; }
    public string?  Position { get; set; }

    [Required]
    public string? TeamName { get; set; }

    [ForeignKey("TeamName")]
    public Team? Team { get; set; }

    public static async Task<List<Player>> GetPlayers(ApplicationDbContext context)
    {
        return await context.Players
            .Include(p => p.Team)  // Ensure that the Team data is included (if needed)
            .ToListAsync();
    }
}
