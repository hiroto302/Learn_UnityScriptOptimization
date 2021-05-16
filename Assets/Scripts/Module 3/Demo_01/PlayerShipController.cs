using UnityEngine;

public class PlayerShipController : MonoBehaviour
{
    private ObjectPool objectPool;
    private Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;

        objectPool = GetComponent<ObjectPool>();

        InvokeRepeating("Shoot", .33f, .33f);
    }

    void Shoot()
    {
        // Instantiate(bulletPrefab, myTransform.position, Quaternion.identity);

        // 事前に生成された object を呼び出す
        GameObject bullet = objectPool.GetAvailableObject();
        bullet.transform.position = myTransform.position;
        bullet.SetActive(true);
    }
}
