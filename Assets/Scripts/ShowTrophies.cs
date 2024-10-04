using GameJolt.API;
using GameJolt.API.Objects;
using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTrophies : MonoBehaviour
{
    void Start()
    {
        GameJoltUI.Instance.ShowTrophies();
    }

}
