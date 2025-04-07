using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace QubitGameEngine;

public class Engine
{
    private static IWindow window;
    
    public Engine(int width, int height, string title, IAppLogic appLogic)
    {
        var options = WindowOptions.Default;
        options.Title = title;
        options.Size = new Vector2D<int>(800, 600);

        new Engine(options, appLogic);
    }
    
    public Engine(WindowOptions options, IAppLogic appLogic)
    {
        window = Window.Create(options);
        
        SubscribeToEvents(appLogic);
    }

    public void SubscribeToEvents(IAppLogic appLogic)
    {
        window.Load += appLogic.OnLoad;
        window.Update += appLogic.OnUpdate;
        window.Render += appLogic.OnRender;
        window.FramebufferResize += appLogic.OnFramebufferResize;
    }

    public void Run()
    {
        window.Run();
        Cleanup();
    }

    public void Cleanup()
    {
        window.Dispose();
    }
    
    public IWindow GetWindow()
    {
        return window;
    }
}