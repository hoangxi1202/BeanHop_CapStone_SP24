using BeanHop.Database.EF;
using BeanHop.Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Bussiness.Repository
{
    public class UserRepository : RepositoryBase<AppUser>
    {
        public UserRepository(BeanHopDBContext dbContext) : base(dbContext) { }
        public void ChangeStatus(AppUser appUser)
        {
            if (appUser.Status == true) appUser.Status = false;
            else appUser.Status = true;           
        }
    }
}
