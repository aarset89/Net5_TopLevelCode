public class PersonModel
{
    public int Id { get; init; } //With the 'init' setter key word, it isn't valid to set value after CTOR or new instance of the class
    public string FirstName { get; set; }
    public string LastName { get; set; }
}