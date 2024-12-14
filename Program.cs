using Construction_practice3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания: ");
            string GG = Console.ReadLine();
            int G = Convert.ToInt32(GG);

            switch (G)
            {
                case 1:
                    ClassCar classCar = new ClassCar("Kalina", "Lada", 2002 );
                    classCar.Information();
                    classCar.ReversMake("Vesta");
                    classCar.DisplayInfo();
                    break;
                case 2:
                    ClassStudent classStudent = new ClassStudent("Тимофей", "Арбузин", 16 );
                    classStudent.ReversAge(18);
                    classStudent.DisplayInfo();
                    break;
                case 3:
                    ClassProduct classProduct = new ClassProduct(339.90, "Колбаса", 1 );
                    classProduct.ReversPrice(289.99);
                    classProduct.DisplayInfo();
                    break;
                case 4:
                    ClassEmployee classEmployee = new ClassEmployee("Александр", "Помидоров", "Электрик" );
                    classEmployee.ReversPosition("Программист");
                    classEmployee.DisplayInfo();
                    break;
                case 5:
                    ClassBook classBook = new ClassBook("Александр Пушкин", 2006);
                    classBook.ReversAthor("Сапковский Анжей");
                    classBook.DisplayInfo(); 
                    break;
                case 6:
                    ClassCar2 classCar2 = new ClassCar2("M5", "BMW", 2016);
                    classCar2.Information();
                    classCar2.ReversMake("M8");
                    classCar2.DisplayInfo();
                    break;
                case 7:
                    ClassUser classUser = new ClassUser("Тимофей", "Арбузов", "Ms. Arbus");
                    classUser.ReversLogin("NORINOBU");
                    classUser.DisplayInfo();
                    break;
                case 8:
                    ClassProduct2 classProduct2 = new ClassProduct2("Груша", 49.99, 2);
                    classProduct2.ReversPrice(56.90);
                    classProduct2.DisplayInfo();
                    break;
                case 9:
                    ClassTicher classTicher = new ClassTicher("Елена", "Палкова", "Математика");
                    classTicher.ReversLesson("Русский язык");
                    classTicher.DisplayInfo();
                    break;
                case 10:
                    ClassUser2 classUser2 = new ClassUser2("Тимофей", "Арбузов", "Ms. Arbus");
                    classUser2.ReversLogin("NORINOBU");
                    classUser2.DisplayInfo();
                    break;
                case 11:
                    ClassShop classShop = new ClassShop("Авакадо", "Ул. Кукунина, д. 45", 1 );
                    classShop.ReversQuanity(2);
                    classShop.DisplayInfo();
                    break;
                case 12:

                    ClassBank classBank = new ClassBank("Тинькоф", "Ул. Верная, д. 23", 40 );
                    classBank.ReversQuanityUser(90);
                    classBank.DisplayInfo();
                    break;
                case 13:
                    ClassUniversity classUniversity = new ClassUniversity("ТУЛГУ", "Ул. Октябрьская, д. 12", 1000 );
                    classUniversity.ReversQuanityStudent(1300);
                    classUniversity.DisplayInfo();
                    break;
                case 14:
                    ClassSchool classSchool = new ClassSchool("МБОУ СОШ №4", "Ул. Берёзовая, д. 9", 200 );
                    classSchool.ReversQuanityStudent(300);
                    classSchool.DisplayInfo();
                    break;
                case 15:
                    ClassLibrary classLibrary = new ClassLibrary("Читай город", "Ул. Калинина, д. 20", 3000 );
                    classLibrary.ReversQuanityiBook(6000);
                    classLibrary.DisplayInfo();
                    break;
                case 16:
                    ClassMuseum classMuseum = new ClassMuseum("Археологический музей", "Ул. Вишневского, д. 5", 1000 );
                    classMuseum.ReversQuanityExhibit(1400);
                    classMuseum.DisplayInfo();
                    break;
                case 17:
                    ClassTheater classTheater = new ClassTheater("Московский театр", "Ул. Московская, д. 4", 3 );
                    classTheater.ReversQuanityPerformance(5);
                    classTheater.DisplayInfo();
                    break;
                case 18:
                    ClassCinema classCinema = new ClassCinema("Элизиум", "Ул. Берёзовая, д. 67", 5 );
                    classCinema.ReversQuanityFilm(8);
                    classCinema.DisplayInfo();
                    break;
                case 19:
                    ClassRestaurant classRestaurant = new ClassRestaurant("Вкусно и точка", "Ул. Ветренная", 28 );
                    classRestaurant.ReversQuanityDishes(32);
                    classRestaurant.DisplayInfo();
                    break;
                case 20:
                    ClassCafe classCafe = new ClassCafe("Ташир", "Ул. Фрунзе, д. 78", 9 );
                    classCafe.ReversQuanityDrink(8);
                    classCafe.DisplayInfo();
                    break;
                case 21:
                    ClassHotel classHotel = new ClassHotel("Россия", "Ул. Гвардейская, д. 435", 34 );
                    classHotel.ReversQuanityNumbers(23);
                    classHotel.DisplayInfo();
                    break;
                case 22:
                    ClassAirport classAirport = new ClassAirport("Домодедово", "Ул. Яблочная, д. 87", 6 );
                    classAirport.ReversQuanityFlight(8);
                    classAirport.DisplayInfo();
                    break;
                case 23:
                    ClassRailway classRailway = new ClassRailway("Узловская", "Ул. Оконная, д. 43", 12 );
                    classRailway.ReversQuanityTrain(8);
                    classRailway.DisplayInfo();
                    break;
                case 24:
                    ClassStation classStation = new ClassStation("Красная", "Ул. Малинина, д. 56", 9 );
                    classStation.ReversQuanityBus(8);
                    classStation.DisplayInfo();
                    break;
                case 25:
                    ClassPark classPark = new ClassPark("Ясный", "Ул. Ульянова, д. 34", 2233 );
                    classPark.ReversQuanityTrees(4567);
                    classPark.DisplayInfo(); 
                    break;
                case 26:
                    ClassGarden classGarden = new ClassGarden("Свежесть", "Ул. Мосина, д. 44", 123 );
                    classGarden.ReversQuanityFlowers(321);
                    classGarden.DisplayInfo();
                    break;
                case 27:
                    ClassZoo classZoo = new ClassZoo("Московский", "ул. Брунина, д. 76", 334 );
                    classZoo.ReversQuanityAnimal(324);
                    classZoo.DisplayInfo();
                    break;
                case 28:
                    ClassAquarium classAquarium = new ClassAquarium("Комнатный", "отсутствует", 1 );
                    classAquarium.ReversQuanityFish(0);
                    classAquarium.DisplayInfo();
                    break;
                case 29:
                    ClassMuseum2 classMuseum2 = new ClassMuseum2("Археологический музей", "Ул. Вишневского, д. 5", 1000);
                    classMuseum2.ReversQuanityExhibit(1400);
                    classMuseum2.DisplayInfo();
                    break;
                case 30:
                    ClassTheater2 classTheater2 = new ClassTheater2("Московский театр", "Ул. Московская, д. 4", 3);
                    classTheater2.ReversQuanityPerformance(5);
                    classTheater2.DisplayInfo();
                    break;
            }
        }
    }
}
