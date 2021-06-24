using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSelector : MonoBehaviour
{
    [SerializeField] Material[] background;
    int index = -1;

    //0 desert
    //1 jungle
    //2 sea
    int[] binding =
    {
        0//A
        ,1//B
        ,1//C
        ,2//D
        ,0//E
        ,1//F
        ,1//G
        ,0//H
        ,0//I
        ,0//J
        ,0//K
        ,0//L
        ,1//M
        ,1//N
        ,0//O
        ,1//P
        ,1//Q
        ,1//R
        ,2//S
        ,2//T
        ,1//U
        ,1//V
        ,2//W
        ,2//X
        ,0//Y
        ,0//Z
    };

    // Start is called before the first frame update
    void Start()
    {
        index = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (index != ChosenAnimal.Index)
        {
            index = ChosenAnimal.Index;
            int newValue = binding[index];
            Material newMat = background[newValue];
            this.GetComponent<MeshRenderer>().material = newMat;
        }
    }
}
