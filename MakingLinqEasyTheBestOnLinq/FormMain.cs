using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakingLinqEasyTheBestOnLinq
{
    /// <summary>
    /// LINQ Demonstration - feel free to use these material
    /// Created by Gildasio Cardoso - gildasiocardoso@gmail.com
    /// </summary>
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string[] myArrayOfString = { "Honda", "Nissan", "Acura", "BMW", "Volvo", "Mazda", "Audi", "Volksvagem", "Dodge", "Ford" };
        int[] myArrayOfNumber = { 2, 0, 1, 3, 4, 5, 6, 7, 9, 10, 8 };

        private Boolean ShowResults(Decimal Param)
        {
            Decimal[] a = { Param };

            string[] strArray = a.Select(s => s.ToString()).ToArray();

            return ShowResults(strArray);
        }

        private Boolean ShowResults(Array Params)
        {
            Boolean result = false;
            txtResult.Clear();
            for (int i = 0; (i < Params.Length); i++)
            {
                var str = Params.GetValue(i).ToString();

                if (txtResult.Text == string.Empty)
                    txtResult.Text = string.Concat("{", str);
                else
                    txtResult.Text += string.Concat(", ", str);
            }

            result = (txtResult.Text != string.Empty);
            if (result)
                txtResult.Text += string.Concat("}");

            return result;
        }

        private void btnArrayOfNumberSum_Click(object sender, EventArgs e)
        {
            var total = myArrayOfNumber.Sum();
            txtResult.Clear();
            // this way
            txtResult.Text = string.Format("{0:n}", total);
            // or you can do directly
            txtResult.Text = string.Format("{0:n}", myArrayOfNumber.Sum());
        }

        private void btnArrayOfNumberOrderby_Click(object sender, EventArgs e)
        {
            var myResult = myArrayOfNumber.OrderBy(o => o);
            ShowResults(myResult.ToArray());

        }

        private void btnArrayOfNumberDescendingOrder_Click(object sender, EventArgs e)
        {
            var result = myArrayOfNumber.OrderByDescending(d => d);
            ShowResults(result.ToArray());
        }

        private void btnArrayOfNumberConcat_Click(object sender, EventArgs e)
        {
            int[] myArrayOfNumber2 = { 2, 0, 1, 3, 70, 90, 100, 80 };

            var result = myArrayOfNumber.Concat(myArrayOfNumber2).Distinct();
            ShowResults(result.ToArray());
        }

        private void btnArrayOfNumberWhere_Click(object sender, EventArgs e)
        {
            var result = myArrayOfNumber.Where(w => (w >= 6));
            ShowResults(result.ToArray());
        }

        private void btnArrayOfStringContain_Click(object sender, EventArgs e)
        {
            var result = myArrayOfString.Where(w => w.Contains( "a"));
            ShowResults(result.ToArray());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //tcScenario.SelectedTab = tpArrayOfString;
            tcScenario.SelectedTab = tpArrayOfNumber;

            carBrandBindingSource.DataSource = new CarBrand().GetAll().OrderBy(c => c.HostCountry );
            //carBrandDataGridView.DataSource = 
        }

        private void btnArrayOfStringContainCaseInSentitive_Click(object sender, EventArgs e)
        {
            var result = myArrayOfString.Where(w => w.ToUpper().Contains("A"));
            ShowResults(result.ToArray());
        }

        private void btnArrayOfStringWhereOrderBy_Click(object sender, EventArgs e)
        {
            var result = myArrayOfString.Where(w => w.ToUpper().Contains("A")).OrderBy(ob => ob);
            ShowResults(result.ToArray());
        }

        private void btnClassObjCountry_Click(object sender, EventArgs e)
        {
            // First way
            // or change everything for one single command
            ShowResults((new CarBrand().GetAll())
                        .Select(s => s.HostCountry)
                        .Distinct()
                        .OrderBy(o=>o).ToArray());

            // Second way
            // or change to use the method I implemented into the class
            //ShowResults((new CarBrand()).GetCountries().ToArray());
            
            /*
            // Third way
            // doing step by step 
            // 1 returning a list of CarBrand

            var car_brand = new CarBrand().GetAll();

            // 2 returning the column Country
            var country = car_brand.Select(s => s.HostCountry);

            // 3 removing duplicate values
            var result_country = country.Distinct();

            // 4 ordening 
            var result = result_country.OrderBy(o => o);
            ShowResults(result.ToArray());
            */
        }

        private void btnArrayOfStringStarstsWithEndsWith_Click(object sender, EventArgs e)
        {
            var result = myArrayOfString.Where(w => w.ToUpper().StartsWith("A") && w.ToUpper().EndsWith("A") );
            ShowResults(result.ToArray());
        }
    }
}
