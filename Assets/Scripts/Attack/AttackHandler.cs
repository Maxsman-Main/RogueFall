using System.Threading.Tasks;
using UnityEngine;

namespace Attack
{
    public class AttackHandler : MonoBehaviour
    {
        public async void GetDamage()
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            await Task.Delay(100);
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
