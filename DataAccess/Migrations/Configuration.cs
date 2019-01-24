namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CarDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Cars]");

            context.Cars.AddOrUpdate(new Car("Porsche 911", "RTE 886", "Black", "Steven Michael"));
            context.Cars.AddOrUpdate(new Car("Lexus LC", "EXQ 563", "Black", "Nicholas Hall"));
            context.Cars.AddOrUpdate(new Car("Kia Cadenza", "RBN 513", "Silver", "Janos Keller"));
            context.Cars.AddOrUpdate(new Car("Mazda MX-5 Miata", "MNQ 212", "Yellow", "Meredith Jones"));
            context.Cars.AddOrUpdate(new Car("Lexus LC", "RTE 995", "Red", "Dominic West"));
            context.Cars.AddOrUpdate(new Car("Jaguar XJ", "TLM 101", "Yellow", "Matthew Headey"));
            context.Cars.AddOrUpdate(new Car("Audi A6", "BVQ 577", "Red", "Alison Bailey"));
            context.Cars.AddOrUpdate(new Car("Porsche Panema", "PRR 833", "Blue", "Tyrion Dinklage"));
            context.Cars.AddOrUpdate(new Car("Chevrolet Sonic", "TZU 123", "Yellow", "Janos Dark"));
            context.Cars.AddOrUpdate(new Car("Honda Fit", "IKI 521", "Green", "Michael S. Kelvin"));
            context.Cars.AddOrUpdate(new Car("BMW 8-Series", "RTE 679", "Pink", "Janos Hull"));
            context.Cars.AddOrUpdate(new Car("Audi R8", "PQW 544", "Red", "Cathy Stone"));
            context.Cars.AddOrUpdate(new Car("Tesla Model 3", "ZTT 352", "Red", "Alyssa Kellis"));
            context.Cars.AddOrUpdate(new Car("Mercedes-Benz GT", "TRW 198", "White", "Nikki Milano"));
            context.Cars.AddOrUpdate(new Car("Volvo V60", "KLM 142", "White", "George Fulton"));
            context.Cars.AddOrUpdate(new Car("Chrysler 300", "MIT 341", "Gold", "Martha Harrison"));
            context.Cars.AddOrUpdate(new Car("Nissan Maxima", "ZTQ 900", "Silver", "Janos Wilder"));
            context.Cars.AddOrUpdate(new Car("Ford Fusion", "MKE 352", "Red", "Nikolaj Coster"));
            context.Cars.AddOrUpdate(new Car("Toyota Avalon Hybrid", "PPQ 599", "Green", "Attila Meyer"));
            context.Cars.AddOrUpdate(new Car("Kia Rio", "BUB 555", "Pink", "Jessica Beach"));
            context.Cars.AddOrUpdate(new Car("Cadillac XTS", "NOQ 822", "Blue", "Janos Jones"));
            context.Cars.AddOrUpdate(new Car("Lincoln Continental", "PPQ 599", "Red", "Thomas Hiddleston"));
            context.Cars.AddOrUpdate(new Car("Acura RLX", "IRX 652", "White", "Kelly Brown"));
            context.Cars.AddOrUpdate(new Car("Volkswagen Golf", "ABB 155", "Silver", "Karl Hammer"));
            context.Cars.AddOrUpdate(new Car("Dacia Duster", "OQL 343", "Red", "Kit Snow"));
            context.Cars.AddOrUpdate(new Car("Skoda Yeti SUV", "JIQ 212", "Black", "Janos Harrington"));
            context.Cars.AddOrUpdate(new Car("Ford Focus", "WEQ 910", "Black", "Brienne Harris"));
            context.Cars.AddOrUpdate(new Car("Volkswagen T2", "GTB 331", "Green", "Janos Marley"));
            context.Cars.AddOrUpdate(new Car("Chevrolet Silverado 1500", "ABB 155", "Blue", "Alan Parrish"));
            context.Cars.AddOrUpdate(new Car("Ford F-150", "HNJ 816", "Gold", "Hannah Summers"));
            context.Cars.AddOrUpdate(new Car("Ford Mustang Shelby GT350", "GWQ 255", "Red", "Eleanor Monroe"));

            context.SaveChanges();
        }
    }
}
