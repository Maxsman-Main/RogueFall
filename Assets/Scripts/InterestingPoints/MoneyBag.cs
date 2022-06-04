using Attack;
using UnityEngine;

namespace InterestingPoints
{
    public class MoneyBag : MonoBehaviour
    {
        [SerializeField] private int _cash;
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out Player player))
            {
                var cash = player.GetComponent<Cash>();
                cash.GetCash(_cash);
                Destroy(gameObject);
            }
        }
    }
}