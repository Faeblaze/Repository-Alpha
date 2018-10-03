using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState { TITLE, INGAME, GAMEOVER }

public class GameManager : MonoBehaviour
{
    public GameObject collectable;

    public int score;
    public int timer;

    private void Start()
    {
        InvokeRepeating("Spawn", 2, 2);
    }

    void Spawn()
    {
        Instantiate(collectable, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), transform.rotation);
    }
    

    private void OnEnable()
    {
        GameEvents.OnScoreChange += OnScoreChange;
    }

    private void OnDisable()
    {
        GameEvents.OnScoreChange -= OnScoreChange;
    }

    void OnScoreChange( int newScore)
    {
        score += newScore;
    }
}
