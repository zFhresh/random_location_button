namespace button_game
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        game game;
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new game(button1 , this);
            label1.Text = "Point : 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.click_btn();
            label1.Text = "Point : " + game.get_point().ToString();
            game.time2_start();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            game.fail_click_form();
            label1.Text = "Point : " + game.get_point().ToString();
        }
    }
}