using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [SerializeField] float step = 0.01f;

    void Update()
    {
        transform.Rotate(new Vector3(0.0f, step, 0.0f));
    }
}
