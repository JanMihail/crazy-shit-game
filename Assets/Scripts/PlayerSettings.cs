using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Настройки игрока
/// </summary>
public class PlayerSettings : MonoBehaviour
{
    /// <summary>
    /// Длина игрока
    /// </summary>
    [SerializeField] private int length;

    public int Length
    {
        get => length;
        set { length = value; }
    }
}
