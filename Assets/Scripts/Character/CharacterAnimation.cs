using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FighterAcademy
{
    public class CharacterAnimation : MonoBehaviour
    {
        private Animator anim;
        // Start is called before the first frame update
        void Awake()
        {
            anim = GetComponent<Animator>();
        }
        //trigger animation of every character
        public void Walk(bool walk)
        {
            anim.SetBool(AnimationTags.WALK_PARAMETER, walk);
        }
        public void Defend(bool defend)
        {
            anim.SetBool(AnimationTags.DEFEND_PARAMETER, defend);
        }
        public void Attack_1()
        {
            anim.SetTrigger(AnimationTags.ATTACK_TRIGGER_1);
            anim.ResetTrigger(AnimationTags.ATTACK_TRIGGER_2);
            anim.ResetTrigger(AnimationTags.ATTACK_TRIGGER_3);
        }
        public void Attack_2()
        {
            anim.SetTrigger(AnimationTags.ATTACK_TRIGGER_2);
            anim.ResetTrigger(AnimationTags.ATTACK_TRIGGER_1);
            anim.ResetTrigger(AnimationTags.ATTACK_TRIGGER_3);
        }
        public void Attack_3(){
            anim.SetTrigger(AnimationTags.ATTACK_TRIGGER_3);
            anim.ResetTrigger(AnimationTags.ATTACK_TRIGGER_1);
            anim.ResetTrigger(AnimationTags.ATTACK_TRIGGER_2);
        }
        void FreezeAnimation()
        {
            anim.speed = 0.1f;
        }
        public void UnFreezeAnimation()
        {
            anim.speed = 1f;
        }
    }

}
