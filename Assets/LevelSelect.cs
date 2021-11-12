using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelect : MonoBehaviour
{
    public enum Difficulty
    {
        Easy,   // 0
        Normal, // 1
        Hard,   // 2
        Expert  // 3
    }
    public Difficulty selectDifficulty;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene((int)selectDifficulty);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
