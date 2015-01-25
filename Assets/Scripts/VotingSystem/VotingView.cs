using UnityEngine;
using System.Collections;

public class VotingView : MonoBehaviour
{

    string firstButtonName;
    string secondButtonName;
    string thirdButtonName;
    public Texture buttonTexture;
    int subRectPaddingX, subRectPaddingY;
    int innerButtonPadding;
    float paddingFactorW = 0.075f;
    float paddingFactorH = 0.075f;
    Rect[] buttons;
    public bool enabledButtons = false;


    #region constructors




    #endregion

    #region class functions

    public void assignButtonNames(string n1, string n2, string n3)
    {
        firstButtonName = n1;
        secondButtonName = n2;
        thirdButtonName = n3;

    }



    #endregion


    #region unity functions

    void Awake()
    {
        buttons = new Rect[3];
        int padFactorX = (int)((double)Screen.width * paddingFactorW);

        int padFactorY = (int)((double)Screen.height * paddingFactorH);
        float subRectWidth = Screen.width - padFactorX * 2f;

        float subRectHeight = Screen.height - padFactorY * 2f;
        float miniSubRectangleHeight = subRectHeight / 3f;

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = new Rect(Screen.width * paddingFactorW, padFactorY + miniSubRectangleHeight * i, subRectWidth, miniSubRectangleHeight);

        }

    }


    /// <summary>
    ///   initiaze the inner subrectangle coords
    /// </summary>

    void OnGUI()
    {



#if UNITY_ANDROID

        if (enabledButtons)
        {
            //button 1`
            if (GUI.Button(buttons[0], firstButtonName))
            {
                Debug.Log("vote1");
                SuperDaddy.bucket1++;
                enabledButtons = false;
            }

            //button 2
            if (GUI.Button(buttons[1], secondButtonName))
            {
                Debug.Log("vote2");
                SuperDaddy.bucket2++;
                enabledButtons = false;
            }
            //button 3 
            if (GUI.Button(buttons[2], thirdButtonName))
            {
                Debug.Log("vote2");
                SuperDaddy.bucket3++;
                enabledButtons = false;
            }
#endif

#if UNITY_STANDALONE_WIN
        //do nothing


#endif


        }
    }
    #endregion
    
}