using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _initialScale = 1;

    private void Update()
    {
        var scale = transform.localScale;

        scale.x += _speed;
        scale.y += _speed;
        scale.z += _speed;

        transform.localScale = scale;
    }
}
