using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    [SerializeField]
    public Scene gameScene;

    public void pressedPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void pressedGTFO()
    {
        Application.Quit();
    }

}
