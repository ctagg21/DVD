using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using DvdLibraryMilestone5.Models;

namespace DvdLibraryMilestone5.Data.Repositories
{
    public class DvdRepositoryEF : IDvdRepository
    {
        private DvdEntities _ctx;

        public DvdRepositoryEF()
        {
            this._ctx = new DvdEntities();
        }
        public void CreateDvd(Dvd dvd)
        {
            _ctx.Dvds.Add(dvd);
            _ctx.SaveChanges();
        }

        public IEnumerable<Dvd> GetAll()
        {
            return _ctx.Dvds;
        }

        public Dvd GetById(int id)
        {
            return _ctx.Dvds.Find(id);
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

        public IEnumerable<Dvd> GetByReleaseYear(string releaseYear)
        {
            throw new NotImplementedException();
        }

        public void Update(Dvd dvd)
        {
            _ctx.Entry(dvd).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            _ctx.Dvds.Remove(GetById(id));
        }
    }
}