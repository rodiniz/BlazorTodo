using System;
using System.ComponentModel.DataAnnotations;

namespace BazorTodo.Model
{
    public class Todo
    {
        [Required(ErrorMessage = "Please add a description")]
        [MinLength(1, ErrorMessage = "Please add a description")]
        public string Description { get; set; }
        public bool Done { get; set; } = false;
    }
}
