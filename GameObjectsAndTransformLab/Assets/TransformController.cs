using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        // MOVEMENT
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        transform.position = p;

        // ROTATION
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
