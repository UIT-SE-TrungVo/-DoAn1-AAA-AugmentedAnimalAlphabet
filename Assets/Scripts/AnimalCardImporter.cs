using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalCardImporter : MonoBehaviour
{
    [SerializeField] Sprite[] arrCards;

    // Start is called before the first frame update
    void Start()
    {
        CreateAlphabet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateAlphabet()
    {
        for (int i=0; i<arrCards.Length; i++)
        {
            Sprite card = arrCards[i];
            DefaultControls.Resources uiResources = new DefaultControls.Resources();
            uiResources.standard = card;
            GameObject uiButton = DefaultControls.CreateButton(uiResources);
            uiButton.transform.SetParent(this.transform);
            uiButton.GetComponentInChildren<Text>().text = "";
            uiButton.GetComponent<Button>().onClick.AddListener(() => DisplayInfoScreen(i));
        }
    }

    void DisplayInfoScreen(int index)
    {
        Debug.Log(AnimalInfos.GetAnimalInfo(index));
    }
}
