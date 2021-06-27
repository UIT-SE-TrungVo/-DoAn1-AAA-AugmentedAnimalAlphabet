using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelMove : MonoBehaviour
{
    Vector2 destination = new Vector2(0,0);
    [SerializeField] Text uiText;
    int speed = 1248;

    float[] OFFSET = { 0, 1920 };
    int index = 0;
    float curOffset = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (curOffset != 0)
        {
            float offset = Mathf.Min(Mathf.Abs(curOffset), speed * Time.deltaTime) * (curOffset < 0 ? -1 : 1);
            curOffset -= offset;
            this.GetComponent<RectTransform>().Translate(Vector3.right * offset);
        }
        if (index != 0)
        {
            uiText.text = "SHOW ANIMAL INFO";
        }
        else
        {
            uiText.text = "HIDE";
        }
    }

    public void changeOffset()
    {
        index = 1 - index;
        curOffset = OFFSET[index] - this.GetComponent<RectTransform>().localPosition.x;
        Button button = this.GetComponentInParent<Button>();
    }
}
