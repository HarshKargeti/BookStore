using BookAPI.Controllers;
using BookAPI.Data;
using FakeItEasy;

namespace BookApiTests
{
    public class BookAPITests
    {
        private readonly DataContext _db;

        public BookAPITests(DataContext db)
        {
            _db = db;
        }

        [Test]
        public async void GetAllBooksTest()
        {
            var dataContext = A.Fake<DataContext>();
            
            Assert.Pass();
        }
    }
}