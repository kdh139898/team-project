using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sences��ȯ : MonoBehaviour
{
    public GameObject startpanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void GoGameScenes()
    {
        SceneManager.LoadScene(1);
    }
}
