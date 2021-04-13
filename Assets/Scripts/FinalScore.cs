using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    GameState gameState;
    private void Awake()
    {
        gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
        if (gameState != null)
        {
            GetComponent<Text>().text = gameState.score.ToString();

        }
    }

}
