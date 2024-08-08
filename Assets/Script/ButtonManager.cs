using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    // Method menuju web
    public void Website()
    {
        Application.OpenURL("https://www.amdwika.com/");
    }
    // Method untuk keluar dari aplikasi

    public void ExitApplication()

    {

        Application.Quit();

    }
}
