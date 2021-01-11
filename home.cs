using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    public GameObject ImageTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Button()
    {
        SceneManager.LoadScene("UI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
