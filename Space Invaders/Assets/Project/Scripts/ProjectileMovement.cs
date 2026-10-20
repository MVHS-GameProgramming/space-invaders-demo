using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{

    [SerializeField]
    private float _Speed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * _Speed * Time.deltaTime);
    }
}
