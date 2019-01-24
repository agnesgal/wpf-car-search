using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength (30, MinimumLength = 5)]
        [DataType(DataType.Text)]
        public string Type { get; set; }

        [Required]
        [StringLength(7, MinimumLength = 7)]
        [DataType(DataType.Text)]
        public string PlateNumber { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        [DataType(DataType.Text)]
        public string Color { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 5)]
        [DataType(DataType.Text)]
        public string Driver { get; set; }

        public Car(string type, string plateNumber, string color, string driver)
        {
            Type = type;
            PlateNumber = plateNumber;
            Color = color;
            Driver = driver;
        }
        public Car() { }
    }
}
