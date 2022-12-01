using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _vectorStart;
    [SerializeField] private Transform _vectorEnd;
 

    private GameObject _bullet;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateBullet();
            _bullet.GetComponent<Rigidbody2D>().AddForce((_vectorStart.position - _vectorEnd.position) * CanonBehaviour._canonPower ,ForceMode2D.Impulse);
            
        }
    }

    private void CreateBullet()
    {
        _bullet = Instantiate(_bulletPrefab, gameObject.transform.position, Quaternion.identity);
    }

}
