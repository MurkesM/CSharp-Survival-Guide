using UnityEngine;

public class UIManager : MonoBehaviour
{
    void OnEnable()
    {
        Player.GameOver += GameOverUI;
    }

    void GameOverUI()
    {
        Debug.Log("Enable Game Over UI");
    }

    void OnDisable()
    {
        Player.GameOver -= GameOverUI;
    }
}
