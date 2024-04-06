using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesCreator : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] List<GameObject> notes = new List<GameObject>();
    [SerializeField] List<GameObject> createPoints = new List<GameObject>();

    void Start()
    { 
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        yield return new WaitForSeconds(4);
        int num = RandomMaker(notes.Count);
        if(num == 0)
        {
            GameObject obj = Instantiate(notes[num],
            createPoints[RandomMaker(createPoints.Count)].transform.position,
            Quaternion.identity);
            obj.GetComponent<SharpMov>().target = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        }
        else 
        {
            GameObject obj = Instantiate(notes[num],
            createPoints[RandomMaker(createPoints.Count)].transform.position,
            Quaternion.identity);
            obj.GetComponent<RepeatMov>().target = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        }
        StartCoroutine(Create());
    }

    int RandomMaker(int range)
    {
        return UnityEngine.Random.Range(0, range);
    }
}
