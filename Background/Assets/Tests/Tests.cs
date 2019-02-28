﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Tests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestsSimplePasses()
        {
            // Use the Assert class to test conditions
        }
        [Test]
        public void getDog() {
            GameObject dog;
            dog = GameObject.Find("Dog_0");
            Assert.AreEqual(dog, GameObject.Find("Dog_0"));
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
