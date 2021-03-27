using UnityEngine;

public class SwitchKakahenTurretController : MonoBehaviour
{
    public GameObject kakahenControllerMobile;
    public GameObject turretControllerMobile;
    public GameObject kakahenCamera;
    public GameObject buttonFire;
    public GameObject rightJoystick;

    private bool enableKakahenControl = false;

    void Start()
    {
        enableKakahenControl = false;
        Switch();
    }

    public void Switch()
    {
        enableKakahenControl = !enableKakahenControl;
        turretControllerMobile.SetActive(!enableKakahenControl);
        buttonFire.SetActive(!enableKakahenControl);
        rightJoystick.SetActive(!enableKakahenControl);

        kakahenCamera.SetActive(enableKakahenControl);
        kakahenControllerMobile.SetActive(enableKakahenControl);
    }

}
