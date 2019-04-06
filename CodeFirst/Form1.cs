using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindContext ctx = new NorthwindContext();
        private void btnGoster_Click(object sender, EventArgs e)
        {
            //ctx.Database.Create();
            List<Category> clist = ctx.Categories.OrderBy(x => x.CategoryID).ToList();
            //ICollection<Category> clist1 = ctx.Categories.ToList();
            dataGridView1.DataSource = clist;

            //Linq Expresiion
            //var clist2 = from c in ctx.Categories select c;
            //dataGridView1.DataSource = clist2.ToList();
        }
    }
}
