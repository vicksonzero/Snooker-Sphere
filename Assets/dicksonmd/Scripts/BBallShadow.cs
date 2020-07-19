using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class BBallShadow : MonoBehaviour
{
    LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        var rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.sleepThreshold = 0.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPositions(new Vector3[]
        {
            transform.position,
            transform.position.normalized * 50f
        });
    }
}
