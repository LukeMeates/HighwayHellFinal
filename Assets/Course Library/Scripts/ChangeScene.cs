using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;
    public string URL = "https://github.com/LukeMeates/HighwayHellFinal";

    public bool useIntToLoadLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
 
    }

    private void OnTriggerEnter(Collider collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collisionGameObject.name == "Player")
        {
            LoadScene();
        }
    }

    public void loadURL()
    {
        Application.OpenURL(URL);
    }

    void LoadScene()
    {
        if(useIntToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
}