using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadInfo : MonoBehaviour
{
    int curIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChosenAnimal.Index != curIndex)
        {
            curIndex = ChosenAnimal.Index;
            this.GetComponentInChildren<Text>().text = this.GetComponent<AnimalInfos>().GetAnimalInfo(curIndex);
        }
    }
}
