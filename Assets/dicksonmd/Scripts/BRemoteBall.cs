using UnityEngine;

public class BRemoteBall : MonoBehaviour
{
    Rigidbody rb;
    public float impulseForce = 20f;
    public float rotSpeed = 0.1f;
    public float rotSpeedFast = 1f;
    public GameObject ghostBall;
    public GameObject ghostBallInstance;

    public bool doShootInNextFrame = false;
    LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {

        lr = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody>();
        ghostBallInstance = Instantiate(ghostBall);
        ghostBallInstance.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            doShootInNextFrame = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity.sqrMagnitude > 0.001f)
        {
            ghostBallInstance.SetActive(false);
        }
        else
        {
            if (doShootInNextFrame || doShootInNextFrame)
            {
                var snapshot = GetComponent<BBallSnapshot>();
                if (snapshot)
                {
                    snapshot.LogCoords(1);
                }
                rb.AddForce(transform.forward * impulseForce);
                doShootInNextFrame = false;
            }
            RaycastHit hit;

            Vector3 p1 = transform.position;
            float radius = 2f;
            float distanceToObstacle = 0;

            // Cast a sphere wrapping character controller 10 meters forward
            // to see if it is about to hit anything.
            if (Physics.SphereCast(p1, radius, transform.forward, out hit, 200))
            {
                distanceToObstacle = hit.distance;
                ghostBallInstance.SetActive(true);
                ghostBallInstance.transform.position = hit.point + hit.normal.normalized * radius;

                lr.SetPositions(new Vector3[]
                {
                    hit.point,
                    hit.point + hit.normal.normalized * -100f
                });
            }
        }

        float speed = rotSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = rotSpeedFast;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Camera.main.transform.right, -speed, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Camera.main.transform.right, speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Camera.main.transform.up, -speed, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Camera.main.transform.up, speed, Space.World);
        }

        doShootInNextFrame = false;
    }
}
