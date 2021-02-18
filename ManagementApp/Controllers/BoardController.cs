using ManagementApp.Interface;
using ManagementApp.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Controllers
{
    public class BoardController : BaseController
    {
        public readonly IBoardRepository<Board> BoardRepo;
        public BoardController(IBoardRepository<Board> boardRepo)
        {
            BoardRepo = boardRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Board>>> getBoards()
        {
            var board = await BoardRepo.ListAllAsync();
            return Ok(board);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyList<Board>>> getBoards(int id)
        {
            var board = await BoardRepo.GetbyIdAsync(id);
            return Ok(board);
        }


    }
}
