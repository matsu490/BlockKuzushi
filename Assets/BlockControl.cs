using System.Collections;
using UnityEngine;

public class BlockControl : MonoBehaviour {

	public GameObject blockPrefab;
	public Transform topWall;
    public int placeX;
    public int placeZ;
    public float totalDepth;

	// Use this for initialization
	void Start () {
		Vector3 placePosition = new Vector3 (
            topWall.position.x - topWall.localScale.x / 2 + blockPrefab.transform.localScale.x / 2,
            0,
            topWall.position.z - topWall.localScale.z / 2 - blockPrefab.transform.localScale.z / 2);

		Quaternion q = new Quaternion ();
		q = Quaternion.identity;

        Vector3 localscale = blockPrefab.transform.localScale;
        localscale.x = topWall.localScale.x / placeX;
        localscale.z = totalDepth / placeZ;
        blockPrefab.transform.localScale = localscale;

		for (int i = 0; i < placeZ; i++) {
            Vector3 currentPlacePosition = placePosition - Vector3.forward * blockPrefab.transform.localScale.z * i;
			for (int j = 0; j < placeX; j++) {
				Instantiate (blockPrefab, currentPlacePosition, q);	
				currentPlacePosition.x += blockPrefab.transform.localScale.x;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
