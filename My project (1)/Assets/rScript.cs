using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rScript : MonoBehaviour
{
    string heroname = "edward";
    float heroheight = 1.89f;
    int heroage = 35;
    string heropower = "superstrangth";
    string villianname = "jack";
    float villianheight = 2.10f;
    int villianage = 40;
    string villianpower = "none";


    // Start is called before the first frame update
    void Start()
    {
        print("the hero name is" + heroname + "the hero height is" + (heroheight+5) + "the hero age is" + heroage + "the hero power is" + heropower);
        print("the villian name is" + villianname + "the villian height is" + villianheight + "the villian age is" + villianage + "the villian power is" + villianpower);
        int agediffernce = villianage - heroage;
        print("the age differnce is" + agediffernce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
