using UnityEngine;

public class BBallSnapshot : MonoBehaviour
{
    private int strike = 0;
    private string logs = "";
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.KeypadDivide))
        {
            LogCoords();
        }
    }

    public void LogCoords(int deltaStrike = 0)
    {
        strike += deltaStrike;
        var str = string.Format("// Strike {0} ({1}):\n\n", strike, Time.fixedTime);
        var ball = GameObject.Find("RemoteBall");
        str += ObjectToString(ball, "remoteBallPrefab");

        var existingBalls = GameObject.FindGameObjectsWithTag("RedBall");

        foreach (var item in existingBalls)
        {
            str += ObjectToString(item, "redBallPrefab");
        }

        Debug.Log(str);
        logs += str + "\n";
        TextEditor te = new TextEditor();
        te.text = logs;
        te.SelectAll();
        te.Copy();
    }

    public string ObjectToString(GameObject obj, string prefabName)
    {
        var po = obj.transform.position;
        var euler = obj.transform.rotation.eulerAngles;
        return string.Format("// {0}\n" +
                "ball = Instantiate({1},\n" +
                "    transform.TransformPoint(\n" +
                "        new Vector3(\n" +
                "            {2}f,\n" +
                "            {3}f,\n" +
                "            {4}f\n" +
                "        )\n" +
                "    ),\n" +
                "    Quaternion.Euler(\n" +
                "        {5}f,\n" +
                "        {6}f,\n" +
                "        {7}f\n" +
                "    )\n" +
                ");\n" +
                "ball.gameObject.name = String.Format(\"{8}\");\n\n",
                obj.name,
                prefabName,
                po.x.ToString("0.########"), po.y.ToString("0.########"), po.z.ToString("0.########"),
                euler.x.ToString("0.########"), euler.y.ToString("0.########"), euler.z.ToString("0.########"),
                obj.name
            );
    }
}
