using CoachingBusiness.DataContext;
using CoachingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoachingBusiness.Controllers
{
    public class CoachingDbController
    {
        private CoachingDBContext _context;

        public CoachingDbController(CoachingDBContext context)
        {
            _context = context;
        }

        public void Add(TaskModel task)
        {
            //Need to figure out how to set the next Id

            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void Edit(TaskModel task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();

        }

        public void Delete(TaskModel task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    
    }
}
