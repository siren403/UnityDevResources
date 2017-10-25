using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDD.Exam01
{

    public class Player
    {
        public IWeapon Weapon;
        public IInventory Inventory;


        public float Damage(float multiplier)
        {
            return Weapon.Damage() * multiplier;
        }


       

        public void AddToInventory(IItem item)
        {
            Inventory.Add(item);
        }


    }
}
