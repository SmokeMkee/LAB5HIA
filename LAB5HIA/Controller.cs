using System.Collections;

namespace LAB5HIA;

public class Controller
{
    private List<string[]> _list = new List<string[]>();
    Dictionary<string, string> vars = new Dictionary<string, string>();
 


    public void start()
    {
        firstMenu();
    }

    public void firstMenu()
    {
        Console.WriteLine("write console line number : ");
        string countconsoleLine = Console.ReadLine();
        addConsoleLines(countconsoleLine);
    }
   public void addConsoleLines( string countConsole){
       for (int i = 0; i < int.Parse(countConsole); i++)
            {
                _list.Add(Console.ReadLine().Split());
            }
       splitConsoleLines();
   }
   public void splitConsoleLines()
   {
       for (int j = 0; j < _list.Count; j++)
           {
               if (_list[j][0] != "ADD" && _list[j][0] != "SUB" && _list[j][0] != "MUL" && 
                   _list[j][0] != "DIV" && _list[j][0] != "INC" && _list[j][0] != "DEC" )
               {
                   vars[_list[j][0]] = _list[j][2];
               }else{
                   string typeariph = _list[j][0];
                   arith(typeariph);
               }

           }

   }

   public void arith(String typeariph)
   {
       switch (typeariph)
       {
           case "ADD":
               ADD();break;
           case "SUB":
               SUB();break;
           case "MUL":
               MUL();break;
           case "DIV":
               DIV();break;
           case "INC":
               INC();break;
           case "DEC":
               DEC();break;
           default: break;
       }

       
   }

   public void move()
   {

   }

   public void ADD()
   {
       int output = 0;
       Boolean hexOrNot = true;
       foreach( KeyValuePair<string, string> kvp in vars )
       {
           char[] arr1;
           arr1 = kvp.Value.ToCharArray();
           if(arr1[arr1.Length -1] == 'h')
           {
              string number = kvp.Value.Substring(0, arr1.Length - 1);
              output += Convert.ToInt32(number , 16);
              
           }
           else
           {
               hexOrNot = false;
               output += int.Parse(kvp.Value);
           }
       }
       if (hexOrNot == true)
       {
           Console.WriteLine("hex value is " + output.ToString("X"));
       }
       else
       {
           Console.WriteLine("add is " + output);
       }
   }
   public void SUB()
   {
       int output = 0;
       Boolean hexOrNot = true;
       foreach( KeyValuePair<string, string> kvp in vars )
       {
           char[] arr1;
           arr1 = kvp.Value.ToCharArray();
           if(arr1[arr1.Length -1] == 'h')
           {
               string number = kvp.Value.Substring(0, arr1.Length - 1);
               output = Math.Abs(output) -Math.Abs(Convert.ToInt32(number , 16));
              
           }
           else
           {
               hexOrNot = false;
               output = Math.Abs(output) - Math.Abs(int.Parse(kvp.Value));
           }
       }
       if (hexOrNot == true)
       {
           Console.WriteLine("hex value is " + Math.Abs(output).ToString("X"));
       }
       else
       {
           Console.WriteLine("add is " + output);
       }
   }
   public void MUL()
   {
       int output = 1;
       Boolean hexOrNot = true;
       foreach( KeyValuePair<string, string> kvp in vars )
       {
           char[] arr1;
           arr1 = kvp.Value.ToCharArray();
           if(arr1[arr1.Length -1] == 'h')
           {
               string number = kvp.Value.Substring(0, arr1.Length - 1);
               output *= Convert.ToInt32(number , 16);
              
           }
           else
           {
               hexOrNot = false;
               output *= int.Parse(kvp.Value);
           }
       }
       if (hexOrNot == true)
       {
           Console.WriteLine("hex value is mul " + output.ToString("X"));
       }
       else
       {
           Console.WriteLine("mul  is " + output);
       }
   }
   public void DIV()
   {
       Double output = 1;
       foreach( KeyValuePair<string, string> kvp in vars )
       {
           output /= double.Parse(kvp.Value) ;
       }

       Console.WriteLine("DIV is : " + output);
   }
   public void INC()
   {
       
   }
   public void DEC()
   {
       
   }
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
}
