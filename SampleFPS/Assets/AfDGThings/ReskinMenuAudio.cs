using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReskinMenuAudio : MonoBehaviour
{
    public FMODReferences fmodRefs;
       
    public static ReskinMenuAudio instance;

    string fmodMasterBusString = "bus:/";
    FMOD.Studio.Bus masterBus;

    private void Awake()
    {
        instance = this;

        masterBus = FMODUnity.RuntimeManager.GetBus(fmodMasterBusString);
    }

    public void StopAudio()
    {
        masterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    public void PlaySelectSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(fmodRefs.SelectOption);
    }

    public void PlayGameStart()
    {
        FMODUnity.RuntimeManager.PlayOneShot(fmodRefs.StartGame);
    }
}
