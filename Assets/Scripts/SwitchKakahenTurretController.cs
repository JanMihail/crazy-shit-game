using UnityEngine;

public class SwitchKakahenTurretController : MonoBehaviour
{
    public GameObject kakahenControllerMobile;
    public GameObject turretControllerMobile;
    public GameObject kakahenCamera;
    public GameObject turret;
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
        turret.SetActive(!enableKakahenControl);

        kakahenCamera.SetActive(enableKakahenControl);
        kakahenControllerMobile.SetActive(enableKakahenControl);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
