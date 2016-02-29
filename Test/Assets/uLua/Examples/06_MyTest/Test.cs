using UnityEngine;
using System.Collections;
using LuaInterface;

public class Test : MonoBehaviour {

	public TextAsset testScript;
	private const string script=@"
            function mytest(message)
              print(message)
              return 100
            end
          ";
	// Use this for initialization
	void Start () {
	
		LuaState l = new LuaState ();
		l.DoString (script);
		var func = l.GetFunction ("mytest");
	    var r=	func.Call ("this is my test for ulua");
		print (r [0]);

		print ("通过脚本调用");

		l.DoString (testScript.text);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
