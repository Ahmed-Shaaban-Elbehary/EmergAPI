using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmergAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class eventsController : ApiController
    {
        _dbContext db = new _dbContext();
        public eventsController()
        {
            db = new _dbContext();
        }

        //GET:api/events
        public IEnumerable<Event> GetEvents()
        {
            return db.Events.ToList();
        }
        
        //GET:api/events/id
        public Event GetEvent(int id)
        {
            var events = db.Events.SingleOrDefault(e => e.Id == id);

            if (events == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return events;
        }
        
        //POST:api/events
        [HttpPost]
        public Event CreateEvent(Event events)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            db.Events.Add(events);
            db.SaveChanges();
            return events;
        }
        
        //PUT:api/events/id
        [HttpPut]
        public void EditEvent(int id, Event @event)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var eventInDb = db.Events.SingleOrDefault(e => e.Id == id);

            if (eventInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            //eventInDb.Time = @event.Time;
            eventInDb.Longitude = @event.Longitude;
            eventInDb.Latitude = @event.Latitude;

            db.SaveChanges();
        }

        //DELETE:api/events/id
        [HttpDelete]
        public void DeleteEvent(int id)
        {
            var events = db.Events.SingleOrDefault(e => e.Id == id);

            if (events == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            db.Events.Remove(events);
            db.SaveChanges();

        }
    }
}
