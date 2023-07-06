using ipLogger.Database;
using ipLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipLogger.Services
{
    public class ipServices
    {
        public ip Getip()
        {
            using (var context = new ipLoggerContext())
            {
                var lastEntry = context.ips
                    .OrderByDescending(e => e.Id) // Replace with the appropriate timestamp column
                    .FirstOrDefault();
                    

                return lastEntry;
            }
        }

        public ip GetipById(int id)
        {
            using (var context = new ipLoggerContext())
            {
                return context.ips.Find(id);
            }
        }
        public void saveip(ip ip)
        {
            using (var context = new ipLoggerContext())
            {
                context.ips.Add(ip);
                context.SaveChanges();
            }
        }
    }
}
