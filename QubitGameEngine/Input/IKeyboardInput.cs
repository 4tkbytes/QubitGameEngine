using Silk.NET.Input;

namespace QubitGameEngine;

public interface IKeyboardInput
{
    void KeyDown(IKeyboard keyboard, Key key, int arg3);
}