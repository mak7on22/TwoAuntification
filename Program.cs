using NBitcoin;
namespace TwoAuntification
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var registrationService = new RegistrationService();

            // Регистрация первого пользователя
            registrationService.RegisterUser();

            // Регистрация второго пользователя
            registrationService.RegisterUser();

            // Попытка аутентификации первого пользователя
            bool isUser1Authenticated = registrationService.AuthenticateUser(registrationService.Users[0].PrivateKey!);

            // Попытка аутентификации второго пользователя
            bool isUser2Authenticated = registrationService.AuthenticateUser(registrationService.Users[1].PrivateKey!);
        }
    }
}
