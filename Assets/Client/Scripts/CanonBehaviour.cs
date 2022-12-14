using UnityEngine;
using UnityEngine.UI;

public class CanonBehaviour : MonoBehaviour
{

    public static float _canonPower = 4;
    [SerializeField] private Slider _canonPowerSlider;


    private void Awake()
    {
        _canonPower = 4;
    }

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
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && _canonPower < 15)
            {
                _canonPower += 0.5f;
            }
            if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && _canonPower > 4)
            {
                _canonPower -= 0.5f;
            }     
    }

}
