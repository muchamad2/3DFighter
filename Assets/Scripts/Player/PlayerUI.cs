using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FighterAcademy
{
    public class PlayerUI : MonoBehaviour
    {
        #region Private Field
        [SerializeField]
        private Text playerNameText;

        [SerializeField]
        private Slider playerHealthSlider;

      

        float characterControlHeight = 0f;
        Transform targetTransform;
        Renderer targetRenderer;
        Vector3 targetPosition;
        #endregion

        #region Public Field
        [SerializeField]
        private Vector3 screenOffset = new Vector3(0f, 30f, 0f);
        #endregion

        #region Monobehaviour Callbacks
        private void Awake()
        {
            this.transform.SetParent(GameObject.Find("UI Canvas").GetComponent<Transform>(), false);
        }
        private void Update()
        {
           
        }
        private void LateUpdate()
        {
            if(targetRenderer != null)
            {
                this.gameObject.SetActive(targetRenderer.isVisible);
            }
            if(targetTransform != null)
            {
                targetPosition = targetTransform.position;
                targetPosition.y += characterControlHeight;
                this.transform.position = Camera.main.WorldToScreenPoint(targetPosition) + screenOffset;

            }
        }
        #endregion

    }
}

