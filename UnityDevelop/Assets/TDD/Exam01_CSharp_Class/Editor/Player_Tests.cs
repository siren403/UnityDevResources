using NSubstitute;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDD.Exam01
{

    public class Player_Tests
    {
        [Test]
        public void Test_Damage()
        {

            var player = new Player();
            var weapon = Substitute.For<IWeapon>();
            weapon.Damage().Returns(2);
            player.Weapon = weapon;

            Assert.AreEqual(4, player.Damage(2));
        }

        [Test]
        public void Test_Inventory()
        {
            var player = new Player();
            var inventory = Substitute.For<IInventory>();
            player.Inventory = inventory;
            var item = Substitute.For<IItem>();


            //인벤토리에 아이템 객체 전달
            player.AddToInventory(item);

            //인벤토리에 전달한 아이템 객체가 같은지 검사
            inventory.Received().Add(item);
        }

    }
}
