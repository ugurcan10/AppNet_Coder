namespace AppNet.WinFormUI
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            //this.Close();

            UserReset UR = new UserReset();  

            UR.Show();
            MessageBox.Show("SASA");
         
     


        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegUser Ureg=new RegUser();
            Ureg.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ksifretb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
             ksifretb.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {

                
                ksifretb.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
                


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void kaditb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }


       
        


    }
}