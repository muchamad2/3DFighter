using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace FighterAcademy
{
    public class GameManager : MonoBehaviour
    {
  



        #region Singeleton
        public static GameManager Instance;

        void Start()
        {
            if(Instance == null)
            {
                Instance = this;
                
            }
            

        }
        // Start is called before the first frame update
        #endregion

        void Awake()
        {

        }
        public void Win(long score)
        {
            
            PlayGamesController.Instance.PostLeaderBoards(score);
            LeaveRoom();
        }
        public void Lose()
        {
            LeaveRoom();
        }
        
        public void LeaveRoom()
        {
 
        }
    }

}
