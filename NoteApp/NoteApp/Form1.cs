using System;
using System.Data;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        int MessageCount = 0;
        Files usefile = new Files();
        public Form1()
        {
            InitializeComponent();
            MessageCount = 0; // serial number for the notes
            idtxt.Text = MessageCount.ToString();
        }
        // AT THIS POINT, YOU CAN GET FILE DATA
        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Note", typeof(String));

            dataGridView1.DataSource = table;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            MessageCount++;
            idtxt.Text = MessageCount.ToString();// raises the value of ID
            titletxt.Clear();
            inputtxt.Clear();
            if (MessageCount > 0)
            {
                // used to avoid adding CLICK NEW NOTE to grid
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                idtxt.Text = " ";
                string temp = table.Rows[index].ItemArray[1].ToString();
                titletxt.Text = temp;
               // should fetch data from the file
                inputtxt.Text = usefile.readFile($@"C:\Users\Ihenacho Henry\My Stuff\Coding\C#\FuelMetrics\Week One\Day 2- Friday\NoteApp\NoteApp\files\{temp}.txt");
                MessageCount--;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            // create file using title as filename.
            // add text into that file.
            String message = inputtxt.Text.ToString();
            message = message.Substring(0, 3);
            message += "...";

            String filename = titletxt.Text.ToString();
            
            filename = filename + ".txt";

            usefile.createFile($@"C:\Users\Ihenacho Henry\My Stuff\Coding\C#\FuelMetrics\Week One\Day 2- Friday\NoteApp\NoteApp\files\{filename}");
            usefile.writeFile($@"C:\Users\Ihenacho Henry\My Stuff\Coding\C#\FuelMetrics\Week One\Day 2- Friday\NoteApp\NoteApp\files\{filename}", inputtxt.Text.ToString());

            table.Rows.Add(MessageCount, titletxt.Text.ToString(), message);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string temp = table.Rows[index].ItemArray[1].ToString();
            usefile.deleteFile($@"C:\Users\Ihenacho Henry\My Stuff\Coding\C#\FuelMetrics\Week One\Day 2- Friday\NoteApp\NoteApp\files\{temp}");
            table.Rows[index].Delete();
            MessageCount--;
        }
    }
}
