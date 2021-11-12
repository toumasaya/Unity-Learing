using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public LevelSelector currentLevel;


    // Start is called before the first frame update
    void Start()
    {
        switch (currentLevel)
        {
            case (LevelSelector.Easy):
                Debug.Log("Easy");
                break;
            case (LevelSelector.Normal):
                Debug.Log("Normal");
                break;
            case (LevelSelector.Hard):
                Debug.Log("Hard");
                break;
            case (LevelSelector.Expert):
                Debug.Log("Expert");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
