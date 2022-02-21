using ArtAPI.Models;
using ArtAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArtAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class ArtistsController : ControllerBase
  {
    private readonly ArtistsService _as;
    public ArtistsController(ArtistsService artServ)
    {
      _as = artServ;
    }

    [HttpGet]
    public ActionResult<List<Artist>> GetAll()
    {
      try
      {
        return Ok(_as.GetAll());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{artistId}")]
    public ActionResult<Artist> GetById(string artistId)
    {
      try
      {
        Artist foundArtist = _as.GetById(artistId);
        return Ok(foundArtist);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Artist> Create([FromBody] Artist newArtist)
    {
      try
      {
        return Ok(_as.Create(newArtist));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{artistId}")]
    public ActionResult<Artist> Delete(string artistId)
    {
      try
      {
        return Ok(_as.Delete(artistId));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{artistId}")]
    public ActionResult<Artist> Edit([FromBody] Artist editedArtist, string artistId)
    {
      try
      {
        editedArtist.Id = artistId;
        Artist updatedArtist = _cs.Edit(editedArtist);
        return Ok(updatedArtist);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}