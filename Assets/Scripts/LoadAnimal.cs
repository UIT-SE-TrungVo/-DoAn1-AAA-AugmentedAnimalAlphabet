using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAnimal : MonoBehaviour
{
    [SerializeField] GameObject[] animal;
    [SerializeField] int index = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index != ChosenAnimal.Index)
        {
            index = ChosenAnimal.Index;
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Animal"))
            {
                Destroy(obj.gameObject);
            }
            GameObject newAnimal = Instantiate(animal[index], this.transform.position, Quaternion.identity, this.transform);
        }
    }
}
