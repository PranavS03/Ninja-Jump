using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;






public class NextWindow2 : MonoBehaviour
{

    private void Awake(){
       

        transform.Find("Menu").GetComponent<Button_UI>().ClickFunc = () => { UnityEngine.SceneManagement.SceneManager.LoadScene("Levels"); };
        transform.Find("Next").GetComponent<Button_UI>().ClickFunc = () => { UnityEngine.SceneManagement.SceneManager.LoadScene("Level2"); };
        
        }

   
    
}
