using UnityEngine;

public class block2 : MonoBehaviour
{
    public string color="";
    public Material redMat; 
    public Material blueMat; 
    public Material greenMat; 
    public Material yellowMat; 
    public Material pinkMat; 
    public Material brownMat; 
    public Material orangeMat; 
    public Material whiteMat; 
    public Material blackMat;
    public Material pixelMat; 
    public Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        if (renderer != null)
        {
            if(color=="red")
            {
                renderer.material = redMat;
            }
            else if(color=="blue")
            {
                renderer.material = blueMat;
            }
            else if(color=="green")
            {
                renderer.material = greenMat;
            }
            else if(color=="yellow")
            {
                renderer.material = yellowMat;
            }
            else if(color=="pink")
            {
                renderer.material = pinkMat;
            }
            else if(color=="brown")
            {
                renderer.material = brownMat;
            }
            else if(color=="orange")
            {
                renderer.material = orangeMat;
            }
            else if(color=="white")
            {
                renderer.material = whiteMat;
            }
            else if(color=="black")
            {
                renderer.material = blackMat;
            }
            else if(color == "default")
            {
                renderer.material = pixelMat;
            }
            else{}
        }
        else
        {
            Debug.LogError("Renderer component not found!");
        }
    }
}
