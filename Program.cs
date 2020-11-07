using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		/*Rover[] rover = {lunokhod, apollo, sojourner};
      DirectAll(rover);

      Object[] probes = { lunokhod, apollo, sojourner, sputnik};
      foreach (Object o in probes)
      {
        Console.WriteLine($"Tracking a {o.GetType()}");
      }*/

      IDirectable[] directables = {lunokhod, apollo, sojourner, sputnik};

      DirectAll(directables);
    }

    public static void DirectAll(IDirectable[] directables)
    {
      foreach (IDirectable d in directables)
      {
        Console.WriteLine(d.GetInfo());
        Console.WriteLine(d.Explore());
        Console.WriteLine(d.Collect());
       
      }
      
    }
  }
}
