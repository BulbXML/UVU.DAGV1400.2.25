using UnityEngine;

public class TransformController : MonoBehaviour
{
    [SerializeField] private float xSpeed = 2.0f;
    [SerializeField] private float ySpeed = 1.0f;
    [SerializeField] private float xRot = 15.0f;
    [SerializeField] private float yRot = 30.0f;
    [SerializeField] private float zRot = 45.0f;
    // Start is called before the first frame update
    private void Update()
    {
        // MOVEMENT
        // Speed controlled by xSpeed and ySpeed floats
        var x = Mathf.PingPong(Time.time, xSpeed);
        var y = Mathf.PingPong(Time.time, ySpeed);
        // Horizontal movement created as x, combined with vertical movement (changed to y)
        var p = new Vector3(x, y, 0);
        transform.position = p;

        // ROTATION
        // Rotation speeds controlled by xRot, yRot and zRot floats
        transform.Rotate(new Vector3(xRot, yRot, zRot) * Time.deltaTime);
    }
}
