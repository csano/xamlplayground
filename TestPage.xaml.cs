using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using XamlPlayground.Annotations;

namespace XamlPlayground
{
    /// <summary>
    /// Interaction logic for TestPage.xaml
    /// </summary>
    public partial class TestPage : Page, INotifyPropertyChanged
    {
        public bool IsButtonVisible => true;

        private string m_text = "test";
        public string Text
        {
            get { return m_text; }
            set
            {
                m_text = value; 
                OnPropertyChanged(nameof(Text));
            }
        }

        public TestPage()
        {
            InitializeComponent();
            //DataContext = this;
        }

        private void button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Text = "new value";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
