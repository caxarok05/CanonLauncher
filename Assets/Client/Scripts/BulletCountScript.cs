using UnityEngine;
using UnityEngine.UI;

public class BulletCountScript : MonoBehaviour
{
    
    [SerializeField] private Text _bulletCountText;

    public int _bulletCount;

    private void Update()
    {
        _bulletCountText.text = _bulletCount.ToString();
    }

}
