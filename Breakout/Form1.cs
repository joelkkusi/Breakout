namespace Breakout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    MovePaddleLeft();
                    break;

                case Keys.Right:
                    MovePaddleRight();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MovePaddleLeft()
        {
            var oldLocation = paddle.Location;
            var newLocation = new Point(oldLocation.X - 10, oldLocation.Y);
        }
    }
}