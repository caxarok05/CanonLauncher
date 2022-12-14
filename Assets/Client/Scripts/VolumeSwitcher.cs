using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSwitcher : MonoBehaviour
{
    [SerializeField] private Sprite _volumeOffSprite;
    [SerializeField] private Sprite _volumeOnSprite;

    public void SwitchVolume(Image image)
    {
        if (image.sprite == _volumeOnSprite)
        {
            image.sprite = _volumeOffSprite;
        }
        else if (image.sprite == _volumeOffSprite)
        {
            image.sprite = _volumeOnSprite;
        }

    }
}
