using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;



namespace Form_cuda
{

    public partial class Form1 : Form
    {
        [DllImport("CudaRuntime2.dll", EntryPoint = "AddVec")]
        private static extern bool AddVec(int[] c, int[] a, int[] b, int size);

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arraySize = 5;

            int[] a = new int[] { 1, 2, 3, 4, 5 };

            int[] b = new int[] { 10, 20, 30, 40, 50 };

            int[] c = new int[arraySize];

            bool result = AddVec(c, a, b, arraySize);

            for (int i = 0; i < arraySize; i++)

            {
                Console.WriteLine(c[i].ToString() + " ");

            }

            c = new int[arraySize];

            result = AddVec(c, a, b, arraySize);

            for (int i = 0; i < arraySize; i++)

            {
                Console.WriteLine((c[i]*2).ToString() + " ");

            }
        }
    }
}
