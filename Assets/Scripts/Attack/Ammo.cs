using System;
using UnityEngine;

namespace Attack
{
    public class Ammo : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void FixedUpdate()
        {
            transform.position += new Vector3(_speed * -1 * gameObject.transform.localScale.x, 0, 0);
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            var target = col.gameObject.GetComponent<AttackHandler>();
            if (target != null)
            {
                target.GetDamage();
            }
            Destroy(gameObject);
        }
    }
}