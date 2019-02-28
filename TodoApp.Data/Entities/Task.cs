using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Data
{
    public class Task
    {
        public Guid Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        public DateTime? DueDate { get; set; }
    }
}