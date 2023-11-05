using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Task_planner.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a description.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Select a category.")]
        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Select a status")]
        public string StatusId {  get; set; } = string.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
    }
}
