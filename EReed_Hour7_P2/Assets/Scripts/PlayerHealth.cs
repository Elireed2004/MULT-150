using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float health = 1004f;
    [SerializeField] private float poisonDamage = 125.5f;
    [SerializeField] private float tickInterval = 0.5f; // seconds between poison ticks

    void Start()
    {
        Debug.Log(health);
        StartCoroutine(PoisonWhileAlive());
    }

    private IEnumerator PoisonWhileAlive()
    {
        while (health > 0f)
        {
            yield return new WaitForSeconds(tickInterval);
            health -= poisonDamage;
            health = Mathf.Max(0f, health);
            Debug.Log(health);
        }

        Debug.Log("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
