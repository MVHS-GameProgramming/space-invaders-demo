using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFire : MonoBehaviour
{
    [SerializeField]
    private GameObject _projectilePrefab;

    [SerializeField]
    private Transform _firePoint;


    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            fireProjectile();
        }        
    }

    private void fireProjectile()
    {
        GameObject projectile = Instantiate<GameObject>(_projectilePrefab, _firePoint.position, Quaternion.identity);
    }
}
