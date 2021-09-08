using System;

namespace Full_GRASP_And_SOLID.Library{
  public class ConsolePrinter{
    public static void PrintRecipe(Recipe recipe){
      Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
      foreach (Step step in recipe.steps){
        Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
        $"usando '{step.Equipment.Description}' durante {step.Time}");
      }
    }
  }
}

/*Utilizo el principio RSP que dice que cada clase tiene una responsabilidad única. Recipe ya tenia la 
responsabilidad de agregar o remover los step de la lista de steps, por eso se crea una nueva clase que se encargue solo
de imprimir la Recipe.*/
