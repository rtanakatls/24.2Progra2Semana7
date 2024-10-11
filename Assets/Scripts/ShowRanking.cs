using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRanking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameJoltUI.Instance.ShowLeaderboards();
    }
}
