﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Dal.Abstract;
using Northwind.Entities;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class EfAuthenticationDal:IAuthenticationDal
    {
        public User Authenticate(User user)
        {   
            if (user.UserName == "ahmet" && user.Password == "1616")
            {
                return user;
            }
            return null;
        }
        
    }
}
