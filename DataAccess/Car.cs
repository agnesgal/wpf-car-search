using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="Car {0} is a required")]
        [StringLength (50, MinimumLength = 5, ErrorMessage ="Type should be between 5-25 character")]
        [DataType(DataType.Text)]
        public string Type { get; set; }

        [Required(ErrorMessage = "Car {0} is a required")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "PlateNumber should 7 character long")]
        [DataType(DataType.Text)]
        public string PlateNumber { get; set; }

        [Required(ErrorMessage = "Car {0} is a required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Color should be between 3-10 character")]
        [DataType(DataType.Text)]
        public string Color { get; set; }

        [Required(ErrorMessage = "Car {0} is a required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Driver should be between 3-10 character")]
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
