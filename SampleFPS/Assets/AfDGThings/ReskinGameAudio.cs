using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this is our main switchboard for handling fmod events
//I've also made use of the FMODEmitter game components 
//these can be helpful for things like ambiences or other loops

//the FMODEmitter can also be helpful to bridge the gap between fmod and Unity by keeping things on a component basis,
//otherwise it's easy to have sounds play across scene changes (the FMOD engine doesn't know about scenes!!!)  
public class ReskinGameAudio : MonoBehaviour
{

    //usually very helpful to have a reference to the master bus, to stop all sounds when needed

    string fmodMasterBusString = "bus:/";
    FMOD.Studio.Bus masterBus;

    public static ReskinGameAudio instance;

    public FMODReferences audioRefs;


    private void Awake()
    {

        instance = this;

    }

    void Start()
    {
        masterBus = FMODUnity.RuntimeManager.GetBus(fmodMasterBusString);

    }

    public void StopAllSounds()
    {
        masterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
}
