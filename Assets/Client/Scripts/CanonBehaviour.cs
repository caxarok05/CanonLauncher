using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanonBehaviour : MonoBehaviour
{

    public static float _canonPower = 0;
    [SerializeField] private Slider _canonPowerSlider;



    private void Update()
    {
        _canonPowerSlider.value = _canonPower;
        TurningCanon();
        IncreaseCanonPower();
    }

    private void TurningCanon()
    {
        if (transform.rotation.z <= 40 || transform.rotation.z >= -45)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 50.0f), Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, -50.0f), Time.deltaTime);
            }
        }

    }

    private void IncreaseCanonPower()
    {
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && _canonPower < 100)
            {
                _canonPower += 5;
            }
            if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && _canonPower > 0)
            {
                _canonPower -= 5;
            }     
    }

}
