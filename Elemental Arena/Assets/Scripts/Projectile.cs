using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private string projectileElement;
    [SerializeField] private string element;
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject mainProjectile;

    public float speed = 40.0f;

    private float bound = 300;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProjectileType();
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > bound || transform.position.z < -bound || transform.position.x > bound || transform.position.x < -bound || transform.position.y > bound || transform.position.y < -bound)
        {
            Destroy(mainProjectile.gameObject);
        }
    }

    public void ProjectileType()
    {
        if (PlayerPrefs.HasKey("staffChouse"))
        {
            element = PlayerPrefs.GetString("staffChouse");
        }
        else
        {
            element = "frost";
        }
        LoadProjectile();
    }

    public void LoadProjectile()
    {
        if (element == projectileElement)
        {
            projectile.SetActive(true);
        }
        else
        {
            projectile.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(mainProjectile);
    }
}
