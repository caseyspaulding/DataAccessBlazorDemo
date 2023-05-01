using SupportLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace DataAccessBlazor.Models

// This is the implementation of the interface IPersonModel
// This is the class that will be used to pass data between the UI and the DataAccess layer
// This class is used in the DataAccessBlazor project

// This is to display and resrict what goes into this model. This is a ** Display Model **
{
    public class DisplayPersonModel : IPersonModel
    {
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string? FirstName { get; set; }

        public int Id { get; set; }
        [Required]
        public string? LastName { get; set; }
    }
}
