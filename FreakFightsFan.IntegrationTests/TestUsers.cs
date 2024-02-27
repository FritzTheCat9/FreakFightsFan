using System.Collections;

namespace FreakFightsFan.IntegrationTests
{
    public static class TestUsers
    {
        public abstract class UserBase
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class SuperAdmin : UserBase, IEnumerable<object[]>
        {
            public SuperAdmin()
            {
                Email = "freakfightsfan@gmail.com";
                Password = "AQAAAAIAAYagAAAAECWFTp9uY78qPzaRu0d3uaJNo3WOlRpwCuCyDLH+yg/TowsjzlMGxMurTnvyZaYSxA==";
            }

            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] {
                    new SuperAdmin { Email = Email, Password = Password }
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class Admin : UserBase, IEnumerable<object[]>
        {
            public Admin()
            {
                Email = "freakfightsfan1@gmail.com";
                Password = "AQAAAAIAAYagAAAAECWFTp9uY78qPzaRu0d3uaJNo3WOlRpwCuCyDLH+yg/TowsjzlMGxMurTnvyZaYSxA==";
            }

            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] {
                    new Admin { Email = Email, Password = Password }
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class User : UserBase, IEnumerable<object[]>
        {
            public User()
            {
                Email = "freakfightsfan2@gmail.com";
                Password = "AQAAAAIAAYagAAAAECWFTp9uY78qPzaRu0d3uaJNo3WOlRpwCuCyDLH+yg/TowsjzlMGxMurTnvyZaYSxA==";
            }

            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] {
                    new User { Email = Email, Password = Password }
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}