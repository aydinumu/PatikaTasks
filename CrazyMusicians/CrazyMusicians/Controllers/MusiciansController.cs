using CrazyMusicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MusiciansController : ControllerBase
	{
		private static List<Musician> _musicians = new List<Musician>
		{
			new Musician { Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", FunFact = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
			new Musician { Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", FunFact = "Şarkıları yanlış anlaşılır ama çok popüler" },
			new Musician { Id = 3, Name = "Cemil Akor", Profession = "Çılgın Akorist", FunFact = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
			new Musician { Id = 4, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", FunFact = "Nota üretirken sürekli sürprizler hazırlar" },
			new Musician { Id = 5, Name = "Hasan Ritim", Profession = "Ritim Canavarı", FunFact = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
			new Musician { Id = 6, Name = "Elif Armoni", Profession = "Armoni Ustası", FunFact = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
			new Musician { Id = 7, Name = "Ali Perde", Profession = "Perde Uygulayıcı", FunFact = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
			new Musician { Id = 8, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", FunFact = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
			new Musician { Id = 9, Name = "Murat Ton", Profession = "Tonlama Meraklısı", FunFact = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
			new Musician { Id = 10, Name = "Selin Akor", Profession = "Akor Sihirbazı", FunFact = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" }
		};

		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(_musicians);
		}

		[HttpGet("crazies/{id}")]
		public IActionResult Get(int id)
		{
			var musician = _musicians.FirstOrDefault(x => x.Id == id);
			if (musician is null) return NotFound("Musician not found.");

			return Ok(musician);
		}

		[HttpGet("search")]
		public ActionResult<IEnumerable<Musician>> SearchMusicians([FromQuery] string name)
		{
			var musician = _musicians.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
			if (musician.Count == 0)
			{
				return NotFound();
			}
			return Ok(musician);
		}

		[HttpPost]
		public IActionResult AddACrazy([FromBody] Musician request)
		{
			var id = _musicians.Max(x => x.Id) + 1;

			request.Id = id;
			_musicians.Add(request);

			return CreatedAtAction(nameof(Get), new { id = request.Id }, request);
		}

		[HttpPatch("funfact/{id}")]
		public IActionResult PatchFunFact(int id, [FromBody] string newFunFact)
		{
			var musician = _musicians.FirstOrDefault(x => x.Id == id);
			if (musician is null) return NotFound("Musician not found.");

			musician.FunFact = newFunFact;
			return Ok(musician);
		}

		[HttpPatch("profession/{id}")]
		public IActionResult PatchProfession(int id, [FromBody] string newProfession)
		{
			var musician = _musicians.FirstOrDefault(x => x.Id == id);
			if (musician is null) return NotFound("Musician not found.");

			musician.FunFact = newProfession;
			return Ok(musician);
		}

		[HttpPut]
		public IActionResult Put(int id, [FromBody] Musician request)
		{
			if (request is null || id != request.Id) return BadRequest();

			var musician = _musicians.FirstOrDefault(x => x.Id == id);
			if (musician is null) return NotFound();

			musician.Name = request.Name;
			musician.Profession = request.Profession;
			musician.FunFact = request.FunFact;

			return Ok(musician);
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			var musician = _musicians.FirstOrDefault(x => x.Id == id);
			if (musician is null) return NotFound();

			_musicians.Remove(musician);

			return NoContent();
		}
	}
}