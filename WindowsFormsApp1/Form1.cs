﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      using (var context = new DataContext())
      {
        var data1 = textBox1.Text;
        var data2 = comboBox1.Text;

        context.SaveChanges();
      }     
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {  
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      textBox1.MaxLength = 6;
    }
  }
}
