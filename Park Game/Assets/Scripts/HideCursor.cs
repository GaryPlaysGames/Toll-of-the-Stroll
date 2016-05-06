using UnityEngine;
using System.Collections;

public class HideCursor : MonoBehaviour {

    public bool show_cursor = false;
	
	void Awake ()
    {
        Cursor.visible = show_cursor;
	}

}
