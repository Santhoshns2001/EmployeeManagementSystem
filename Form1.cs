using System.Data.SqlClient;

namespace Employee_Management


{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=Web Forms;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            con.Open();
            SqlCommand com = new SqlCommand("Insert Into Employee values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')", con);
            com.ExecuteNonQuery();
            MessageBox.Show("Inserted data succussfully");
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
          
            SqlCommand command = new SqlCommand("update Employee set EmployeeName='" + textBox2.Text + "',Salary='" + textBox3.Text + "', Address='" + textBox4.Text + "',Role='" + comboBox1.Text + "'  where Employee_Id=" + textBox1.Text + "", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Updated data succussfully!!");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand command = new SqlCommand("delete from Employee where Employee_Id=" + textBox1.Text, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted data  succussfully !!!!");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text =textBox4.Text= comboBox1.Text = "";
        }
    }
}
