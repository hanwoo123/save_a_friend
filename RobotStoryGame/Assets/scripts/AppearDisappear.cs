using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearDisappear : MonoBehaviour
{
    public float limit_time = 3.0f;
    public float current_time = 0.0f;
    public bool isEnable;

    // Start is called before the first frame update
    void Start()
    {
        isEnable = false;
        gameObject.SetActive(false);
        Debug.Log("mark1");
    }

    // Update is called once per frame
    void Update()
    {
        current_time += Time.deltaTime;
        Debug.Log("mark2"+current_time);
        if (limit_time <= current_time)
        {
            Debug.Log("mark3");
            isEnable = true;
            gameObject.SetActive(isEnable);
            current_time = 0.0f;
        }
    }
}
