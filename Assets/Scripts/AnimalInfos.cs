using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

static public class AnimalInfos
{
    static string[] animalDescription = { };
    static string JSONFilePath = "animalDescription.json";
         
    static public string GetAnimalInfo(int index)
    {
        //import JSON if this is the first call
        if (animalDescription.Length == 0)
        {
            TextAsset data = Resources.Load<TextAsset>(JSONFilePath);
            Debug.Log(data.text);
            Wrapper wrapper = JsonUtility.FromJson<Wrapper>(data.text);
            animalDescription = wrapper.array;
        }

        return animalDescription[index];
    }

    private class Wrapper
    {
        public string[] array;
    }
}

