using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    private Sprite volumeon;
    public Sprite volumeoff;
    public Button button;
    private bool isOn = true;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        volumeon = button.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = volumeoff;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = volumeon;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
