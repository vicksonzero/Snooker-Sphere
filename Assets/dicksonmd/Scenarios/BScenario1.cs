using System;
using UnityEngine;

public class BScenario1 : MonoBehaviour
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
        GameObject ball;
        // Strike 2 (0.02):

        // RemoteBall
        ball = Instantiate(remoteBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -1.929827f,
                    -11.92204f,
                    2.281851f
                )
            ),
            Quaternion.Euler(
                62.34661f,
                354.1221f,
                329.9369f
            )
        );
        ball.gameObject.name = String.Format("RemoteBall");

        // RedBall (0, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -6.935443f,
                    -6.45213f,
                    4.165686f
                )
            ),
            Quaternion.Euler(
                340.2398f,
                24.86657f,
                357.3847f
            )
        );
        ball.gameObject.name = String.Format("RedBall (0, 0, 0)");

        // RedBall (1, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -2.619946f,
                    -24.61929f,
                    14.97006f
                )
            ),
            Quaternion.Euler(
                2.572034f,
                273.3376f,
                258.0197f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 0, 0)");

        // RedBall (1, 1, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -24.69388f,
                    -2.919446f,
                    15.39465f
                )
            ),
            Quaternion.Euler(
                86.24934f,
                321.7047f,
                62.39153f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 1, 0)");

        // RedBall (1, 1, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -3.510155f,
                    -36.71547f,
                    11.04961f
                )
            ),
            Quaternion.Euler(
                19.8798f,
                311.8969f,
                176.8252f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 1, 1)");

        // RedBall (2, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -2.575981f,
                    -31.5585f,
                    -21.24309f
                )
            ),
            Quaternion.Euler(
                295.3675f,
                330.1335f,
                307.0261f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 0, 0)");

        // RedBall (2, 1, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -5.618971f,
                    4.566665f,
                    11.19492f
                )
            ),
            Quaternion.Euler(
                4.594916f,
                346.6156f,
                9.355017f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 1, 0)");

        // RedBall (2, 1, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.5504919f,
                    -7.581286f,
                    4.451394f
                )
            ),
            Quaternion.Euler(
                340.2477f,
                49.35156f,
                306.5909f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 1, 1)");

        // RedBall (2, 2, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    1.064607f,
                    45.45701f,
                    -2.649443f
                )
            ),
            Quaternion.Euler(
                287.07f,
                258.1732f,
                72.88937f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 0)");

        // RedBall (2, 2, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -20.1301f,
                    21.39624f,
                    31.69048f
                )
            ),
            Quaternion.Euler(
                43.41012f,
                75.47196f,
                106.4275f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 1)");

        // RedBall (2, 2, 2)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -26.59228f,
                    -31.55514f,
                    -12.22601f
                )
            ),
            Quaternion.Euler(
                343.7271f,
                324.0271f,
                358.0322f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 2)");


    }
}
