using System.Runtime.InteropServices;

namespace EstruturaDados.Exercicios
{
    public class ExercicioBuscaBinaria001
    {

        public ExercicioBuscaBinaria001()
        {
            //Exercicio 1.1: Suponha que você tenha lista com 128 nome e esteja fazendo uma pesquisa binária. Qual seria o número máximo de etapas que você levaria para encontrar o nome desejado?

            string[] lista128nomes = {
                 "Alice",       "Benjamin", "Carlos",       "Diana",    "Eduardo",  "Fernanda", "Gugu",     "Lena",     "Igor",     "Juliana",
                 "Kleber",      "Larissa",  "Marcos",       "Natália",  "Otávio",   "Patrícia", "Quintino", "Rafaela",  "Samuel",   "Tatiana",
                 "Ubiratan",    "Valéria",  "Wellington",   "Xavier",   "Zilda",    "Zuleika",  "André",    "Beatriz",  "César",    "Daniela",
                 "Eliana",      "Felipe",   "Giovana",      "Henrique", "Isabela",  "Joaquim",  "Karen",    "Lucas",    "Manuela",  "Nicolas",
                 "Olívia",      "Paulo",    "Quésia",       "Ricardo",  "Sabrina",  "Thiago",   "Ursula",   "Vinícius", "Wesley",   "Ximena",
                 "Yuri",        "Zoraide",  "Amanda",       "Bruno",    "Catarina", "Diego",    "Elaine",   "Fábio",    "Gabriela", "Heitor",
                 "Isadora",     "João",     "Kátia",        "Leandro",  "Mariana",  "Nathalia", "Orlando",  "Priscila", "Quirino",  "Renata",
                 "Sérgio",      "Tainá",    "Ulisses",      "Viviane",  "William",  "Xênia",    "Yago",     "Zora",     "Alberto",  "Bianca",
                 "Caio",        "Débora",   "Emerson",      "Flávia",   "Gustavo",  "Helena",   "Iago",     "Juliano",  "Kelly",    "Luan",
                 "Melissa",     "Natanael", "Otávia",       "Pedro",    "Quinzinho","Raquel",   "Silvia",   "Teodoro",  "Ulisses",  "Vânia",
                 "Wagner",      "Xandinho", "Yasmin",       "Zélia",    "Ana",      "Bernardo", "Cláudia",  "Denis",    "Esther",   "Fabiana",
                 "Gilberto",    "Heloísa",  "Ítalo",        "Júlia",    "Karine",   "Lúcia",    "Matheus",  "Nícolas",  "Osvaldo",  "Paula",
                 "Quirino",     "Regina",   "Patrick",      "Tânia",    "Evandro",  "Jader",    "Denise",   "Anderson"};

            string[] lista256nomes = {
                "Eric Adams", "Jessica Kelley", "Scott Lee", "Donna Schwartz", "Thomas Castro", "Brian Pierce", "Kevin Oconnell", "Kelly Wallace", 
                "Daniel Pham", "Alejandra Conner", "Matthew Frederick", "Joel Roberts", "Maria Cortez", "Michelle Singh", "Martin Weber", "Vickie Schaefer", 
                "Sally Ford", "Alexander Baker", "Marissa Sawyer", "Catherine Santos", "Kristen Chang", "Stephen Wilson", "Nicholas Madden", "Corey Kerr", 
                "Joseph Haynes", "Alexander Bright", "Michael Zamora", "Erica Payne", "Kayla Garcia", "Ellen Levine", "Erica Cohen", "Craig Rose", "Eric Russo", 
                "Jessica Henderson", "Teresa Huber", "Douglas Davis", "Joshua White", "Michelle Smith", "Sonya Downs", "Jennifer Edwards", "Matthew Bennett", 
                "Thomas Johnson", "Julian Castillo", "Carla Chavez", "Stephanie Dunlap", "Gary Lindsey", "Thomas Patel", "David Robles", "John Ware", "Jennifer Russell", 
                "Sharon Doyle", "Charles Mullen", "Samuel Charles", "Jon Doyle", "Chad King", "Raymond Lucas", "Craig Alexander", "Teresa Hopkins", "Olivia Harris", 
                "Denise Mcguire", "Michele Odom", "Eugene Rose", "Crystal Steele", "Glenn Tran", "Stephen Scott", "Bethany Pineda", "Jessica Bryant", "Tony Walker", 
                "Devin Harrison", "Christine Martin", "Emily Andersen", "Christopher Houston", "Richard Conway", "Randall Rivera", "Sarah Clements", "Suzanne Lopez", 
                "Jasmine Johnson", "Andre Glover", "Lauren Ellis", "Karen Burns", "Monica Matthews", "Amanda Holt", "Colleen Mack", "Stephanie Andrade", "Kelsey Gibbs", 
                "Charles Evans", "Lucas Rodriguez", "Kristine Young", "Misty Warner", "Lisa Douglas", "Alyssa Garcia", "Rachel Martinez", "Andrew Wilson", "Elizabeth Espinoza", 
                "David Perez", "Kayla Merritt", "Lisa Montgomery", "Marc Wilson", "April Smith", "George Navarro", "David Harris", "Katherine Myers", "Aaron Taylor", 
                "Brandon Vaughn", "Sarah Diaz", "Leslie Johnson", "Kristopher Fox", "Brian Moore", "Kenneth Williams", "Samantha Cox", "Amanda Martin", "Antonio Taylor", 
                "Emily Dougherty", "Jason Richmond", "Brian Martinez", "Susan Pittman", "Sarah Martin", "Heather Hamilton", "Patricia Salinas", "Renee Leach", 
                "Christopher Camacho", "Jennifer Henderson", "Andrea Sellers", "Breanna Weaver", "Lindsey Ramirez", "Megan Thomas", "Amanda Dougherty", "Daniel Griffith", 
                "Kathy White", "Adrienne Bailey", "Justin Williams", "William Singleton", "Heather Howell", "Cheryl Matthews", "Thomas Little", "Zachary Crawford", 
                "Jeremy Lopez", "Andre Jones", "Jacqueline Collins", "Brad Lynch", "Michele Harrington", "Zachary David", "Jason Mcconnell", "Angela Wright", "Bonnie Holt", 
                "Joann Williams", "Michael Christensen", "William Sullivan", "Lori Jordan", "Nathan Fisher", "Robert Castillo", "Jacob Dyer", "Susan Carson", "Erika Barron", 
                "Emily Arnold", "Lori Gomez", "Christina Martin", "Victoria Sparks", "Deanna Fuentes", "Katherine Orr", "Lori Ibarra", "Robert Martin", "Cody Green", 
                "Nicole Parker", "Ryan Moore", "Patrick Johnson", "Jennifer Beltran", "Christine Ayers", "Johnny Jones", "James Garcia", "Rebecca Myers", "Susan Lambert", 
                "Richard Goodwin", "Roy Higgins", "Casey Jones", "Jeffrey Fields", "Julie Carr", "Bonnie Burns", "Paul Schmidt", "Danielle Vargas", "Kimberly Sanders", 
                "Rebecca White", "Tina Patton", "Mary Williams", "Alex Gonzalez", "Ashley Mayo", "Michele Garza", "Matthew Mason", "Aaron Beck", "Jonathan Schneider", 
                "Angela Mcclain", "Matthew Wagner", "Mathew Butler", "Briana Sanchez", "James Wilson", "Sandra Harris", "Brian Durham", "Kyle Martinez", "Carmen Jacobs", 
                "John Matthews", "Kyle Foster", "Jamie Hudson", "Teresa Santos", "John Rosales", "Angela Valenzuela", "Cynthia Thomas", "Theodore Khan", "Stacey Maldonado", 
                "Brian Carpenter", "Ivan Kim", "Nicholas Molina", "Jonathan Allen", "Jasmine Ball", "Joseph Brown", "Teresa Estrada", "Heather Porter", "Amy Kerr", "Sherry Hayes", 
                "Jonathan Wilson", "Christopher Roberts", "Rebecca Winters", "Alexis Rodriguez", "Ashley Torres", "Anthony Murphy", "Raymond Andrews", "Kristin Patel", "Derrick Wiley", 
                "Dennis Young", "Carol Robertson", "Bruce Contreras", "Janice Garcia", "Jacqueline Martin", "Joe Odom", "Theodore Smith", "Sara Castillo", "Jessica Pierce", "Jennifer Lopez", 
                "Abigail Baker", "Tony Thompson", "Angela Hill", "Michael Murillo", "Scott Day", "Alexander Ramirez", "Rebecca Trevino", "Wendy Mullins", "Brandon Velasquez", "James Ramsey", 
                "Maria Gardner", "Dennis Brooks", "Angela Clark", "Cindy Figueroa", "Daniel Moon", "Jessica Cruz", "Dale Lynch", "Joanna Morales", "James Roman"            
            };

            Console.WriteLine(lista128nomes.Length);
            Console.WriteLine(lista256nomes.Length);
            //Primeiro nome escolhido Patricia -> Posição 15 do array
            BuscaBinaria primeiroExperimento = new BuscaBinaria(lista128nomes,  Array.IndexOf(lista128nomes, "Patrícia")); //15
            //Resultado: 3 tentativas

            //Segundo nome escolhido Ximena -> Posição 49 do array
            BuscaBinaria segundoExperimento = new BuscaBinaria(lista128nomes, Array.IndexOf(lista128nomes, "Ximena")); //49
            //Resultado: 6 tentativas

            //Terceiro nome escolhido Denis -> Posição 107 do array
            BuscaBinaria terceiroExperimento = new BuscaBinaria(lista128nomes, Array.IndexOf(lista128nomes, "Denis")); //107
            //Resultado: 5 tentativas


            //Exercicio 1.2: Suponha que você duplique o tamanho da lista. Qual seria o número máximo de etapas agora?
            
            //Primeiro nome escolhido Denis -> Posição 37 do array
            BuscaBinaria quartoExperimento = new BuscaBinaria(lista256nomes, Array.IndexOf(lista256nomes, "Michelle Smith")); //37
            //Resultado: 7 tentativas

            //Segundo nome escolhido Denis -> Posição 134 do array
            BuscaBinaria quintoExperimento = new BuscaBinaria(lista256nomes, Array.IndexOf(lista256nomes, "Thomas Little")); //134
            //Resultado: 8 tentativas

            //Terceiro nome escolhido Denis -> Posição 253 do array
            BuscaBinaria sextoExperimento = new BuscaBinaria(lista256nomes, Array.IndexOf(lista256nomes, "Dale Lynch")); //253
            //Resultado: 7 tentativas
        }






    }
}
