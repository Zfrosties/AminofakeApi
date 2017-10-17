using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;  

namespace aminofakeApi.Models { 
   public class Fact {

    public int ID { get; set; }
    public string Title { get; set; } 
    public string Content { get; set;} 
    public bool IsValidated { get; set;} 
    public bool IsFake {get; set;}

   } 
}