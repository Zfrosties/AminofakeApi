using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;  

namespace aminofakeApi.Models { 
   public class Fact {

    public int ID { get; set; }
    public string title { get; set; } 
    public string content { get; set;} 
    public bool validated { get; set;} 
    public bool fake {get; set;}

   } 
}