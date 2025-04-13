using UnityEngine;

public class QuitGame : MonoBehaviour
{



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnApplicationQuit()
    {
        
    }
    public void Quit()
    {
        
        Application.Quit();
        Debug.Log("Pus ya te muriste");
      }
}
