using SimpleTaskManagerWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleTaskManagerWpf.Views
{
    /// <summary>
    /// Interaction logic for TaskManagerMainWindow.xaml
    /// </summary>
    public partial class TaskManagerMainView : Window
    {
        private TaskManagerMainViewModel taskManagerMainViewModel;

        public TaskManagerMainView()
        {
            InitializeComponent();
            taskManagerMainViewModel = new TaskManagerMainViewModel();
            DataContext = taskManagerMainViewModel;
                        
        }

    }
}
