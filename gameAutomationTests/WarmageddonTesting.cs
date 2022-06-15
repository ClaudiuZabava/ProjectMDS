using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
 
namespace Tests
{
    public class DirectionTests
    {
        [Test]
        public void North()
        {
            Assert.AreEqual(new Vector3(0,1,0), Player.North);
        }
 
        [Test]
        public void South()
        {
            Assert.AreEqual(new Vector3(0,-1,0), Player.South);
        }
 
        [Test]
        public void Left()
        {
            Assert.AreEqual(new Vector3(-1,0,0), Player.Left);
        }
 
        [Test]
        public void Right()
        {
            Assert.AreEqual(new Vector3(1,0,0), Player.Right);
        }
    }
 
    public class ShootingTest
    {
		Instance = GetComponent<PlayerGun>();
        [Test]
        public void Shoot()
        {
            Assert.AreEqual(lastTimeShot + firingSpeed, Player.Shoot);
        }
    }
}