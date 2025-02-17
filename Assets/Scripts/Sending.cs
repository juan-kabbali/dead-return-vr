using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;
using System;

public class Sending : MonoBehaviour
{

	string shoot = "";
	string textMobile = "" ; // shoot, pitch, roll
	public static float pitch = 0; // eje y
	public static float roll = 0; // eje x
	char[] delimiterChars = { ';' };

	void Start ()
	{
		connectBT ();

	}

	void Update ()
	{
		ReadFromMobile ();
		validarTriggerArduinoToUnity ();
		//interpretarPitchRoll ();

	}

	void OnApplicationQuit ()
	{
		BtConnector.close ();
	}

	public static void sendVibration ()
	{

		if (BtConnector.isConnected ()) {

			BtConnector.sendChar ('1');
			BtConnector.sendChar ('\n');

		}
		    	
	}

	void validarTriggerArduinoToUnity ()
	{
							
			switch (shoot) {

			case "r":
				Player.isShoot = false;
				break;
			case "s":
				Player.isShoot = true;
				break;

			}
			

	}
	//validador del interruptor con BT





	void connectBT ()
	{

		BtConnector.moduleName ("HC-06");
		BtConnector.connect ();

	}




	/*void interpretarPitchRoll(){

		if(BtConnector.isConnected()){
			string tmp = "";
			tmp =  BtConnector.readLine ();

			switch(shoot){

			case "r":
				Player.isShoot	 = false;
				break;
			case "s":
				Player.isShoot	 = true;
				break;

			}

		}

	}*/
		
void StringTreatment(){
		
	    string[] words = textMobile.Split(delimiterChars);
			
		shoot = words [0];
		pitch = Convert.ToSingle(words [1]);
		roll = Convert.ToSingle(words [2]);

				}

	void ReadFromMobile(){
	
		if (BtConnector.isConnected ()) {

			textMobile = BtConnector.readLine ();
			StringTreatment ();
    		}
	}




}








  
