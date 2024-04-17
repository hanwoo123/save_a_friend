using UnityEngine;

public class simple_Move : MonoBehaviour
{
    [SerializeField]
    private Joystick Joystick;
    private float moveSpeed = 10;

    private void Update()
    {
        float x = Joystick.Horizontal();
        float y = Joystick.Vertical();

        if(x != 0 || y != 0)
        {
            transform.position += new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;
        }
    }
}
