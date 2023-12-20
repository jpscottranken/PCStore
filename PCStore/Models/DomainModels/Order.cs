using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace PCStore.Models.DomainModels
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "You must enter your first name.")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter your last name.")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter your address.")]
        public string? Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter your city.")]
        public string? City { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter your state.")]
        [StringLength(2, MinimumLength = 2)]
        public string? State { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter your zip.")]
        [Display(Name = "Zip Code")]
        [StringLength(5, MinimumLength = 5)]
        public string? ZipCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter your phone number.")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; } = string.Empty;

        public List<OrderDetail>? OrderDetails { get; set; } = null;

        [BindNever]
        public double? OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; } = DateTime.Now;
    }
}
