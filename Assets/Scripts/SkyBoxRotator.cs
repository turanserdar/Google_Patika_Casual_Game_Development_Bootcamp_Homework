using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRotator : MonoBehaviour
{

    //skyboxin hizini ayarlamak icin
    public int speed;

    void FixedUpdate()
    {
        

        //Render settings teki skyboxtaki bir floati ayarla diyorum
        // ismi de Rotation Time.time diyerek zamanla dogru orantili olacak sekilde rotationi ilerletiyorum
        //Speed ile carparak benim girdigim bir degerde donmus olacak
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*speed);
        
    }

}
