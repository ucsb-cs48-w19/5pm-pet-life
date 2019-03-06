using UnityEngine; using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.UI;   public class healthB : MonoBehaviour{     public Slider healthUI;     private float time = 0;     public float maxHealth = 200;       // Use this for initialization     public void Start () {         healthUI = GetComponent<Slider>();         healthUI.value = maxHealth;     }         // Update is called once per frame     public void Update () {         transform.rotation = Camera.main.transform.rotation;         if (time >= 1)         {             healthUI.value -= 1;             time = 0;         }         else         {             time += Time.deltaTime;         }         if (healthUI.value <= 0)         {             healthUI.value = 0;             Debug.Log("Dead!");         }     }
    public void MakeHappier(int amount)
    {         healthUI.value += amount;         if (healthUI.value > 200)
        {
            healthUI.value = 200;
        }
    }

} 