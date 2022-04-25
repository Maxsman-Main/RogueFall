using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{ 
   private List<PlayerParameter> _parameters;

   public List<PlayerParameter> Parameters => _parameters;

   private void Start()
   {
      _parameters.Add(new PlayerParameter("Health", 10));
      _parameters.Add(new PlayerParameter("Attack", 10));
   }
}
