using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace TwoAuntification
{
    public class RegistrationService
    {
        private List<User> users;

        public List<User> Users
        {
            get { return users; }
        }

        public RegistrationService()
        {
            users = new List<User>();
        }

        public void RegisterUser()
        {
            Console.WriteLine("Введите ваше Имя и Фамилию:");
            string fullName = Console.ReadLine()!;

            // Генерация публичного и приватного ключей для нового пользователя
            Key privateKey = new();
            PubKey publicKey = privateKey.PubKey;

            var newUser = new User
            {
                FullName = fullName,
                PublicKey = publicKey,
                PrivateKey = privateKey
            };

            users.Add(newUser);

            Console.WriteLine($"Пользователь {fullName} успешно зарегистрирован.");
        }

        public bool AuthenticateUser(Key privateKey)
        {
            Console.WriteLine("Введите ваше Имя и Фамилию:");
            string fullName = Console.ReadLine()!;

            var user = users.Find(u => u.FullName == fullName);

            if (user == null)
            {
                Console.WriteLine("Пользователь не найден.");
                return false;
            }

            if (user.PrivateKey == privateKey)
            {
                Console.WriteLine($"Выполнен вход под {fullName}");
                return true;
            }
            else
            {
                Console.WriteLine("Вход не выполнен. Неверный приватный ключ.");
                return false;
            }
        }
    }
}
