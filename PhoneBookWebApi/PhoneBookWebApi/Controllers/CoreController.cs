using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneBookWebApi.Data.Interfaces;

namespace PhoneBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CoreController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IPhoneBookRepository<TEntity>
    {
        private readonly TRepository repository;

        public CoreController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Gets()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var contact = await repository.Get(id);
            if (contact == null)
            {
                return NotFound();
            }
            return contact;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity contact)
        {
            if (id != contact.ContactID)
            {
                return BadRequest();
            }
            await repository.Update(contact);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity contact)
        {
            await repository.Add(contact);
            return CreatedAtAction("Get", new { id = contact.ContactID }, contact);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var contact = await repository.Delete(id);
            if (contact == null)
            {
                return NotFound();
            }
            return contact;
        }
    }
}