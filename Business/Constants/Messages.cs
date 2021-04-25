using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "The car has been added.";
        public static string CarDeleted = "The car has been deleted.";
        public static string CarUpdated = "The car has been updated.";
        public static string CarPriceInvalid = "The daily price of the car must be greater than 0.";
        public static string CarsListed = "The cars have been listed.";        
        public static string CarsListByBrandId = "The cars have been listed by Brand Id.";
        public static string CarsListByColorId = "The cars have been listed by Color Id.";
        public static string CarsListByDailyPrice = "The cars have been listed by daily price";
        public static string CarDetailsListed = "The car's details has been listed.";


        public static string BrandAdded = "The brand has been added.";
        public static string BrandDeleted = "The brand has been deleted.";
        public static string BrandUpdated = "The brand has been updated.";
        public static string BrandNameInvalid = "The brand name must have at least 2 characters.";
        public static string BrandsListed = "The brands have been listed.";
        public static string GetBrandId = "Brought in with Brand Id.";

        public static string ColorAdded = "The color has been added.";
        public static string ColorDeleted = "The color has been deleted.";
        public static string ColorUpdated = "The color has been updated.";
        public static string ColorsListed = "The colors have been listed.";
        public static string GetColorId = "Brought in with Color Id.";

        public static string CustomerAdded = "The customer has been added.";
        public static string CustomerDeleted = "The customer has been deleted.";
        public static string CustomerUpdated = "The customer has been updated.";
        public static string CustomersListed = "The customers have been listed.";
       

        public static string UserAdded = "The user has been added.";
        public static string UserDeleted = "The user has been deleted.";
        public static string UserUpdated = "The user has been updated.";
        public static string UserListed = "The users have been listed.";
      

        public static string RentalAdded = "Rental information has been added.";
        public static string RentalDeleted = "Rental information has been deleted.";
        public static string RentalUpdated = "Rental information has been updated.";
        public static string RentalListed = "Rental information have been listed.";
        public static string RentalInvalid = "The add failed because the car wasn't delivered.";


        public static string CarImageAdded = "The image has been added.";
        public static string CarImageDeleted = "The image has been deleted.";
        public static string CarImageUpdated = "The image has been updated.";
        public static string CarImageListed = "The images has been listed.";
        public static string GetByCarId = "The image was brought in with the car Id";
        public static string ImageLimit = "The image limit is 5.";
        public static string AuthorizationDenied = "Authorization denied.";


        public static string UserNotFound = "User not found.";
        public static string UserRegistered = "User registered";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Login successful.";
        public static string UserAlreadyExists = "User already exist.";
        public static string AccessTokenCreated = "Access token has been created.";
    }
}
