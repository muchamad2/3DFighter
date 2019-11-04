using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FighterAcademy
{
    public class AttackDamage : MonoBehaviour
    {
        //select player layer
        public LayerMask layer;
        //area of attack 
        public float radius = 1f;
        //how big the damage
        public float damage = 10f;

        void Update()
        {
            Collider[] hits = Physics.OverlapSphere(transform.position, radius, layer);
            if (hits.Length > 0)
            {
                Debug.Log("Hit damage");
                gameObject.SetActive(false);
            }
        }
    }

}
