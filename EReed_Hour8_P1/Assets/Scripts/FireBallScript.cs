using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
        print("Player health: " + x);

        int y = TakeDamageFromFireball(25);
        print("Player health: " + y);

        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // No-argument version: applies a default fireball damage
    int TakeDamageFromFireball()
    {
        int health = 100;
        int defaultDamage = 10;
        return health - defaultDamage;
    }

    // Single-argument version: uses the passed damage amount
    int TakeDamageFromFireball(int damageAmount)
    {
        int health = 100;
        return health - damageAmount;
    }

    // Two-argument version: damage is reduced by armor (cannot be negative)
    int TakeDamageFromFireball(int damageAmount, int armor)
    {
        int health = 100;
        int effectiveDamage = Mathf.Max(0, damageAmount - armor);
        return health - effectiveDamage;
    }
}
