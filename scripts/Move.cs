using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{ 
    [SerializeField] private float _speed;
    [SerializeField] Transform[] _wayPoints;

    private int _currentWayPointPosition = 0;

    private void Update()
    {
        if (transform.position == _wayPoints[_currentWayPointPosition].position)
        {
            _currentWayPointPosition = (_currentWayPointPosition + 1) % _wayPoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentWayPointPosition].position, _speed * Time.deltaTime);
    }
}
