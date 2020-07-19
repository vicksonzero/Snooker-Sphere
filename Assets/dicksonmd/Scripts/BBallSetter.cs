using System;
using UnityEngine;

public class BBallSetter : MonoBehaviour
{
    public float radius = 0.04f;

    public bool isSpawnRemoteBalls = false;
    public GameObject remoteBallPrefab;


    public bool isSpawnCueBall = false;
    public GameObject cueBallPrefab;

    public bool isSpawnRedBalls = true;
    public int redBallsWidth = 3;
    public GameObject redBallPrefab;


    // Start is called before the first frame update
    void Start()
    {
        transform.localRotation = Quaternion.LookRotation(new Vector3(1, 1, 1), Vector3.up);

        if (isSpawnRedBalls)
        {
            SpawnRedBalls();
        }
        if (isSpawnRemoteBalls)
        {
            SpawnRemoteBalls();
        }
    }

    public void SpawnRedBalls()
    {
        int width = redBallsWidth;
        var diameter = radius * 2;

        var zStart = 0f;
        var zStep = Mathf.Sqrt(12f / 18) * diameter;

        for (int k = 0; k < width; k++) // set, pair with z
        {
            var yStart = -Mathf.Sqrt(3f) / 3 * k * diameter;
            var yStep = Mathf.Sqrt(3f) / 2 * diameter;
            for (int i = 0; i < k + 1; i++) // layer, pair with y
            {
                var xStart = -0.5f * i * diameter;
                var xStep = diameter;
                for (int j = 0; j <= i; j++) // rank, pair with x
                {
                    var ball = Instantiate(
                        redBallPrefab,
                        transform.TransformPoint(
                            new Vector3(
                                xStart + xStep * j,
                                yStart + yStep * i,
                                zStart + zStep * k
                            )
                        ),
                        Quaternion.identity
                    );
                    ball.gameObject.name = String.Format("RedBall ({0}, {1}, {2})", k, i, j);
                }
            }
        }
    }

    public void SpawnRemoteBalls()
    {
        var ball = Instantiate(
            remoteBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0,
                    0,
                    -15f * radius
                )
            ),
            Quaternion.LookRotation(transform.TransformPoint(
                new Vector3(
                    0,
                    0,
                    0.3f
                )
            ), Vector3.up)
        );
        ball.gameObject.name = String.Format("RemoteBall");
    }
}
