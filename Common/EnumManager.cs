using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Common
{
    public static class EnumManager<TEnum>
    {
        private static DataTable GetDataTable()
        {
            Type enumType = typeof(TEnum); // 获取类型对象  
            FieldInfo[] enumFields = enumType.GetFields();    //获取字段信息对象集合  
            DataTable table = new DataTable();
            //DescriptionAttribute[] EnumAttributes = (DescriptionAttribute[])enumFields.GetCustomAttributes(typeof(DescriptionAttribute), false);

            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Value", Type.GetType("System.Int32"));
            //遍历集合  
            foreach (FieldInfo field in enumFields)
            {
                if (!field.IsSpecialName)
                {
                    DataRow row = table.NewRow();
                    var desc = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if(desc!=null && desc.Any())
                        row[0] = (desc.First() as DescriptionAttribute).Description;   // 获取字段文本值
                    else                     
                        row[0] = string.Empty;
                     
                    row[1] = Convert.ToInt32(field.GetRawConstantValue());        // 获取int数值  
                    //row[1] = (int)Enum.Parse(enumType, field.Name); 也可以这样  
                    table.Rows.Add(row);
                }
            }
            return table;
        }
         

        public static void SetCombox(DataGridViewComboBoxColumn list)
        {
            list.DataSource = GetDataTable();
            list.DisplayMember = "Name";
            list.ValueMember = "Value";
             
        }

        public static void SetCombox(DataGridViewComboBoxColumn list,List<string> datas){
            if (datas != null)
            {
                list.DataSource = datas;
                
            }
        }
    }  
}
