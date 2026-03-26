using System.Collections;
using UnityEngine;

public class grow : MonoBehaviour
{
    public AnimationCurve growCurve;

    public float duration;

   public float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   StartCoroutine(TreeGrowUpdate());
    }

  

    IEnumerator TreeGrowUpdate()
    {

        
        while (progress < duration)
        {
            progress += Time.deltaTime;
            transform.localScale = growCurve.Evaluate(progress / duration) * Vector3.one;
            yield return new WaitForSeconds(1);//wait for a second to make it grow more smooth
        }
    }
}
