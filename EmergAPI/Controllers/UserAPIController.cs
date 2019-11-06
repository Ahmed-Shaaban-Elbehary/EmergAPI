﻿using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmergAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserAPIController : ApiController
    {
        _dbContext db = new _dbContext();
        public UserAPIController()
        {
            db = new _dbContext();
        }

        //GET:api/users
        public IEnumerable<User> GetUsers()
        {
            //var users = db.Users.Include(u => u.BloodType).Include(u => u.Diseases).ToList();
            return db.Users.ToList();

        }
        //GET:api/users/id
        public User GetUsers(int id)
        {
            var users = db.Users.SingleOrDefault(e => e.Id == id);

            if (users == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

                return users;
        }


        //POST:api/users/CreateUser

        [HttpPost]
        public User CreateUser(User user)
        {

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);


            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }


        //PUT:api/users/id
        [HttpPut]
        public void EditUser(int id, User user)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var userInDb = db.Users.SingleOrDefault(e => e.Id == id);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            userInDb.Name = user.Name;
            userInDb.Email = user.Email;
            userInDb.Password = user.Password;
            userInDb.ConfirmPassword = user.ConfirmPassword;
            userInDb.Birthdate = user.Birthdate;
            userInDb.mobileNo = user.mobileNo;
            userInDb.UpImage = user.UpImage;
            userInDb.Height = user.Height;
            userInDb.Weight = user.Weight;
            //userInDb.BloodType = user.BloodType;
            userInDb.Gender = user.Gender;
            //userInDb.bloodType_Id = user.bloodType_Id;
            //userInDb.Diseases = user.Diseases;

            db.SaveChanges();


        }

        //DELETE:api/users/id
        [HttpDelete]
        public void DeleteUser(int id)
        {
            var users = db.Users.SingleOrDefault(e => e.Id == id);

            if (users == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

                db.Users.Remove(users);
                db.SaveChanges();
            
        }

    }
}
