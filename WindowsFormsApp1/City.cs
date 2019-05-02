using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public class City 
  {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public int Number { get; set; }   
  }
}
