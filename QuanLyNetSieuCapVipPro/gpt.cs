using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuanLyNetSieuCapVipPro
{
    public partial class gpt : Form
    {
        private chatgpt chat = new chatgpt();
        
        public gpt()
        {
            init();
            InitializeComponent();
        }

        private async void init()
        {
           var response =  await chat.SendMessageAsync("test");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Bạn: " + textBox1.Text + "\n";
            // Call the SendMessageAsync method and await its result
            var response = await chat.SendMessageAsync(textBox1.Text);

            // Update the UI with the response
            richTextBox1.Text += "Chatgpt: " + response + "\n";
            textBox1.Clear();
        }
    }
}
