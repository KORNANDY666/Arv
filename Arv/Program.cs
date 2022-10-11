namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant("Ja", "Hasse", "Grå",15,"Mini Elefant","Indien");
            
            Tiger tiger = new Tiger("Dåligt","Greger","Gul",4,"BaliTiger","Nepal");

            Crocodile crocodile = new Crocodile("Söttvatten", "Lasse", "Grön", 12, "SötvattenKrokodil", "Australien");

            Bengal_Tiger b_tiger = new Bengal_Tiger(false,"Dåligt","Morgan","Gul / Svart",7,"Bengalisk Tiger","Bhutan");

            Indochinese_Tiger i_tiger = new Indochinese_Tiger(150,"Bra","Lena","Orange / svart",12,"Indonesisk Tiger","Indonesien");

            Animal[] animal = { elephant,tiger,crocodile,b_tiger,i_tiger };
            foreach (Animal animals in animal)
            {
                animals.MakeSound();
                Console.WriteLine("---------------------");
            }
            

            Console.ReadLine();
        }
    }
}