using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class button_input : MonoBehaviour
{

    public void GameScnesCtrl()
    {
        SceneManager.LoadScene("InGameScene");
    }


}
