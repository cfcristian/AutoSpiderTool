using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Common
{
    public static class Utils
    {

        static string asmPath = AppConfig.WorkSpace + @"\Asm.config";
        static string asmTaskPath = AppConfig.WorkSpace + @"\{0}_Tasks\Task.config";
        public static List<ProjectItem> GetExistsProject()
        {
            
            var cont = FileHelper.Read(asmPath);
            if (!string.IsNullOrEmpty(cont))             
            {
                var config = JsonConvert.DeserializeObject<Asm>(cont);
                return config.Items;
            }
            return new List<ProjectItem>();
        }

        public static TaskCollection GetTaskByProName(string proName)
        {
            string curPath = string.Format(asmTaskPath, proName);
            var curDir = Path.GetDirectoryName(curPath);
            FileHelper.CreateDirectory(curDir);
              
            var cont = FileHelper.Read(curPath,Encoding.UTF8);
            if (!string.IsNullOrEmpty(cont))
            {
                return JsonConvert.DeserializeObject<TaskCollection>(cont);               
            }
            return null;
        }
        public static AnTask GetTaskByTaskName(string taskName)
        {
            taskName = taskName.Trim();
            var pj = GetSelProject();
            var tasks = GetTaskByProName(pj.Name);
            if (tasks != null)
            {
                return tasks.TaskList.Find(x => x.Name == taskName);
            }
            return null;
        }


        public static void SaveTask(string proName, TaskCollection tcs)
        {
            string curPath = string.Format(asmTaskPath, proName);
            var curDir = Path.GetDirectoryName(curPath);
            FileHelper.CreateDirectory(curDir);
            //TODO 去除重复

            FileHelper.WriteText(curPath, FormatJson(JsonConvert.SerializeObject(tcs)));
        }

        public static ProjectItem GetSelProject()
        {
            return GetExistsProject().OrderByDescending(x => x.Time).ToList().Find(x => x.IsSelect);
        }


        public static ProjectItem SaveProject(string item, bool select, string home = "")
        {
            var pros = GetExistsProject();
            ProjectItem cur;
            if (pros != null && pros.Any(x => x.Name == item))
            {
                  cur = pros.Find(x => x.Name == item);
                if (cur != null)
                {
                    cur.Time = DateTime.Now;
                    cur.IsSelect = select;
                }
            }
            else
            {
                pros = new List<ProjectItem>();
                cur = new ProjectItem()
                {
                    Name = item,
                    IsSelect = select,
                    Time = DateTime.Now,
                    HomePage = home
                };
                pros.Add(cur);
            }
            //pre
            if (pros != null)
            {
                pros.ForEach(x =>
                {
                    if (x.Name != cur.Name)
                         x.IsSelect = false;
                 });
            }
 
            FileHelper.WriteText(asmPath, FormatJson(JsonConvert.SerializeObject(new Asm()
            {
                Items = pros
            })));

            return cur;
        }





        private static string FormatJson(string str)
        {
            //格式化json字符串  
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }  


    }
}
