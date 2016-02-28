using UnityEngine;
using System.Collections;
using System;
using SharpOSC;

namespace muse_osc_server
{
	public class OSCReader : MonoBehaviour {

		// Use this for initialization
		void Start () {
			// Callback function for received OSC messages. 
			// Prints EEG and Relative Alpha data only.
			HandleOscPacket callback = delegate(OscPacket packet)
			{
				var messageReceived = (OscMessage)packet;
				var addr = messageReceived.Address;

				// RAW EEG
				if(addr == "/muse/eeg") {
					Debug.Log("EEG values: ");
					foreach(var arg in messageReceived.Arguments) {
						Debug.Log(arg + " ");
					}
				}

				// ALPHA
				if(addr == "/muse/elements/alpha_relative") {
					Debug.Log("Relative Alpha power values: ");
					foreach(var arg in messageReceived.Arguments) {
						Debug.Log(arg + " ");
					}
				}

				// GAMMA
				if(addr == "/muse/elements/gamma_relative") {
					Debug.Log("Relative Gamma power values: ");
					foreach(var arg in messageReceived.Arguments) {
						Debug.Log(arg + " ");
					}
				}

				// CONCENTRATION
				if(addr == "/muse/elements/experimental/concentration") {
					Debug.Log("Concentration: ");
					foreach(var arg in messageReceived.Arguments) {
						Debug.Log(arg + " ");
					}
				}

				// MELLOW
				if(addr == "/muse/elements/experimental/mellow") {
					Debug.Log("Mellow: ");
					foreach(var arg in messageReceived.Arguments) {
						Debug.Log(arg + " ");
					}
				}

			};

			// Create an OSC server.
			var listener = new UDPListener(5000, callback);
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}