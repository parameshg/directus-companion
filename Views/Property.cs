namespace DirectusCompanion
{
    public partial class Property : Form
    {
        public object Data
        {
            get
            {
                return Grid.SelectedObject;
            }

            set
            {
                Grid.SelectedObject = value;
            }
        }

        public Property()
        {
            InitializeComponent();
        }

        private void OnAccept(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}