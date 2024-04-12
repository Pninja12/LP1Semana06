```mermaid
classDiagram
    Color <--* Sphere
    Sphere <-- Program
    class Color{
    -byte red
    -byte green
    -byte blue
    -byte alpha
    +Color()
    +byte Red()
    +byte Green()
    +byte Blue()
    +byte Alpha()
    +byte GetGrey()
    }
    class Sphere{
      -int raio
      -int  vezesatirado
      -Color cor
      +Sphere()
      +Color cor()
      +Pop()
      +Throw()
      +int GetTimesThrown()
      +int GetRaio()
      +string GetCor()
    }
    class Program{
    }