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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Workers;
using Workers.Data;

namespace WorkerDatabase.Controls
{
    /// <summary>
    /// Логика взаимодействия для DBControl.xaml
    /// </summary>
    public partial class DBControl : UserControl
    {
        private Worker worker;
        //private WorkersDatabase workersDatabase = new WorkersDatabase();
        public DBControl()
        {
            InitializeComponent();

            cbxDepartment.ItemsSource = WorkersDatabase.ListDepartment;            
        }

        /// <summary>
        /// извне устанавливаем дефолтный департамент, чтобы невозможно было создать работника вообще без департамента
        /// </summary>
        public void SetDefaultDepartment() 
        {
            cbxDepartment.SelectedIndex = 0;
        }

        public void SetWorker(Worker worker)
        {
            this.worker = worker;
            tbxName.Text = worker.Name;
            tbxAge.Text = worker.Age.ToString();
            tbxPosition.Text = worker.Position;
            tbxComment.Text = worker.Comment;
            chbxSecrecy.IsChecked = worker.Secrecy;
            cbxDepartment.SelectedItem = worker.Department;
        }

        public void UpdateWorker()
        {
            worker.Name = tbxName.Text;            
            if (int.TryParse(tbxAge.Text, out int age)) worker.Age = age;
            worker.Position = tbxPosition.Text;
            worker.Comment = tbxComment.Text;
            worker.Secrecy = (bool)chbxSecrecy.IsChecked;
            worker.Department = (Department)cbxDepartment.SelectedItem;
        }

        private void cbxDepartment_MouseDown(object sender, MouseButtonEventArgs e)
        {
            cbxDepartment.ItemsSource = null;
            cbxDepartment.ItemsSource = WorkersDatabase.ListDepartment;
        }

        
    }
}
