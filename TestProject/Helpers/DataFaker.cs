
namespace TestProject.PageObject
{
    public class DataFaker
    {

        public static String GeneratePasswordSignup()
        {
            return Faker.Phone.Number();

        }

        public static String GenerateNameFirst()
        {
            return Faker.Name.First();
        }

        public static String GenerateNameLast()
        {
            return Faker.Name.Last();
        }

        public static String GenerateCompanyName()
        {
            return Faker.Company.Name();
        }

        public static String GenerateAddress()
        {
            return Faker.Address.StreetAddress();
        }
        public static String GenerateState()
        {
            return Faker.Address.Country();
        }
        public static String GenerateAddressCity()
        {
            return Faker.Address.City();
        }
        public static String GenerateAddressZipCode()
        {
            return Faker.Address.ZipCode();
        }
        public static String GeneratePhoneNumber()
        {
            return Faker.Phone.Number();
        }

        public static String GenerateEmail()
        {
            return Faker.Internet.Email();
        }

    }
}
