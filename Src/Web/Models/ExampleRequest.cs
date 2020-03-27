using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Web.Models
{
    public class ExampleRequest
    {
        [Required] public string Name { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public bool Alive { get; set; }
        [Required, JsonConverter(typeof(JsonStringEnumConverter))]
        public Gender Gender { get; set; }
        [Required] public int NumberOfSiblings { get; set; }
    }
}
