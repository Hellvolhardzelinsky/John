using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collision)
{
	if(CollisionInfo.collider.tag=="GoldCoins ")
    {
    	//This is example
        Destroy(GoldCoins);
        //code your thing here
    }
}
}
