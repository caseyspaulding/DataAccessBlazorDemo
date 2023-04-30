using SupportLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace DataAccessBlazor.Models
{
    public class PersonModel : IPersonModel
    {
        [Required]
        public DateTime DateOfBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public string? FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public string? LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
