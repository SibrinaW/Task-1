using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_SEMESTER_TWO
{
    public partial class Form1 : Form
    {
        int timeMs, timeSec, timeMin; //variables for the time controler. Stopwatch.
        bool isActive;
        GameEngine MainGame;
        //Function to generate the map
        public void generateMap()
        {
            //Belowe line clears the map on the grid
            this.Grid.Controls.Clear();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button btn = new Button();
                /* I got the Melee unit image from the site belowe 
               https://thecodexonline.com/cropped-1157b6fd85f1ff2-1-jpg/
               */
                    
                    btn.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.background; // Nice bit of code to fill my buttons with my background image
                    btn.Height = 65;
                    btn.Width = 65;
                    this.Grid.Controls.Add(btn);
                    
                }
            }
        }

        //Function to randomly place Units in Map
        public void generateUnits()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());   
            int unitSelect = rand.Next(0, 2);
            Unit unit;
            if (unitSelect == 0)
            {
                unit = new MeleeUnit(this);
  
                /* I got the Melee unit image from the site belowe 
               https://gameartpartners.com/chibi-collection/
               */
                unit.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.Melee; // Another bit op code for when unit is placed use allocated image
                unit.Click += new EventHandler(MeleeUnit_Click);
            }

            else
            {
                unit = new RangedUnit();
                /*
                I got the Range unit image from the site belowe 
                https://gameartpartners.com/downloads/evil-bot/
                */
                unit.BackgroundImage = Assignment_1_SEMESTER_TWO.Properties.Resources.Range; // Another bit op code for when unit is placed use allocated image
                unit.Click += new EventHandler(RangedUnit_Click);
            }

            unit.Height = 65;
            unit.Width = 65;
            unit.AutoSizeMode = AutoSizeMode; //Tried to fit picture to buttons
        }

        public Form1()
        {
            InitializeComponent();
            generateMap(); // Initializing Map

            //Generate Units after map has been rest
            for (int i = 0; i < 30; i++)
            {
                generateUnits();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainGame = new GameEngine(this);

            ResetTime(); //Rest Function
            isActive = false;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            isActive = true; 
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            isActive = false;
            generateMap();// Generate new map
            ResetTime();
          
            //GenerateUnits units
            for (int i = 0; i < 30; i++)
            {
                generateUnits();
            }
        }

        private void ResetTime()
        {
            timeMs = 0;
            timeSec = 0;
            timeMin = 0;
        }
        ResourceBuilding r = new ResourceBuilding();

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //timeSec++;
            // second_lbl.Text = timeSec.ToString();
            // MainEngine.ResourceB.generateResources();

            //Code to activate stopwatch to show correct time
            if (isActive)
            {
                timeMs++;
                
                if (timeMs >= 100)
                {
                    timeSec++;
                    timeMs = 0;
                    
                    if (timeSec >= 60 )
                    {
                        timeMin++;
                        timeSec = 0;
                       
                    }
                }
            }
            
            DrawTime();
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void MeleeUnit_Click(object sender, EventArgs e)
        {
            MeleeUnit melee = new MeleeUnit(this);
            info_txb.Text = melee.ToString();
        }

        private void titan_pic_Click(object sender, EventArgs e)
        { 
            
        }

        void RangedUnit_Click(object sender, EventArgs e)
        {
            RangedUnit ranged = new RangedUnit();
            info_txb.Text = ranged.ToString();
        }

        private void nano_pic_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void read_btn_Click(object sender, EventArgs e)
        {

        }

        private void scrapCount_lbl_Click(object sender, EventArgs e)
        {

        }

        private void scrapCounter2_lbl_Click(object sender, EventArgs e)
        {

        }

        private void DrawTime()
        { //Timer Display
            mili_lbl.Text = String.Format("{0:00}", timeMs);
            second_lbl.Text = String.Format("{0:00}", timeSec);
            min_lbl.Text = String.Format("{0:00}", timeMin);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public abstract class Unit : Button
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int health { get; set; }
        public int speed { get; set; }
        public int attack { get; set; }
        public int attackRange { get; set; }
        public int team { get; set; }
        public string TeamName { get; set; }
        public char image { get; set; }
        protected string name { get; set; }

        public Unit()
        {

        }

        public virtual void closestUnit()
        {

        }

        public virtual void move()
        {

        }

        public virtual void combat()
        {

        }

        public virtual void isRange()
        {

        }

        public virtual void returnUnit()
        {

        }

        public virtual void isDead()
        {

        }

        public virtual string ToString()
        {
            return " ";
        }
    }


    public class MeleeUnit : Unit
    {
        Form1 fm;
     
        public MeleeUnit(Form1 fm)
        {
         
        }

        public override void combat()
        {
         
        }

        public override void returnUnit()
        {

        }

        public override void isDead()
        {

        }

        public override string ToString()
        {   
            string str = "Team: Titans" + Environment.NewLine + "Health: "+ health + Environment.NewLine + "Attack: 3" + Environment.NewLine + "Speed: 2" + Environment.NewLine + "Range: 1";
            return str;
        }
    }

    public class RangedUnit : Unit
    {
        Form1 fm;

        public RangedUnit()
        {
            name = "Ranged Unit";
        }

        public override void move()
        {
            
        }

        public override void combat()
        {
            /*
            *   if (combat)
           {
               isRange(this.unitsList);
           }
           else
           {
               combat = true;
               isRange(this.unitsList);
           }

           /*Random random = new Random();
           int randomNumber;

           while (this.health <= 0 && health <= 0)
           {
               randomNumber = random.Next(0, 2);
               if(randomNumber == 0)
               {
                   this.health -= attack;
               }
               else
               {
                   health -= this.attack;
               }
           }*/
        }

        public override void isRange()
        {
            //implement search diagonal pitagoras. Internet is my friend.

            /* for (int i = 1; i <= this.attackRange; i++)
             {
                 //front
                 if(map[this.positionX][this.PositionY + i] != null)
                 {
                     return true;
                 }
                 //left
                 if (map[this.positionX - i][this.positionY] != null)
                 {
                     return true;
                 }
                 //back
                 if (map[this.positionX][this.positionY - i] != null)
                 {
                     return true;
                 }
                 //right
                 if (map[this.positionX + i][this.positionY] != null)
                 {
                     return true;
                 }
             }*/
        }

        public override void returnUnit()
        {

        }

        public override void isDead()
        {
           
        }

        public override string ToString()
        {
           string str = "Team: Nanobots" + Environment.NewLine + "Health: 100" + Environment.NewLine + "Attack: 2" + Environment.NewLine + "Speed: 1" + Environment.NewLine + "Range: 4";
            return str;
        }
    }

    public class ResourceBuilding
    {   Form1 fm;

        public ResourceBuilding(Form1 fm)
        {
           
        }

        public ResourceBuilding()
        {

        }

    }

    public class FactoryBuilding 
    {
      public FactoryBuilding()
        {

        }
    }
   
    public class Map
    {
        public void randomMap()
        {

        }

        public void movePosition()
        {
            /*
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            for (int i = 0; i < this.Speed; i++)
            {
                move(randomNumber);
            }
            */
        }

        public void updatePosition()
        {

        }

        public void read()
        {

        }
    }

    public class GameEngine 
    {
        Form1 fm;

        public GameEngine(Form1 fm)
        {

        }
    }
}

