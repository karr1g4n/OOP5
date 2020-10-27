using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace _5
{
    class Array
    {
        private List<int> xarray = new List<int> { };
        private List<int> yarray = new List<int> { };
        private List<int> zarray = new List<int> { };
        private void XYread()
        {
            using (StreamReader sr = new StreamReader("filex"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        xarray.Add(Convert.ToInt32(line));
                    }
                    catch
                    {
                        Console.WriteLine("error");
                        break;
                    }
                }
            }
            using (StreamReader sr = new StreamReader("filey"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        yarray.Add(Convert.ToInt32(line));
                    }
                    catch
                    {
                        Console.WriteLine("error");
                        break;
                    }
                }
            }
            for (int i = 0; i < xarray.Count; i++)
            {
                if (xarray[i] % 2 != 0)
                {
                    xarray[i] = xarray[i] + 5;
                }
            }
        }
        public void LenghtAndSum(List<int> xarray, List<int> yarray, List<int> zarray)
        {
            if (xarray.Count < yarray.Count)
            {
                for (int i = xarray.Count; i < yarray.Count; i++)
                {
                    xarray.Add(0);
                }
                for (int i = 0; i < yarray.Count; i++)
                {
                    zarray.Add(0);

                }
                for (int i = 0; i < yarray.Count; i++)
                {
                    zarray[i] = xarray[i] + yarray[i];
                }
            }
            else
            {
                for (int i = yarray.Count; i < xarray.Count; i++)
                {
                    yarray.Add(0);
                }
                for (int i = 0; i < xarray.Count; i++)
                {
                    zarray.Add(0);

                }
            }
            foreach (int i in zarray)
            {
                Console.WriteLine(i);
            }

        }
        public void GET()
        {
            XYread();
            LenghtAndSum(xarray, yarray, zarray);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array abc = new Array();
            abc.GET();
        }
    }
}