using UnityEngine;
using System.Collections;

public class CustomRandomMatchMaker : MonoBehaviour {
	private PhotonView myPhotonView;
	public Transform TroupLeader;
	
	// Use this for initialization
	void Start()
	{
		PhotonNetwork.ConnectUsingSettings("0.1");
	}
	
	void OnJoinedLobby()
	{
		Debug.Log("JoinRandom");
		PhotonNetwork.JoinRandomRoom();
	}
	
	void OnPhotonRandomJoinFailed()
	{
		PhotonNetwork.CreateRoom(null);
	}
	
	void OnJoinedRoom()
	{
		GameObject player = PhotonNetwork.Instantiate("Player2", Vector3.zero, Quaternion.identity, 0);
		player.transform.parent=TroupLeader;
		myPhotonView = player.GetComponent<PhotonView>();
	}
	
	void OnGUI()
	{
		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
		
		if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
		{
			/*bool shoutMarco = GameLogic.playerWhoIsIt == PhotonNetwork.player.ID;
			
			if (shoutMarco && GUILayout.Button("Marco!"))
			{
				myPhotonView.RPC("Marco", PhotonTargets.All);
			}
			if (!shoutMarco && GUILayout.Button("Polo!"))
			{
				myPhotonView.RPC("Polo", PhotonTargets.All);
			}*/
		}
	}
}
