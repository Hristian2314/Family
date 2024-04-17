namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person chovek = new Person();

            chovek.name = "Ivan";

            chovek.age = -15;
            chovek.IntroduseYoureSelf();
           
        }
    }
}
