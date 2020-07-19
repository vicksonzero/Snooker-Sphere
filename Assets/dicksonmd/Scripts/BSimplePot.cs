using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BSimplePot : MonoBehaviour
{
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedBall"))
        {
            score += 1;
            GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + score;
            StartCoroutine(ShowAndThenHide());

            //var rb = other.gameObject.GetComponent<Rigidbody>();

            //if (rb)
            //{
            //    rb.velocity = Vector3.zero;
            //    rb.angularVelocity = Vector3.zero;
            //}

            var tr = other.gameObject.GetComponent<TrailRenderer>();

            var permTrail = new GameObject("PermTrail");

            var mf = permTrail.AddComponent<MeshFilter>();
            var mr = permTrail.AddComponent<MeshRenderer>();
            mr.material = tr.material;
            tr.BakeMesh(mf.mesh, true);

            Destroy(other.gameObject);
        }
        if (other.CompareTag("Cue"))
        {
            score -= 1;
            GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + score;
            StartCoroutine(ShowAndThenHide());
            StartCoroutine(HideAndThenSetCueBall(other.gameObject));

        }
    }

    public IEnumerator HideAndThenSetCueBall(GameObject gameObject)
    {
        var rb = gameObject.GetComponent<Rigidbody>();

        if (rb)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);

        rb = gameObject.GetComponent<Rigidbody>();

        if (rb)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        gameObject.transform.position = new Vector3(0, 0, -0.3f);
        gameObject.SetActive(true);
    }

    public IEnumerator ShowAndThenHide()
    {
        GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(5f);
        GetComponent<Renderer>().enabled = false;
    }
}
