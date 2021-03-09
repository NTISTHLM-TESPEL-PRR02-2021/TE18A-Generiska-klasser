using System.Collections.Specialized;
using System;
using System.Collections.Generic;

namespace GeneriskaKlasser
{
  class Program
  {
    static void Main(string[] args)
    {
      // Klassdiagram: variabler, metoder, parametrar, datatyper, arv
      // Klasser, instanser, metoder/variabler i klasser
      // Arv
      // Generiska klasser

      // Internet

      // Gränssnitt
      // Namngivning, kommentarer

      // Messenger<int> m = new Messenger<int>();
      // m.package = 42;

      // Queue<string> orders = new Queue<string>();

      // orders.Enqueue("walk");
      // orders.Enqueue("stand");
      // orders.Enqueue("attack");

      // while (orders.Count > 0)
      // {
      //   string order = orders.Dequeue();
      //   Console.WriteLine(order);
      // }

      // Dictionary<string, string> words = new Dictionary<string, string>();
      // words.Add("RPG", "Roleplaying game");

      // Console.WriteLine(words["RPG"]);

      // Messenger<int> m = new Messenger<int>();

      // Dictionary<Messenger<int>, string> messengers = new Dictionary<Messenger<int>, string>();

      // messengers.Add(m, "Jättebra");


      // Console.WriteLine(messengers[m]);

      Dictionary<string, Action> actions = new Dictionary<string, Action>();

      actions.Add("walk", Walk);
      actions.Add("attack", Attack);

      actions.Add("look", 
        () => {
          Console.WriteLine("Looking");
        }
      );

      string userAction = Console.ReadLine();

      if (actions.ContainsKey(userAction))
      {
        actions[userAction]();
      }

      // if (userAction == "walk")
      // {
      //   Walk();
      // }
      // else if (userAction == "attack")
      // {
      //   Attack();
      // }



      Console.ReadLine();

    }

    public static void Walk()
    {
      Console.WriteLine("Walking!");
    }

    public static void Attack()
    {
      Console.WriteLine("Attacking!");
    }

  }
}
