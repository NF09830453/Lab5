using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class FileReader
    {
        private string[] modules;
        public string [] ReadFile()
        {
            /*StreamReader reader = File.OpenText("Initialize.txt");
            string line = reader.ReadLine();
            int i = 0;
            while (line != null)
            {
                Console.WriteLine(line);
                modules.Add(line);
                line = reader.ReadLine();
                
            }
            reader.Close();*/

            modules = File.ReadAllLines("Initialize.txt");
            //comboBox1.Items.AddRange(appearanceNames);
            return modules;

        }


    }
}
