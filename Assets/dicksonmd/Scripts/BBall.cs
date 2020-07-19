using UnityEngine;

public class BBall : MonoBehaviour
{
    public AudioClip collisionClip;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<BBall>() != null)
        {
            AudioSource.PlayClipAtPoint(collisionClip, collision.GetContact(0).point);
        }
    }
}
