using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneBookWebApi.Data.Interfaces;
using PhoneBookWebApi.Models;
using PhoneBookWebApi.Models.Repositories;

namespace PhoneBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookContactController : CoreController<PhoneBookContact, IPhoneBookRepository<PhoneBookContact>>
    {
        private IPhoneBookRepository<PhoneBookContact> repo;

        public PhoneBookContactController(IPhoneBookRepository<PhoneBookContact> repo) : base(repo)
        {

        }

       

        //// GET: api/PhoneBookContact
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<PhoneBookContact>>> GetPhoneBookContacts()
        //{
        //    return await _context.PhoneBookContacts.ToListAsync();
        //}

        //// GET: api/PhoneBookContact/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<PhoneBookContact>> GetPhoneBookContact(int id)
        //{
        //    var phoneBookContact = await _context.PhoneBookContacts.FindAsync(id);

        //    if (phoneBookContact == null)
        //    {
        //        return NotFound();
        //    }

        //    return phoneBookContact;
        //}

        //// PUT: api/PhoneBookContact/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPhoneBookContact(int id, PhoneBookContact phoneBookContact)
        //{
        //    if (id != phoneBookContact.ContactID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(phoneBookContact).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PhoneBookContactExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/PhoneBookContact
        //[HttpPost]
        //public async Task<ActionResult<PhoneBookContact>> PostPhoneBookContact(PhoneBookContact phoneBookContact)
        //{
        //    _context.PhoneBookContacts.Add(phoneBookContact);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPhoneBookContact", new { id = phoneBookContact.ContactID }, phoneBookContact);
        //}

        //// DELETE: api/PhoneBookContact/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<PhoneBookContact>> DeletePhoneBookContact(int id)
        //{
        //    var phoneBookContact = await _context.PhoneBookContacts.FindAsync(id);
        //    if (phoneBookContact == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.PhoneBookContacts.Remove(phoneBookContact);
        //    await _context.SaveChangesAsync();

        //    return phoneBookContact;
        //}

        //private bool PhoneBookContactExists(int id)
        //{
        //    return _context.PhoneBookContacts.Any(e => e.ContactID == id);
        //}
    }
}
