using System.Collections;
using UnityEngine;

public class SegmentController : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] float zpos = 36.26f;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;

    private void Update()
    {
        if(creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen()); 
        }
        
    }


    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0,4);
        Instantiate(segment[segmentNum], new Vector3(0,0,zpos),Quaternion.identity);
        zpos += 36.36f;
        yield return new WaitForSeconds(2);
        creatingSegment = false;
        
    }
}
