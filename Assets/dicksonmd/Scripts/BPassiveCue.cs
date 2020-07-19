using UnityEngine;

public class BPassiveCue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var cueBall = GameObject.Find("RemoteBall");
        if (cueBall)
        {
            var sqrMagnitude = cueBall.GetComponent<Rigidbody>().velocity.sqrMagnitude;
            if (sqrMagnitude <= 0.001f)
            {
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(true);
                transform.position = cueBall.transform.position;
                transform.rotation = cueBall.transform.rotation;
            }else
            {
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
