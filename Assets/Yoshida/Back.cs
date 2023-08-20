using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    [SerializeField] GameObject _back = null;

    public void BACK()
    {
        _back.SetActive(false);
    }
}
