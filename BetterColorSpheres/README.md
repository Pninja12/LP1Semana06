```mermaid
classDiagram
    Color <|-- Color
    Sphere <|-- Sphere
    Program <|-- Program
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
      +String beakColor
      +swim()
      +quack()
    }
    class Program{
      -int sizeInFeet
      -canEat()
    }