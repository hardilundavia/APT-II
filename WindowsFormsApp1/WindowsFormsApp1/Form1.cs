using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //string n = System.Environment.CurrentDirectory;
                
                XslTransform myxsl;
                myxsl = new XslTransform();
                myxsl.Load("D:\\APT-II038\\WindowsFormsApp1\\WindowsFormsApp1\\XSLTFile1.xslt");
                myxsl.Transform("D:\\APT-II038\\WindowsFormsApp1\\WindowsFormsApp1\\XMLFile1.xml", " D:\\APT-II038\\WindowsFormsApp1\\WindowsFormsApp1\\output.xml");
            }
            catch(Exception ex)
            {
                e.ToString();
            }
            
        }
    }
}
