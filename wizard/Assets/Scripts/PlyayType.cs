using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlyayType : MonoBehaviour {

    [SerializeField]
    private Image oneperson;

    [SerializeField]
    private Image everyone;

    private Vector3 nomalScal;

    private bool scalingImage;

    private bool scalingUpDownFlag;

    [SerializeField]
    private float maxScal = 1.5f;

    [SerializeField]
    private float minScal = 0.5f;

    // Use this for initialization
    void Start () {

        scalingUpDownFlag = true;
        scalingImage = true;
        nomalScal = new Vector3(1.0f, 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.UpArrow)) {

            scalingImage = true;
            everyone.gameObject.transform.localScale = nomalScal;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {

            scalingImage = false;
            oneperson.gameObject.transform.localScale = nomalScal;
        }


        if (scalingImage) {

            ScalingCange(oneperson);

            if (scalingUpDownFlag) {

                ScalingUpImage(oneperson);
            }

            else {

                ScalingDownImage(oneperson);
            }

        }

        else {

            ScalingCange(everyone);

            if (scalingUpDownFlag)
            {

                ScalingUpImage(everyone);
            }

            else
            {

                ScalingDownImage(everyone);
            }
        }

    }

    void ScalingUpImage(Image image){

        Vector3 scal = image.gameObject.transform.localScale;

        scal.Set(scal.x + 0.01f, scal.y + 0.01f, scal.z + 0.01f);

        image.gameObject.transform.localScale = scal;
    }

    void ScalingDownImage(Image image)
    {

        Vector3 scal = image.gameObject.transform.localScale;

        scal.Set(scal.x - 0.01f, scal.y - 0.01f, scal.z - 0.01f);

        image.gameObject.transform.localScale = scal;
    }

    void ScalingCange(Image image){

        if (image.transform.localScale.x >= maxScal) {

            scalingUpDownFlag = false;
        }
        else if(image.transform.localScale.x <= minScal){

            scalingUpDownFlag = true;
        }
    }
}
