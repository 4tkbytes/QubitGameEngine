using QubitGameEngine;
using Silk.NET.Input;
using Silk.NET.Maths;

namespace PointLonely;

class Program : IAppLogic,IKeyboardInput
{
    private static Engine engine;
    static void Main(string[] args)
    {
        engine = new Engine(1280, 720, "QubitGameEngine Demo", new Program());
        engine.Run();
    }

    public void OnLoad()
    {
        IInputContext input = engine.GetWindow().CreateInput();
        for (int i = 0; i < input.Keyboards.Count; i++)
        {
            input.Keyboards[i].KeyDown += KeyDown;
        }
    }

    public void OnRender(double deltaTime)
    {
    }

    public void OnUpdate(double deltaTime)
    {
        
    }

    public void OnFramebufferResize(Vector2D<int> newSize)
    {
        
    }

    public void KeyDown(IKeyboard keyboard, Key key, int arg3)
    {
        
    }
}