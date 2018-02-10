using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetFinder : IUserDefinedTargetEventHandler {

	// Use this for initialization
	void OnInitialized() {
		Debug.Log("initialization");
	}
	
	// Update is called once per frame
	void OnFrameQualityChanged(ImageTargetBuilder.FrameQuality frameQuality() {
		Debug.Log("frame quality changed");
	}

	void OnNewTrackableSource(TrackableSource trackableSource){
		Debug.Log("on new trackable source");
	}
}
