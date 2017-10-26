using UnityEngine;
using System.Collections;

public class BollGenerator : MonoBehaviour {

    public GameObject BollPrefab;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Boll =
                Instantiate(BollPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Boll.GetComponent<BollController>().Shoot(
                new Vector3(0, 200, 2000));
        }

	}
}
