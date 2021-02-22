using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    [SerializeField] private int length;
    [SerializeField] private bool lightOn;

    public int Length
    {
        get => length;
        set { length = value; }
    }

    public bool LightOn
    {
        get => lightOn;
        set { lightOn = value; }
    }
}
