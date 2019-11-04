using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FighterAcademy
{
    //class of player attack controller
    public class PlayerAttack : MonoBehaviour
    {
        CharacterAnimation playerAnimation;
        public GameObject attackPoint;
        private PlayerShield shield;
        private CharacterSoundFX soundFX;

        public bool isAttack;
        private bool firstAttack = false;
        private bool secondAttack = false;
        private bool thirdAttack = false;

        public JoystickButton joyButton;
        // Start is called before the first frame update
        void Awake()
        {
            playerAnimation = GetComponent<CharacterAnimation>();
            // shield = GetComponent<PlayerShield>();
            //soundFX = GetComponentInChildren<CharacterSoundFX>();

        }
        private void Start()
        {
            //            joyButton = FindObjectOfType<JoystickButton>();
            isAttack = false;
        }
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                playerAnimation.Defend(true);
                shield.ActiveShield(true);
            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                playerAnimation.UnFreezeAnimation();
                playerAnimation.Defend(false);

                shield.ActiveShield(false);
            }
            if (Input.GetKeyDown(KeyCode.K) && isAttack == false)
            {
                if (!firstAttack)
                {
                    playerAnimation.Attack_1();
                    firstAttack = true;
                }
                else if (secondAttack == false && firstAttack)
                {
                    playerAnimation.Attack_2();
                    secondAttack = true;
                }
                else if (thirdAttack == false && secondAttack && firstAttack)
                {
                    playerAnimation.Attack_3();
                    thirdAttack = true;
                }
                StartCoroutine(backtoAttack());
                isAttack = true;
            }
            else
            {
                isAttack = false;
            }
        }
        void FixedUpdate()
        {

        }
        IEnumerator backtoAttack()
        {
            yield return new WaitForSeconds(1.0f);
            firstAttack = false;
            secondAttack = false;
            thirdAttack = false;
        }
        void ActivateAttack()
        {
            attackPoint.SetActive(true);
        }
        void DeactivateAttack()
        {
            if (attackPoint.activeInHierarchy)
            {
                attackPoint.SetActive(false);

            }

        }


    }
}

