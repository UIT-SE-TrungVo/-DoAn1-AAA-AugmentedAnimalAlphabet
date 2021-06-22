using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AnimalInfos: MonoBehaviour
{
    string[] animalDescription = null;
    [SerializeField] TextAsset JSONFile;
    Wrapper wrapper = null;
         
    public string GetAnimalInfo(int index)
    {
        //import JSON if this is the first call
        if (wrapper == null)
        {
            if (JSONFile == null)
            {
                Debug.Log("Get data failed");
                return null;
            }
            else
            {
                Debug.Log("OK" + JSONFile.text); 
                wrapper = JsonUtility.FromJson<Wrapper>(JSONFile.text);
                Debug.Log(wrapper.array.Length);
                animalDescription = wrapper.array;
            }
        }
        return wrapper.array[index];
    }

    private class Wrapper
    {
        public string[] array;
    }
}

