using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     　
   public class TaskCollection
    {
       public TaskCollection() { TaskList = new List<AnTask>(); }

       public List<AnTask> TaskList { get; set; }
    }

   public class AnTask
   {
       public AnTask()
       {
           ChildTasks = new List<AnTask>();
           Fields = new List<FieldProperty>();
       }
       [Description("任务名")]
       public string Name { get; set; }

       public int Lever { get; set; }
       //0 列表，1 详细页
       [Description("任务类型")]
       public int TaskType{get;set;}

       public string ListItemxPath{get;set;}
    

       public string PageUrl { get; set; }

       public string PageNoRegex { get; set; }

       public string PageNoxPath { get; set; }

       public int MaxPage { get; set; }

       public List<AnTask> ChildTasks { get; set; }

       public bool IsInDb { get; set; }

       public bool IsEnable { get; set; }

       public List<FieldProperty> Fields { get; set; }
   }

   public class FieldProperty
   {

       public string DbName { get; set; }

       public string DbText { get; set; }

       public string DbTable { get; set; }

       public string DbType { get; set; }

       //0 列表型值，1 文本值
       public string ValueType { get; set; }

       public string ValuexPath { get; set; }

       public string ValueDivide { get; set; }

   }
   public enum DbTypeEnum
   {
       [Description("整形")]
       Int = 1,
       [Description("文本值")]
       String = 2
   }
   public enum ValueTypeEnum
   {
       [Description("列表值")]
       ListingValue = 1,
       [Description("文本值")]
       TextValue =2 
   }
}
