using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using Moq;
using PhoneBookWebApi.Controllers;
using PhoneBookWebApi.Data.Interfaces;
using PhoneBookWebApi.Models;
using PhoneBookWebApi.Models.Repositories;
using Xunit;

namespace PhoneBookTests
{
    public class PhoneBookRepositoryTests
    {
        [Fact]
        public void Get_PhoneBookContact_ShouldPass()
        {
            var postRepositoryMock = new Mock<IPhoneBookRepository<PhoneBookContact>>();

            var controller = new PhoneBookContactController(postRepositoryMock.Object);

            postRepositoryMock.Setup(x => x.Get(0)).ReturnsAsync(new PhoneBookContact(){ContactID = 1});

            var control = new PhoneBookContactController(postRepositoryMock.Object);

            var res = control.Get(0);
            var result = res.Result.Value.ContactID;

            Assert.True(result == 1);
            
        }

        [Fact]
        public void Get_PhoneBookContact_ShouldFail()
        {
            var postRepositoryMock = new Mock<IPhoneBookRepository<PhoneBookContact>>();

            var controller = new PhoneBookContactController(postRepositoryMock.Object);

            postRepositoryMock.Setup(x => x.Get(0)).ReturnsAsync(new PhoneBookContact() { ContactID = 1 });

            var control = new PhoneBookContactController(postRepositoryMock.Object);

            var res = control.Get(0);
            var result = res.Result.Value.ContactID;

            Assert.True(result != 0);

        }

        [Fact]
        public async Task GetsAll_PhoneBookContact_ShouldPassAsync()
        {
            var listOfPhoneBookContacts = new List<PhoneBookContact>()
            {
                new PhoneBookContact() { ContactID = 1 },
                new PhoneBookContact() { ContactID = 2 }
            };
            var postRepositoryMock = new Mock<IPhoneBookRepository<PhoneBookContact>>();

            var controller = new PhoneBookContactController(postRepositoryMock.Object);

            postRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(listOfPhoneBookContacts);

            var control = new PhoneBookContactController(postRepositoryMock.Object);

            var res = await control.Gets();

            var countOfPhoneContacts = res.Value.Count();

            Assert.True(countOfPhoneContacts == 2);

        }

        [Fact]
        public async Task GetsAll_PhoneBookContact_ShouldFailAsync()
        {
            var listOfPhoneBookContacts = new List<PhoneBookContact>()
            {
                new PhoneBookContact() { ContactID = 1 },
                new PhoneBookContact() { ContactID = 2 }
            };
            var postRepositoryMock = new Mock<IPhoneBookRepository<PhoneBookContact>>();

            var controller = new PhoneBookContactController(postRepositoryMock.Object);

            postRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(listOfPhoneBookContacts);

            var control = new PhoneBookContactController(postRepositoryMock.Object);

            var res = await control.Gets();

            var countOfPhoneContacts = res.Value.Count();

            Assert.True(countOfPhoneContacts != 0);

        }

        [Fact]
        public async void Delete_PhoneBookContact_ShouldPass()
        {
            var postRepositoryMock = new Mock<IPhoneBookRepository<PhoneBookContact>>();

            var controller = new PhoneBookContactController(postRepositoryMock.Object);

            postRepositoryMock.Setup(x => x.Delete(1)).ReturnsAsync(new PhoneBookContact(){ContactID = 1, FirstName = "tester"});

            var control = new PhoneBookContactController(postRepositoryMock.Object);

            var res = await control.Delete(1);

            Assert.True( res.Value.FirstName == "tester");
        }

        [Fact]
        public async void Delete_PhoneBookContact_ShouldFail()
        {
            var postRepositoryMock = new Mock<IPhoneBookRepository<PhoneBookContact>>();

            var controller = new PhoneBookContactController(postRepositoryMock.Object);

            postRepositoryMock.Setup(x => x.Delete(1)).ReturnsAsync(new PhoneBookContact() { ContactID = 1, FirstName = "tester" });

            var control = new PhoneBookContactController(postRepositoryMock.Object);

            var res = await control.Delete(1);

            Assert.True(res.Value.FirstName != "testing");
        }
    }
}
