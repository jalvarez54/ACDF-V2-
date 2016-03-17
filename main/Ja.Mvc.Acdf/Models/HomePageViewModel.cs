﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ja.Mvc.Acdf.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<PhotoViewModel> Photos { get; set; }
        public IEnumerable<PhotoViewModel> PhotosMonth { get; set; }
        public IEnumerable<PhotoViewModel> LastFivePhotos { get; set; }
        public IEnumerable<AcdfGuessBook> GuessBooks { get; set; }
        public IEnumerable<AcdfGuessBook> GuessBooksMonth { get; set; }
        public IEnumerable<AcdfGuessBook> LastFiveGuessBooks { get; set; }
        public IEnumerable<AspNetUser> AspNetUsers { get; set; }
        public IEnumerable<AspNetUser> AspNetUsersMonth { get; set; }
        public IEnumerable<AspNetUser> LastFiveAspNetUsers { get; set; }
        public IDictionary<AspNetUser, int> BirthDaysMonth { get; set; }
        public HomePageViewModel(
            IEnumerable<PhotoViewModel> photos,
            IEnumerable<AcdfGuessBook> guessBooks,
            IEnumerable<AspNetUser> aspnetUsers)
        {
            Photos = photos;
            PhotosMonth = photos.Where(m => m.Date.Value.Month == DateTime.Now.Month & m.Date.Value.Year == DateTime.Now.Year);
            LastFivePhotos = photos.Take(5);

            GuessBooks = guessBooks;
            GuessBooksMonth = guessBooks.Where(m => m.Date.Value.Month == DateTime.Now.Month & m.Date.Value.Year == DateTime.Now.Year);
            LastFiveGuessBooks = guessBooks.Take(5);

            AspNetUsers = aspnetUsers;
            AspNetUsersMonth = aspnetUsers.Where(m => m.RegistrationDate.Value.Month == DateTime.Now.Month & m.RegistrationDate.Value.Year == DateTime.Now.Year);
            LastFiveAspNetUsers = aspnetUsers.Take(5);

            //var birthdaysMonth = aspnetUsers.Where(m => m.BirthDate.Value.Day <= DateTime.Now.Day && m.BirthDate.Value.Month == DateTime.Now.Month);
            BirthDaysMonth = new Dictionary<AspNetUser, int>();
            //if (BirthDaysMonth.Count != 0)
            //{
            //    foreach (var b in birthdaysMonth)
            //    {
            //        BirthDaysMonth.Add(b, DateTime.Now.Year - b.BirthDate.Value.Year);
            //    }
            //}
            foreach (var m in aspnetUsers)
            {
                if (m.BirthDate.HasValue)
                {
                    if (m.BirthDate.Value.Day <= DateTime.Now.Day & m.BirthDate.Value.Month == DateTime.Now.Month)
                    {
                        BirthDaysMonth.Add(m, DateTime.Now.Year - m.BirthDate.Value.Year);
                    }
                }
            }
        }
    }

}
