using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{

    public GUITexture graphic;
    public Texture3D standard;
    public Texture3D downgfx;
    public Texture3D upgfx;
    public Texture3D heldgfx;

    // Use this for initialization
    void Start()
    {
        graphic = GetComponent<GUITexture>();
        graphic.texture = standard;

    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        {
            graphic.texture = downgfx;
        }
        else if (held)
        {
            graphic.texture = heldgfx;
        }
        else if (up)
        {
            graphic.texture = upgfx;
        }
        else
        {
            graphic.texture = standard;
        }

        //guiText.text = " " + down + "\n " + held + "\n " + up;
    }
}
