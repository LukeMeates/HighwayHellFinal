using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    private Vector3 rotate;

    // Start is called before the first frame update
    void Start()
    {
        //the coins will roatate in the x, y, z position 
        rotate = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //the coins will go at the rotate default speed
        transform.Rotate(rotate);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the player intereacts with the coin it will be destoryed/picked up in game
        if(other.name == "Player")
        {
            other.GetComponent<CoinCollection>().points++;
            //the object will be destroyed
            Destroy(gameObject);
        }
    }
}
