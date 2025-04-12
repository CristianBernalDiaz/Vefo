using System;
using UnityEngine;

public class Dance : MonoBehaviour
{
 [SerializeField]
 private string [] danceNames;
 [SerializeField]
 private string[] songNames;
 [SerializeField]
 private Animator character;
 private int currentDanceIndex =0;

 public void PlayNextDance()
 {
    SoundManager.instance.PlayMusic(songNames[currentDanceIndex]);
    character.Play(danceNames[ currentDanceIndex]);
    currentDanceIndex++;
    if (currentDanceIndex >= danceNames.Length)
    {
        currentDanceIndex = 0;
    }
 }

   public void StopMusic()
   {
        SoundManager.instance.StopMusic();
   }
}