using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DvdLibraryMilestone5.Models;

namespace DvdLibraryMilestone5.Data.Repositories
{
    public class DvdRepositoryMock : IDvdRepository
    {
        private static List<Dvd> _dvds;

        static DvdRepositoryMock()
        {
            _dvds = new List<Dvd>()
            {
                new Dvd { DvdId= 1, RatingId= 2, Title= "Star Wars", Director= "Test Director", ReleaseYear = "2000"},
                new Dvd { DvdId = 2, RatingId = 3, Title="Terminator", Director = "Test 2", ReleaseYear = "1998"}
            };
        }

        public void CreateDvd(Dvd dvd)
        {
            if (_dvds.Any())
            {
                dvd.DvdId = _dvds.Max(d => d.DvdId) + 1;
            }
            else
            {
                dvd.DvdId = 0;
            }

            _dvds.Add(dvd);
        }

        public IEnumerable<Dvd> GetAll()
        {
            throw new NotImplementedException();
            //return _dvds;
        }

        public Dvd GetById(int id)
        {
            return _dvds.FirstOrDefault(d => d.DvdId == id);
        }

        public IEnumerable<Dvd> GetbyRating(int rating)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dvd> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dvd> GetByDirector(string director)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dvd> GetByReleaseYear(string year)
        {
            throw new NotImplementedException();
        }

        public void Update(Dvd dvd)
        {
            _dvds.RemoveAll(d => d.DvdId == dvd.DvdId);
            _dvds.Add(dvd);
        }

        public void Delete(int id)
        {
            _dvds.RemoveAll(d => d.DvdId == id);
        }
    }
}