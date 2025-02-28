namespace ContosoPizza.Models;
//Questa classe definisce una pizza.
public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
}