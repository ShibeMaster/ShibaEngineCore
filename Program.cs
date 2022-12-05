using System.Numerics; 
using System.Runtime.CompilerServices;
using ShibaEngineCore;


public class Test2 : Component
{
    public float speed = 0.0f;
    public override void Start()
    {
        base.Start();
    }
    public override void Update()
    {
    }
}
public class Spinning : Component
{
    public Physics physics;
    public Vector3 direction;
    public float speed;
    public override void Start()
    {
        System.Console.WriteLine("here");
    }
    public override void Update()
    {
            ShibaEngineCore.Console.LogMessage("here");
        if (Input.GetKeyDown(KeyCode.KEY_SPACE))
        {
            transform.Position += direction * speed * Time.deltaTime;
            ShibaEngineCore.Console.LogMessage(transform.Position.ToString());
        }
    }
}