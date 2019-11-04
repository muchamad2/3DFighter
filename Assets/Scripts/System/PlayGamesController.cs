using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace FighterAcademy
{
    public class PlayGamesController : MonoBehaviour
    {
        public static PlayGamesController Instance;
        // Start is called before the first frame update
        void Start()
        {
            if(Instance == null)
                Instance = this;

          
        }



        public void PostLeaderBoards(long newScore)
        {

        }

        public static void ShowLeaderBoard()
        {
          
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}

