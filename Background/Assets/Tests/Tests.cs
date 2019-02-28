using System.Collections;
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
        public void GetDog() {
            GameObject dog = Object.Instantiate(new GameObject());
            dog.name = "dog";
            Assert.AreEqual(dog, GameObject.Find("dog"));
        }
        [Test]
        public void TestDogScene() {
            GameObject dog = Object.Instantiate(new GameObject());
            Assert.AreEqual(dog.scene, UnityEngine.SceneManagement.SceneManager.GetActiveScene());
        }
        /*
        [UnityTest]
        public IEnumerator TestSceneChangeHasDog() {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Background.unity", UnityEngine.SceneManagement.LoadSceneMode.Additive);
            yield return null;
            Assert.NotNull(GameObject.Find("Dog_0"));
        }*/

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
