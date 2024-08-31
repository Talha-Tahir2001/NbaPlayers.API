using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NbaPlayers.API.Data;

namespace NbaPlayers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NbaPlayerController : ControllerBase
    {
        private readonly DataContext _context;

        public NbaPlayerController(DataContext context)
        {
            _context = context;
        }


        // CRUD OPERATIONS - CREATE, READ, UPDATE, DELETE
        // HTTP METHODS    - POST,   GET,  PUT,    DELETE

        [HttpPost]  // CREATE
        public async Task<ActionResult<List<NbaPlayer>>> CreateNbaPlayer(NbaPlayer player)
        {
            _context.NbaPlayers.Add(player);
            await _context.SaveChangesAsync();

            return Ok(await _context.NbaPlayers.ToListAsync());
        }

        [HttpGet]  // READ
        public async Task<ActionResult<List<NbaPlayer>>> GetNbaPlayers()
        {
            return Ok(await _context.NbaPlayers.ToListAsync());
        }


        [HttpPut]  // UPDATE
        public async Task<ActionResult<List<NbaPlayer>>> UpdateNbaPlayer(NbaPlayer player)
        {
            var dbPlayer = await _context.NbaPlayers.FindAsync(player.Id);
            if (dbPlayer == null) 
                return BadRequest("Player Not Found");
            
            dbPlayer.NickName = player.NickName;
            dbPlayer.FirstName = player.FirstName;
            dbPlayer.LastName = player.LastName;
            dbPlayer.Team = player.Team;

            await _context.SaveChangesAsync();

            return Ok(await _context.NbaPlayers.ToListAsync());
        }

        [HttpDelete(template: "{id}")]
        public async Task<ActionResult<List<NbaPlayer>>> DeleteNbaPlayer(NbaPlayer player)
        {
            var dbPlayer = await _context.NbaPlayers.FindAsync(player.Id);
            if (dbPlayer == null)
                return BadRequest("Player Not Found");

            _context.NbaPlayers.Remove(player);
            await _context.SaveChangesAsync();

            return Ok(await _context.NbaPlayers.ToListAsync());
        }

    }
}
