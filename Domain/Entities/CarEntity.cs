using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public  class CarEntity
{
    [Key]
    public int CarRegistrationNumber { get; set; }

    public string Name { get; set; } = string.Empty;
}
