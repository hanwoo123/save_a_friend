using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearDisappear : MonoBehaviour
{
    public float limit_time = 1.0f;
    public float current_time = 0.0f;
    public bool isEnable = false;
    public float set_x = 1.0f;
    public float set_y = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        current_time += Time.deltaTime;
        if (limit_time <= current_time)
        {
            if (!isEnable)
            {
                gameObject.transform.Translate(new Vector3(set_x, set_y, 0f));
                isEnable = true;
            }
            current_time = 0.0f;
        }
    }
}
