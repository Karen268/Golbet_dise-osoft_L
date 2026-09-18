
﻿// GolBet.Web/Controllers/MatchesController.cs 
using GolBet.Services.Interfaces;
using Golbet.Entities.Enums;
using Microsoft.AspNetCore.Mvc;

namespace GolBet.Web.Controllers;

public class MatchesController : Controller
{
    private readonly IMatchService _matchService;

    public MatchesController(IMatchService matchService)
        => _matchService = matchService;


    // GET /Matches?status=Scheduled -> filtered board
    public async Task<IActionResult> Index(MatchStatus? status)
    {
        ViewBag.CurrentStatus = status;
        var board = await _matchService.GetBoardAsync(status);
        return View(board);
    }

    // GET /Matches/Detail/3
    public async Task<IActionResult> Detail(int id)
    {
        var match = await _matchService.GetDetailAsync(id);
        if (match is null) return NotFound();   // HTTP 404

        return View(match);
    }

    // GET /Matches
    public async Task<IActionResult> Index()
    {
        var board = await _matchService.GetBoardAsync();
        return View(board);
    }
}


