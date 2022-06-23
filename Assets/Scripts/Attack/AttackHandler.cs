using System.Threading.Tasks;
using UnityEngine;

namespace Attack
{
    [RequireComponent(typeof(Health))]
    public class AttackHandler : MonoBehaviour
    {
        public async void GetDamage(float damage)
        {
            DamagePopup.Create(gameObject.transform.position + new Vector3(0.5f, 0, 0), (int)damage);
            if (gameObject.GetComponent<SpriteRenderer>() != null)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }

            await Task.Delay(100);
            
            if (gameObject.GetComponent<SpriteRenderer>() != null)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            }
            
            var health = gameObject.GetComponent<Health>();
            health.GetDamage(damage); 
        }
    }
}
