using UnityEngine;

public class GameState : MonoBehaviour
{
    public int score;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void Start()
    {
        score = 0;
    }


    public void updateScore()
    {
        score += 20;
    }

    public void resetScore()
    {
        score = 0;
    }

}
