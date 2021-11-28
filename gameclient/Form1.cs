using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Move1);
        }

        void Menu1()
        {
            MessageBox.Show(",lslflsflsf,sfsf");
        }
        void Move1(object sendler, KeyEventArgs a)
        {
            switch (a.KeyCode.ToString())
            {
                case "Left": cube.Location = new Point(cube.Location.X - 40, cube.Location.Y); break;
                case "Right": cube.Location = new Point(cube.Location.X + 40, cube.Location.Y); break;
                case "Up": cube.Location = new Point(cube.Location.X, cube.Location.Y - 40); break;
                case "Down": cube.Location = new Point(cube.Location.X, cube.Location.Y + 40); break;

            }
        }

    }
}
