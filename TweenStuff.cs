using UnityEngine;
using System.Collections;

public class TweenStuff : MonoBehaviour {

    public float tweenTime;
    private RayMarching manager;
	// Use this for initialization
	void Start () {
        manager = GetComponent<RayMarching>();
        Hashtable ht = iTween.Hash("from", 0, "to", 99.0f, "time", tweenTime, "onupdate", "TweenX", "easetype", iTween.EaseType.easeInOutSine, "looptype", iTween.LoopType.pingPong);
        iTween.ValueTo(gameObject, ht);
	}

    // helepr

    void TweenX(float x)
    {
        manager.setClipDimension(x);
    }
}
