using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Attack
{
    public class AttackHandler : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out AttackPlace attackPlace))
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
        
        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out AttackPlace attackPlace))
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }
}
