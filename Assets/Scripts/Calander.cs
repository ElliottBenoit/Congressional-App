using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Calander : MonoBehaviour
{
    //GameObjects.
    GameObject canvas;
    public GameObject octoberPrefab;
    public GameObject novemberPrefab;
    public GameObject decemberPrefab;

    //Variables.
    Dropdown dropdown;
    int dropdownValue;
    string numStr;
    string numTag;

    GameObject[] descriptions;

    GameObject ED;          //Election Date
    GameObject DP;          //Deadline: Propositions
    GameObject IPBMRD;      //In Person/By Mail Registration Deadline
    GameObject GVORD;       //Geaux Vote Online Registration Deadline
    GameObject DRMBR;       //Deadline to Request a Mail Ballot from Registrar
    GameObject DRRVMB;      //Deadline for Registrar to Receive Voted Mail Ballot
    GameObject EVB;         //Early Voting Begins
    GameObject EVE;         //Early Voting Ends

    GameObject OP;          //Open Primary
    GameObject OG;          //Open General


    //Declares dropdown and instantiates current month.
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        dropdown = GetComponent<Dropdown>();

        OP = GameObject.Find("OP");
        OG = GameObject.Find("OG");

        //Disable text discriptions.
        descriptions = GameObject.FindGameObjectsWithTag("Description");
        foreach (GameObject description in descriptions)
        {
            description.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }
        OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    }

    //When month changes, instantiates new month.
    public void NewMonth()
    {
        dropdownValue = dropdown.value;

        if (dropdownValue == 0)
        {
            Destroy(GameObject.FindWithTag("Month"));
            October();
        }
        if (dropdownValue == 1)
        {
            Destroy(GameObject.FindWithTag("Month"));
            November();
        }
        if (dropdownValue == 2)
        {
            Destroy(GameObject.FindWithTag("Month"));
            December();
        }
    }
    
    //Instantiation.
    public void October()
    {
        GameObject month = Instantiate(octoberPrefab, new Vector3(360, 540, 0), Quaternion.identity) as GameObject;
        month.transform.parent = canvas.transform;
    }
    public void November()
    {
        GameObject month = Instantiate(novemberPrefab, new Vector3(360, 540, 0), Quaternion.identity) as GameObject;
        month.transform.parent = canvas.transform;
    }
    public void December()
    {
        GameObject month = Instantiate(decemberPrefab, new Vector3(360, 540, 0), Quaternion.identity) as GameObject;
        month.transform.parent = canvas.transform;
    }






    //Pressing a date, selects that dates info and activates it.
    public void Date()
    {
        numStr = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log("numStr " + numStr);
        numTag = EventSystem.current.currentSelectedGameObject.tag;
        Debug.Log("numTag " + numTag);


        if (numTag == "October")
        {
            foreach (GameObject description in descriptions)
            {
                description.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            }
            OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

            if (numStr == "Button9")
            {
                IPBMRD = GameObject.Find("OP/IPBMRD");
                OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                IPBMRD.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button15")
            {
                DP = GameObject.Find("OG/DP");
                OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                DP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button16")
            {
                GVORD = GameObject.Find("OP/GVORD");
                OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                GVORD.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button23")
            {
                EVB = GameObject.Find("OP/EVB");
                OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                EVB.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button30")
            {
                EVE = GameObject.Find("OP/EVE");
                OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                EVE.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
        }
        if (numTag == "November")
        {
            foreach (GameObject description in descriptions)
            {
                description.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            }
            OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

            if (numStr == "Button2")
            {
                DRMBR = GameObject.Find("OP/DRMBR");
                OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                DRMBR.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button5")
            {
                DRRVMB = GameObject.Find("OP/DRRVMB");
                OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                DRRVMB.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button6")
            {
                ED = GameObject.Find("OP/ED");
                OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                ED.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button7")
            {
                IPBMRD = GameObject.Find("OG/IPBMRD");
                OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                IPBMRD.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button17")
            {
                GVORD = GameObject.Find("OG/GVORD");
                OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                GVORD.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button24")
            {
                EVB = GameObject.Find("OG/EVB");
                OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                EVB.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
        }
        if (numTag == "December")
        {
            foreach (GameObject description in descriptions)
            {
                description.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            }
            OP.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

            if (numStr == "Button1")
            {
                EVE = GameObject.Find("OG/EVE");
                OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                EVE.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button4")
            {
                DRMBR = GameObject.Find("OG/DRMBR");
                OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                DRMBR.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button7")
            {
                DRRVMB = GameObject.Find("OG/DRRVMB");
                OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                DRRVMB.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (numStr == "Button8")
            {
                ED = GameObject.Find("OG/ED");
                OG.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                ED.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
        }
    }
}
