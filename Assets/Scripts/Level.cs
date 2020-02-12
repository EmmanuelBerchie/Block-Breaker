using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    // parameters
   [SerializeField] int breakableBlocks; // Serialized for debugging purposes

    // cached object reference 
    sceneLoader sceneloader;

   private void start ()
    {
        sceneloader = FindObjectOfType<sceneLoader>();
    }
   public void CountBlocks()
    {
        breakableBlocks++;
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            // sceneloader.LoadNextScene();
            GetComponent<sceneLoader>().LoadNextScene();
        }
    }

}//class
