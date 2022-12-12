using System.Numerics; 
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
public class Testing : Component
{
    public Instance otherEntity = new Instance();
    public override void Start()
    {
        ShibaEngineCore.Console.LogMessage(otherEntity.name);
        ShibaEngineCore.Console.LogMessage(otherEntity.GetCoreComponent<Transform>().Position.ToString());
    }
    public override void Update()
    {

    }
}