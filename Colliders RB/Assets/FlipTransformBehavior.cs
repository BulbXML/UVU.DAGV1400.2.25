using UnityEngine;

public class FlipTransformBehavior : MonoBehaviour
{
    public KeyCode key1 = KeyCode.RightArrow, key2 = KeyCode.LeftArrow;
    public float direction1 = 0.125f, direction2 = -0.125f;

    private void Update()
    {
        if (Input.GetKeyDown(key1))
            {
            Vector3 scale = transform.localScale;
            scale.x = direction1;
            transform.localScale = scale;
            }
        else if (Input.GetKeyDown(key2))
            {
            Vector3 scale = transform.localScale;
            scale.x = direction2;
            transform.localScale = scale;
        }
    }
}