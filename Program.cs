using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEllo, It is bort #699 assistant to Passangers.");
            Console.WriteLine("Our flight misson is failed, Experiment with Thing #11 is suspended.");
            Console.WriteLine("Aircraft crashed ... radio transmission is clashed");
            Console.WriteLine("You are lost in snows, find a way home.");
            Console.WriteLine("You have thermometer. As you ever be warned about namality cold zones");
            Console.WriteLine("____________________________________________________________________");
            
            var far_rand = new Random();
            int far = far_rand.Next(-100, 50);
            double celcius = (far - 32.0) * (5.0/9.0);

            Console.WriteLine($"Your thermometer thowed tC = {celcius} in celsius");
            Console.WriteLine("Automatically converting Fahrenheit to Celsius");
            Console.WriteLine("In front of you two trails:");
            Console.WriteLine("1 - footprints resemble bear and poisonous reptiles");
            Console.WriteLine("2 - the traces resemble predatory cuttlefish and a furious boar");
            Console.WriteLine("Select a path by entering 1 or 2 in the console:");
            int route_1 = Convert.ToInt32(Console.ReadLine());
            if ( route_1 == 1)
            {
                Console.WriteLine("You have chosen the path # 1");
                Console.WriteLine("You are waiting for a bear and a poisonous reptile");
            }
            else
            {
                Console.WriteLine("You have chosen the path # 2");
                Console.WriteLine("You will find predatory cuttlefish and a furious boar");
            }

            //Inventory
            Console.WriteLine("You are invited to select two items from aircraft crash, that you can carry:");
            List<string> base_inventory = new List<string>();
            String[] array1 = new string[] { " Flashlight ", " Flare Gun ", " Ax ", " Matches " };
            base_inventory.AddRange(array1);
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine($"Total items in inventory: {base_inventory.Count}");
            //Console.WriteLine(base_inventory)
            
            for (int i = 0; i < base_inventory.Count; i++ )
            {
                Console.WriteLine($"{i} - {base_inventory[i]}" );
            }
            /*
            foreach (string inv in base_inventory)
            {
                Console.WriteLine("Inventory '" + inv + "' end...");
                
            }
            Console.WriteLine(base_inventory[0]);
            */

            Console.ReadKey();
        }
    }
}
