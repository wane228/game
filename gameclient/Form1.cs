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
           
        }
        void Move1(object sendler, KeyEventArgs a)
        {
            switch (a.KeyCode.ToString())
            {
                case "Left": cube1.Location = new Point(cube1.Location.X - 40, cube1.Location.Y); break;
                case "Right": cube1.Location = new Point(cube1.Location.X + 40, cube1.Location.Y); break;
                case "Up": cube1.Location = new Point(cube1.Location.X, cube1.Location.Y - 40); break;
                case "Down": cube1.Location = new Point(cube1.Location.X, cube1.Location.Y + 40); break;

            }
        }

    }
}
