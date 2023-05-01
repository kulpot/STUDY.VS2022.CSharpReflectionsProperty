using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionsProperty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Class1 class1 = new Class1();
            PropertyInfo info = class1.GetType().GetProperty("Number");
            this.Text = GetPropertyDescription(info);
        }

        private static string GetPropertyDescription(PropertyInfo info)
        {
            Attribute attrib = info.GetCustomAttribute(typeof(DescriptionAttribute));//(CategoryAttribute)

            if (attrib != null)
            {
                return ((DescriptionAttribute)attrib).Description;//(CategoryAttribute)attrib).Category;
            }
            else return "";
        }
    }
}
