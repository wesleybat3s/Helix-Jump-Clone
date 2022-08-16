using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] Transform ball;

    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();

    }

    void Update()
    {
        if (transform.position.y - 1.5f >= ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }
    }
}
