using System;
using UnityEngine;

public class BScenario4 : MonoBehaviour
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
        // Strike 1:

        // RemoteBall
        var ball = Instantiate(
            remoteBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    -0.1732051f,
                    -0.1732051f,
                    -0.1732051f
                )
            ),
            Quaternion.Euler(
                323.0355f,
                45.00003f,
                -0.00002564f
            )
        );
        ball.gameObject.name = String.Format("RemoteBall");

        // RedBall (0, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0f,
                    0f,
                    0f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (0, 0, 0)");

        // RedBall (1, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.02828427f,
                    0f,
                    0.02828427f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 0, 0)");

        // RedBall (1, 1, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0f,
                    0.02828427f,
                    0.02828427f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 1, 0)");

        // RedBall (1, 1, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.02828427f,
                    0.02828427f,
                    0f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (1, 1, 1)");

        // RedBall (2, 0, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.05656855f,
                    0.00000001f,
                    0.05656854f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 0, 0)");

        // RedBall (2, 1, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.02828428f,
                    0.02828428f,
                    0.05656854f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 1, 0)");

        // RedBall (2, 1, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.05656855f,
                    0.02828428f,
                    0.02828427f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 1, 1)");

        // RedBall (2, 2, 0)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0f,
                    0.05656855f,
                    0.05656854f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 0)");

        // RedBall (2, 2, 1)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.02828427f,
                    0.05656855f,
                    0.02828427f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 1)");

        // RedBall (2, 2, 2)
        ball = Instantiate(redBallPrefab,
            transform.TransformPoint(
                new Vector3(
                    0.05656854f,
                    0.05656855f,
                    -0.00000001f
                )
            ),
            Quaternion.Euler(
                0f,
                0f,
                0f
            )
        );
        ball.gameObject.name = String.Format("RedBall (2, 2, 2)");

    }
}
