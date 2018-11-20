using System;
using System.Collections.Generic;
using Challenge1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge1_UnitTest
{
    [TestClass]
    public class Challenge1_Tests
    {
        MenuRepository _menuRepo = new MenuRepository();
        Menu menu;
        List<Menu> list;

        [TestInitialize]
        public void Arrange()
        {
            menu = new Menu(1, "fun meal", "burger on bun", "beef patty, bun, condiments", 5.99m);
            var list = _menuRepo.GetListItems();
        }

        [TestMethod]

        public void MenuRepo_AddMenuItemToList_ListCountEqualToOne()
        {
            //Arrange
            _menuRepo.AddMenuItemToList(menu);

            //Act
            var actual = list.Count;
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepo_DeleteMenuItem_ListCountEqualToZero()
        {
            //Arrange
            _menuRepo.DeleteMenuItem(menu);

            //Act
            var actual = list.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
