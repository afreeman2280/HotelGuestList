using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.DataAccessObjects;
using BusinessLogic;
using BusinessLogic.BusinessLogicObject;

namespace BusinessLogic
{
    public class UserBusinessLogic
    {
        static UserDataAccess _dal = new UserDataAccess();
        static DataAccessUser daUser = new DataAccessUser();
        public void createUserFromDatabase(UserBusinessLogic boCustomer)
        {
            DataAccessUser daCustomer = MapperBLL(boCustomer);
            _dal.CreateDaUser(daCustomer);
        }
        static DataAccessUser MapperBLL(BusinessUserObjects boUser)
        {

            DataAccessUser daUser = new DataAccessUser();
            daUser.UserName = boUser.UserName;
            daUser.Password = boUser.Password;
            daUser.FirstName = boUser.FirstName;
            daUser.LastName = boUser.LastName;
            daUser.Email = boUser.Email;
            daUser.Birthdate = boUser.Birthdate;
            daUser.City = boUser.City;
            daUser.State = boUser.State;
            daUser.StreetAddress = boUser.StreetAddress;
            daUser.Zipcode = boUser.Zipcode;
            daUser.SecurityQuestion = boUser.SecurityQuestion;
            daUser.SecurityAnswer = boUser.SecurityAnswer;
            daUser.Arrival = boUser.Arrival;
            daUser.Depature = boUser.Depature;
            return daUser;
        }
        static BusinessUserObjects MapperBLL(DataAccessUser daUser)
        {

            DataAccessUser daUser = new DataAccessUser();
            daUser.UserName = boUser.UserName;
            daUser.Password = boUser.Password;
            daUser.FirstName = boUser.FirstName;
            daUser.LastName = boUser.LastName;
            daUser.Email = boUser.Email;
            daUser.Birthdate = boUser.Birthdate;
            daUser.City = boUser.City;
            daUser.State = boUser.State;
            daUser.StreetAddress = boUser.StreetAddress;
            daUser.Zipcode = boUser.Zipcode;
            daUser.SecurityQuestion = boUser.SecurityQuestion;
            daUser.SecurityAnswer = boUser.SecurityAnswer;
            daUser.Arrival = boUser.Arrival;
            daUser.Depature = boUser.Depature;
            return daUser;
        }
    }
}
