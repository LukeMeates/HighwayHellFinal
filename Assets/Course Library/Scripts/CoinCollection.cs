using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    //declared a variable to show the points
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        //this will update everytime a coin is collected and will be shown
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
}
