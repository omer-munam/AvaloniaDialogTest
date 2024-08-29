using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AvaloniaDialogTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _IsDragging;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlockOnDrop(object sender, DragEventArgs e)
        {
            var data = e.Data;
            TextBlock.Text += data.ToString();
        }

        private void OnPreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (_IsDragging)
                return;
            var treeViewItem = sender as TreeViewItem;

            if (e.LeftButton == MouseButtonState.Pressed && treeViewItem != null)
            {
                _IsDragging = true;
                DragDrop.DoDragDrop(treeViewItem, treeViewItem.Header, DragDropEffects.Copy);
                _IsDragging = false;
            }
        }
    }
}