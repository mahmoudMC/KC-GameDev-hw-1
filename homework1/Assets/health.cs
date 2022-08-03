using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    string hero = "mahmoud";
    int Health = 100;
    // Start is called before the first frame update
    void Start()
    {
        if (Damaged(20) < Boost(10))
        {
            print(Health);
            print(Health + " is lower than " + Boost(10));
        }
        else
        {
            print(Health);
            print(Health + " is hgher than " + Boost(10));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Damaged(int dmgamount)
    {
        Health -= dmgamount;
        return Health;
    }

    int Boost(int boosted)
    {
        return Health + boosted;
    }
}
