using Silk.NET.Maths;

namespace QubitGameEngine;

public interface IAppLogic
{
    void OnLoad();
    void OnRender(double deltaTime);
    void OnUpdate(double deltaTime);
    void OnFramebufferResize(Vector2D<int> newSize);
}