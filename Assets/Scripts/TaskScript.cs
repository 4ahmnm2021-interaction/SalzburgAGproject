using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskScript : MonoBehaviour
{
    public Image checkBox;
    public Sprite checkedSprite;
    public Sprite uncheckedSprite;
    public Text information;
    public bool Checked;
    public string displayText;

    void Start() {
        information.text = displayText;  
    }
    public void Toggle()
    {
        if (checkBox.sprite == uncheckedSprite)
        {
            checkBox.sprite = checkedSprite;
            Checked = true;
            Debug.Log("Check");
        }
        else if (Checked == true)
        {
            checkBox.sprite = uncheckedSprite;
            Debug.Log("unCheck");
        }
    }
}
