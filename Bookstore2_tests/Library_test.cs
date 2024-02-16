using BookStore2.Controllers;
using BookStore2.Models;
using NuGet.LibraryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bookstore2_tests
{
    [TestFixture]
    internal class Library_test
    {

        [Test]
        public void gtebook_withid_therequiredbook() {

            // aaa 
            var myresuslt = 5 * 2;
            // act
            var result = 0;
            var names = new[] { "hesham", "ayman", "abdelsamee" };
            //assert
            Assert.That(names, Has.Exactly(3).Items);
        
        }    




    }
}
