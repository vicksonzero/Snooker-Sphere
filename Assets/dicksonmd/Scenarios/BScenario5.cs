using System;
using UnityEngine;

public class BScenario5 : MonoBehaviour
{
    public GameObject remoteBallPrefab;
    public GameObject cueBallPrefab;
    public GameObject redBallPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if (!remoteBallPrefab)
        {
            remoteBallPrefab = GetComponent<BBallSetter>().remoteBallPrefab;
        }
        if (!cueBallPrefab)
        {
            cueBallPrefab = GetComponent<BBallSetter>().cueBallPrefab;
        }
        if (!redBallPrefab)
        {
            redBallPrefab = GetComponent<BBallSetter>().redBallPrefab;
        }
        SpawnScenario();
    }

    public void SpawnScenario()
    {
        // Strike 3:

        // RemoteBall
        var ball = Instantiate(remoteBallPrefab,
                    transform.TransformPoint(
                        new Vector3(
                            0.3394931f,
                            -0.02841143f,
                            0.01201002f
                        )
                    ),
                    Quaternion.Euler(
                        19.95359f,
                        266.5403f,
                        357.5619f
                    )
                );
        ball.gameObject.name = String.Format("RemoteBall");

        // RedBall (0, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.1668183f,
                    -0.06793308f,
                    0.1180253f
                )
            ),
            Quaternion.Euler(
                314.4789f,
                163.4958f,
                26.72075f
            )
        );
        ball.gameObject.name = String.Format("RedBall (0, 0, 0)");

        // RedBall (1, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.01786215f,
                    -0.4615368f,
                    0.00897512f
                )
            ),
            Quaternion.Euler(
                327.6971f,
                54.65041f,
                104.22f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 0, 0)");

        // RedBall (1, 1, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.09724672f,
                    0.3612874f,
                    -0.1592733f
                )
            ),
            Quaternion.Euler(
                65.29223f,
                343.7962f,
                346.0289f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 1, 0)");

        // RedBall (1, 1, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.03172064f,
                    -0.1088203f,
                    -0.281323f
                )
            ),
            Quaternion.Euler(
                310.2553f,
                134.5918f,
                338.6344f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 1, 1)");

        // RedBall (2, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.1101038f,
                    0.4450569f,
                    0.07186989f
                )
            ),
            Quaternion.Euler(
                338.4653f,
                202.6449f,
                224.0463f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 0, 0)");

        // RedBall (2, 1, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.2610101f,
                    -0.01212338f,
                    0.02125964f
                )
            ),
            Quaternion.Euler(
                314.0136f,
                56.63285f,
                343.963f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 1, 0)");

        // RedBall (2, 1, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.0004735f,
                    0.2247949f,
                    0.2891807f
                )
            ),
            Quaternion.Euler(
                6.847414f,
                274.4164f,
                23.83367f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 1, 1)");

        // RedBall (2, 2, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.00173056f,
                    -0.1227086f,
                    -0.00207312f
                )
            ),
            Quaternion.Euler(
                307.0612f,
                322.2089f,
                337.5968f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 0)");

        // RedBall (2, 2, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.1236164f,
                    -0.1416553f,
                    0.123455f
                )
            ),
            Quaternion.Euler(
                64.3504f,
                197.8012f,
                112.234f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 1)");

        // RedBall (2, 2, 2)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.2038489f,
                    0.139564f,
                    -0.1123708f
                )
            ),
            Quaternion.Euler(
                316.1903f,
                94.90681f,
                231.5465f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 2)");



    }
}
