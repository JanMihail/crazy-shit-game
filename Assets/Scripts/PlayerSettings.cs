using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    [SerializeField] private int length;

    public int Length
    {
        get => length;
        set { length = value; }
    }
}
