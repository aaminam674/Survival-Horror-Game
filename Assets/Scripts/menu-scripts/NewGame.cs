using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public int Scene1;

    public void StartGame()
    {
        SceneManager.LoadScene(Scene1);
    }
}
