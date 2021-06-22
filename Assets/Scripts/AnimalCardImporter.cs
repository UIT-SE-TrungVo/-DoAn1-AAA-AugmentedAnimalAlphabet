using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnimalCardImporter : MonoBehaviour
{
    [SerializeField] Sprite[] arrCards;
    //GameObject[] uiButton;

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
            int index = i;
            uiButton.GetComponent<Button>().onClick.AddListener(() => { ViewInfoScreen(index); });
        }
    }

    void ViewInfoScreen(int index)
    {
        Debug.Log("Request index" + index);
        ChosenAnimal.Index = index;
        SceneManager.LoadScene("AnimalInfo");
    }
}
