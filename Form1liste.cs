using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class pair
        {
            public pair() { }
            public pair(float a, float b) { x = a; y = b; }
            public float x;
            public float y;
        }
        public List<pair> tail;
        public int nrelemente = 0;
        public int selectedIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            try
            {
                addnew();
                countAll();
            }
            catch { }
        }
    
        public void addnew()
        {

            //add
            nrelemente++;
            tail.Add(new pair(nrelemente, nrelemente));
            
         }

        private void button7_Click(object sender, EventArgs e)
        {
            //list all 
            listall();
        }

        public void listall()
        {

            //list all 
            for (int i = 0; i < tail.Count; i++)
            {
                listBox1.Items.Add(tail[i].x.ToString() + " : " + tail[i].y.ToString() + " : " + i.ToString());
                
            }
        
        }
        public void countAll()
        {

            Text = tail.Count.ToString();
        
        }
        public void createList()
        { 
            tail = new List<pair>();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //create
            createList();
        }
        public void push()
        { 
            //schivalent cu add
            addnew();
        }
        public void pop(int i)
        {
            //remove the selected index
            tail.RemoveAt(i);
        }
        public void xchange(ref pair a, ref pair b)
        {

            pair c = new pair();
            c = a;
            a = b;
            b = c; 
        
        }
        public void shiftToRight()
        {

            pair tmppair = new pair();
            tmppair = tail[tail.Count-1];

            for (int i = tail.Count-1 ; i >0; i--)
            {
                try
                {
                    tail[i] = tail[i - 1];
                }
                catch { }
            }
            tail[0] = tmppair;
           
        }
        public void shiftToLeft()
        {

            pair tmppair = new pair();
            tmppair = tail[0]; 

            for (int i = 0; i< tail.Count ; i++)
            {
                try
                {
                    tail[i] = tail[i + 1];
                }
                catch { }
            }
            tail[tail.Count-1] = tmppair;

        }
        public void delete()
        {
            delete();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //push
            push();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pop
            pop(selectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //shift to right
            shiftToRight();
            clearListBox();
            listall();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //delete
            delete();
        }

        public void clearListBox()
        {
            //
            for (int i = 0; i < tail.Count; i++)
            {
                listBox1.Items.Clear();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //clear all
            clearListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listBox1.SelectedIndex;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //shift to left
            shiftToLeft();
            clearListBox();
            listall();
        }
    }
}
