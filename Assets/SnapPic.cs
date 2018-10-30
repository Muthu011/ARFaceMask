using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SnapPic : MonoBehaviour
{
    private int num = 0;
    private int picNum = 1;
    public GameObject glass;
    public GameObject mask;

    public void TakePic()
    {
        picNum += num;
        ScreenCapture.CaptureScreenshot(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments),"IMG.png"));
        Debug.Log("screenShot Taken");
    }
    public void choosingSpecs()
    {
        glass.SetActive(true);
        mask.SetActive(false);

    }
    public void choosingmask()
    {
        glass.SetActive(false);
        mask.SetActive(true);

    }


}
