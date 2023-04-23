using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Buttonscript : MonoBehaviour
{
    public void level2 ()
    {
        SceneManager.LoadScene("Level02");
    }

    public void level1 ()
    {
        SceneManager.LoadScene("Level01");
    }
}
