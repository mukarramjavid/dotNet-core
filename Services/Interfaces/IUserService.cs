﻿using Inferastructure.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IUserService : IDisposable
    {
        List<Users> GetUsers();
        //BussinessOperation create Implementation
        int CreateUser(Users user);

        Users GetById(int id);
        int UpdateUser(int id, Users user);
        void DeleteRecord(int id);
        int SaveAddress(UserAddress userAd);
        UserAddress GetAddressById(int id);
        int UpdateAddress(int rcrd, UserAddress objAd);
        void DeleteAddress(int id);
    }
}
