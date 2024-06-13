namespace Prøve_2024
{

    class Program
    {
        static void Main(string[] args)
        {
            RegisterDog dog = new RegisterDog();
            RegisterMember member = new RegisterMember();

            Dog dog1 = new Dog(1, "Fido", "Golden Retriever", 2010);
            Member member1 = new Member(1, "Hans", "Hansvej 1", 1990, 12345678, "Hans@gmail.com");

            RegisterDog.AddDog(dog1);
            RegisterMember.AddMember(member1);

            Console.WriteLine(dog1);
            Console.WriteLine(member1);




        }
    }
}
