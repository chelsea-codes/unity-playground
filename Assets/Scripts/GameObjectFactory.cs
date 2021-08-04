using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectFactory<T> : MonoBehaviour where T : MonoBehaviour
{

    //https://forum.unity.com/threads/create-new-class-or-gameobject-here.1083629/

    public static T Create()
    {
        GameObject go = new GameObject();

        //TODO awake is called at this point, so don't put intialization in Awake in the subclasses
        return go.AddComponent<T>();
    }
}