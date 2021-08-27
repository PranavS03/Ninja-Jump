using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;






public class GameOverWindow : MonoBehaviour
{

    private void Awake(){
       

        transform.Find("Menu").GetComponent<Button_UI>().ClickFunc = () => { UnityEngine.SceneManagement.SceneManager.LoadScene("Levels"); };
        transform.Find("Retry").GetComponent<Button_UI>().ClickFunc = () => { UnityEngine.SceneManagement.SceneManager.LoadScene("Level1"); };
        
        }

   
    
}
