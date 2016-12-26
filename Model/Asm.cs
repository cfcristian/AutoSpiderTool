using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class Asm
    {
      public List<ProjectItem> Items { get; set; }
    }


  public class ProjectItem
  {
      public string Name { get; set; }

      public string HomePage { get; set; }

      public DateTime Time { get; set; }


      public bool IsSelect { get; set; }
  }
}
