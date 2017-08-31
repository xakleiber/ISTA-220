using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militarry_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyCommander CC = new CompanyCommander();
            CC.name("Company Commander.");
            CC.ask("First SGT");
        
            FirstSgt FirstSG = new FirstSgt();
            Console.WriteLine("\n");
            FirstSG.name("First SGT");
            FirstSG.requestReport();
            

            SOneNcoic oneNCO = new SOneNcoic();
            Console.WriteLine("\n");
            oneNCO.name("S1 NCOIC");
            oneNCO.Report("\n All accounted for.");

            STwoNcoic twoNCO = new STwoNcoic();
            Console.WriteLine("\n");
            twoNCO.name("S2 NCOIC");
            twoNCO.Report("\n 16 assigned \n 16 present");

            SThreeNcoic threeNCO = new SThreeNcoic();
            Console.WriteLine("\n");
            threeNCO.name("S3 NCOIC");
            threeNCO.Report("\n 28 assigned \n 26 pressent \n 1 school \n 1 FTR");

            SFourNcoic fourNCO = new SFourNcoic();
            Console.WriteLine("\n");
            fourNCO.name("S4 NCOIC");
            fourNCO.Report("\n All accounted for.");

            SSixNcoic sixNCO = new SSixNcoic();
            Console.WriteLine("\n");
            sixNCO.name("S6 NCOIC");
            sixNCO.Report("\n 20 assigned \n 19 present \n 1 FTR");
    
            
        }
    }
}
