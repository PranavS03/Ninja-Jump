using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class  SoundManager 
{
    public static void playjump(){
        GameObject gameObject=new GameObject("Sound",typeof(AudioSource));
        AudioSource audioSource=gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().jump);

    }
    public static void playvictory(){
        GameObject gameObject=new GameObject("Sound",typeof(AudioSource));
        AudioSource audioSource=gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().victory);

    }


}
