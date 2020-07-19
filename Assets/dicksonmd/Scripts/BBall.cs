using UnityEngine;

public class BBall : MonoBehaviour
{
    public AudioClip collisionClip;
    public AudioClip collisionWallClip;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<BBall>() != null)
        {
            AudioSource.PlayClipAtPoint(collisionClip, collision.GetContact(0).point, 1);
        }
        if (collision.transform.GetComponent<BWall>() != null)
        {
            AudioSource.PlayClipAtPoint(collisionWallClip, collision.GetContact(0).point, 1);
        }
    }
}
