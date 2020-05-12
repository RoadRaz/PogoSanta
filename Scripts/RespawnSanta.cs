using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnSanta : MonoBehaviour
{
    public float fellVal;

    void FixedUpdate()
    {
        if (transform.position.y < fellVal)
        {
            transform.position = new Vector3((float)-0.01461363, (float)-2.3, 0);
            restartScene();
            ScoreScript.scoreVal = 0;
        }
    }

    public void restartScene()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Application.Quit();
    }
}
