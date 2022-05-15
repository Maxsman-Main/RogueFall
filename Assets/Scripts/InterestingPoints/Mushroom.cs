using Attack;
using UnityEngine;

namespace InterestingPoints
{
    public class Mushroom : MonoBehaviour
    {
        [SerializeField] private int _healthPower;
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out Player player))
            {
                var health = player.GetComponent<Health>();
                health.UpHealth(_healthPower);
                Destroy(gameObject);
            }
        }
    }
}