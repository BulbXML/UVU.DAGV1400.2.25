using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;
    private void Start()
    {
        imageObj = GetComponent<Image>();
    }

    // Update is called once per frame
    public void Update()
    {
        UpdateWithFloatData();
    }
    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }
}
