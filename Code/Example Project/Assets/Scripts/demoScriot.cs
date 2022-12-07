using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoScriot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Demo Project");
		
		int i = 7;
		
		Debug.Log(i.ToString());
		
		double d = 0.3;
		
		Debug.Log(d.ToString());
		
		string s = "Hello World";
		
		Debug.Log(s);
		
		if(i == 10){
			Debug.Log("It is equal to 10");
		}else if(i == 9){
			Debug.Log("It is equal to 9");
		}else{
			Debug.Log("It is not 10 or 9");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
