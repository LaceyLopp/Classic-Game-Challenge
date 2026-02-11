using UnityEngine;
using UnityEngine.InputSystem;

public class QuitGame : MonoBehaviour

{
  
        void Update()
        {
            if (Input.GetKeyDown("escape"))
            {
                Application.Quit();
                Debug.Log("Quit Game");
            }
        }
    
}
