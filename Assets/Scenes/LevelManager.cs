using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);

        Application.LoadLevel(name);
    }

    public void QuitRequest(string name)
    {
        Application.Quit();
    }
}
