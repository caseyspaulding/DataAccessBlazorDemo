﻿namespace SupportLibrary.Models

// This is the implementation of the interface IPersonModel
// This is the class that will be used to pass data between the UI and the DataAccess layer
// This class is used in the DataAccessBlazor project

// This is for transfering data between the UI Frontend and sending it to the DataBase layer  Only
// This its only JOB. 

{
    internal class PersonModel : IPersonModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


    }
}
