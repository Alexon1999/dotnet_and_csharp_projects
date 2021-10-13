// if we don't put a namespace, what this file contains like Recipe class will be available globally
// here we put the Recipe class in a namespace
namespace demo_api.Models
{
  public class Recipe
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public int CreatorId { get; set; }
    public User Creator { get; set; }
  }

  //?  https://docs.microsoft.com/fr-fr/dotnet/csharp/fundamentals/types/generics
  // <T> : cela s'appelle le Générique, T pour type
  // interface IEquatable<T>
  // {
  //   // Les interfaces peuvent contenir des méthodes d’instance, des propriétés, des événements, des indexeurs ou toute combinaison de ces quatre types de membres
  //   // par defaut les modificateurs d'accès(access modifiers) sont public

  //   // ici on met les membres
  //   bool Equals(T obj); // methode
  //   string mesTitre { get; set; } // propriété

  //   // Les interfaces ne peuvent pas contenir de champs d'instance (fields)
  //   //  property is also much like a field. The real difference is in their intended scope. Fields are meant to be private or protected in scope, meaning that access is restricted. Properties are meant to be public in scope, meaning that access is not restricted
  //   // string mesTitres;
  //   // private string mesTitres;
  // }

  // class Car implements IEquatable interface
  // public class Car : IEquatable<Car>
  // {
  //   public string Make { get; set; }
  //   public string Model { get; set; }
  //   public string Year { get; set; }

  //   // Implementation of IEquatable<T> interface
  //   public bool Equals(Car car)
  //   {
  //     return true;
  //   }

  //   public string mesTitre { get; set; }
  // }

}