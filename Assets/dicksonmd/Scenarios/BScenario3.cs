using System;
using UnityEngine;

public class BScenario3 : MonoBehaviour
{
    public GameObject remoteBallPrefab;
    public GameObject cueBallPrefab;
    public GameObject redBallPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnScenario();
    }

    public void SpawnScenario()
    {
        var ball = Instantiate(
            remoteBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.2166081f,
                    -0.2390426f,
                    -0.06905646f
                )
            ),
            Quaternion.Euler(
                339.8477f,
                69.26005f,
                1.59742f
            )
        );
        ball.gameObject.name = String.Format("RemoteBall");


        ball = Instantiate(
            redBallPrefab,
            // RedBall (1, 1, 0) // this
            transform.TransformPoint(
                new Vector3(
                    -0.0824459f,
                    -0.1485305f,
                    -0.01886238f
                )
            ),
            Quaternion.Euler(
                2.1321f,
                212.8004f,
                173.1896f
            )
        );
        ball.gameObject.name = String.Format("RedBall");
    }
}
