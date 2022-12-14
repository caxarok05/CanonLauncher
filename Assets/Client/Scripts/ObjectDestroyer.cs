using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] private BulletCountScript bulletCountScript;
    [SerializeField] private string Tag;
    private void Update()
    {

        if (GameObject.FindWithTag(Tag) != null && GameObject.FindWithTag(Tag).transform.position.y < -10 )
        {
            Destroy(GameObject.FindWithTag(Tag));
            bulletCountScript._bulletCount -= 1;
        }
    }
}
