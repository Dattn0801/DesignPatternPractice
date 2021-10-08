using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StrategyPattern2
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        // Behavior abstract
        public abstract class VehicaleBehavior
        {
            public abstract string AboutMe(string vehicle);
        }

        // can fly
        class FlyBehavior : VehicaleBehavior
        {
            public override string AboutMe(string vehicle)
            {
                return vehicle + " can fly  currently";
            }
        }

        // Cant float
        class FloatBehavior : VehicaleBehavior
        {
            public override string AboutMe(string vehicle)
            {
                return vehicle+ " can float  currently";
            }
        }

        // Just create,haven't done anything yet

        class InitialBehavior : VehicaleBehavior
        {
            public override string AboutMe(string vehicle)
            {
                return vehicle +"  just create,haven't done anything yet";
            }
        }

        public class Vehicle
        {
            VehicaleBehavior behavior;
            string vehicleType;
            public Vehicle(string vehicleType)
            {
                this.vehicleType = vehicleType;
                this.behavior = new InitialBehavior();
            }
            public void setVehicleBehavior(VehicaleBehavior behavior)
            {
                this.behavior = behavior;
            }
            public string DisplayAboutMe()
            {
                return this.behavior.AboutMe(this.vehicleType);
            }
        }
        Vehicle KOto = new Vehicle("Car of K");
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = KOto.DisplayAboutMe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KOto.setVehicleBehavior(new FlyBehavior());
            textBox1.Text = KOto.DisplayAboutMe();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            KOto.setVehicleBehavior(new FloatBehavior());
            textBox1.Text = KOto.DisplayAboutMe();
        }
    }
}
