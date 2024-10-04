using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyGetFirst : MonoBehaviour
{
    private void Start()
    {
        Trophies.Remove(246728);
        //Trophies.TryUnlock(246728);
    }


}
