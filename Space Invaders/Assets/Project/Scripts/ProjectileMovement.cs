using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{

    [SerializeField]
    private float _Speed = 5;

    [SerializeField]
    private float _lifeTime = 2f;

    private float _remainingLifeTime;

    private void Start()
    {
        _remainingLifeTime = _lifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * _Speed * Time.deltaTime);
        _remainingLifeTime -= Time.deltaTime;

        if ( _remainingLifeTime < 0 )
        {
            Destroy(gameObject);
        }
    }
}
