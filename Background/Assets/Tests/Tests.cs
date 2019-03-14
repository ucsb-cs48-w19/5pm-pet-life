using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Tests
    {
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
        [UnityTest]
        public IEnumerator TestSceneChangeHasDog() {
            UnityEngine.SceneManagement.Scene test = UnityEngine.SceneManagement.SceneManager.CreateScene("test");
            GameObject dog = Object.Instantiate(new GameObject());
            dog.name = "Dog_0";
            yield return null;
            Assert.NotNull(GameObject.Find("Dog_0"));
        }
    }
}
