using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;

    private void Update()
    {
        if(_target == null)
        {
            return;
        }

        transform.LookAt(_target, transform.up);
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    public void SetTarget(Player target)
    {
        _target = target.transform;
    }

    public void TakeDamage()
    {
        Destroy(gameObject);
    }
}
