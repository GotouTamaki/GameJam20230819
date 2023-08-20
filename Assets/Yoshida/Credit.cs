using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{
    [SerializeField] GameObject _back = null;

    public void hyouzi()
    {
        _back.SetActive(true);
    }

}
