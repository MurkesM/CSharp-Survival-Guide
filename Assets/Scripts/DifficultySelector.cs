using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelector : MonoBehaviour
{
     public enum DifficultySelectorEnum
     {
        Easy,
        Normal, 
        Hard, 
        DarkSouls
     }

    public DifficultySelectorEnum difficultySelector;

    void Start()
    {
        LoadSceneExample(difficultySelector);
    }

    void LoadSceneExample(DifficultySelectorEnum difficulty)
    {
        SceneManager.LoadScene((int)difficulty);
    }
}