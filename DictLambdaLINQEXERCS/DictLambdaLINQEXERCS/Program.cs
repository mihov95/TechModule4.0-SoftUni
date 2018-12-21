using System;
using System.Collections.Generic;
using System.Linq;

namespace DictLambdaLINQEXERCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materialsKey = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "motes" || material == "shards" || material == "fragments")
                    {
                        
                        if (!materialsKey.ContainsKey(material))
                        {
                              materialsKey.Add(material, quantity);
                        }
                        else
                        {
                            materialsKey[material] = quantity;
                        }
                        
                    }
                    
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, quantity);
                        }
                        else
                        {
                            junkMaterials[material] = quantity;
                        }
                    }
                    
                }

                

                Console.WriteLine();
            }
            
        }
    }
}
