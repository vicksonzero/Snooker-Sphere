using UnityEngine;

public class ToggleGameObjectEnable : MonoBehaviour
{
    [SerializeField]

    private bool _enabled = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            _enabled = !_enabled;
            gameObject.SetActive(_enabled);
        }
    }
}
