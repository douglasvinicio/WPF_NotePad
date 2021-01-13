using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace NotePad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string fileName;
        public string filePath = "";
        public Boolean textChanged = false;

        public string MyTitle
        {
            get {
                return (String)GetValue(MainWindow.TitleProperty);
            }
            set
            {
                SetValue(MainWindow.TitleProperty, fileName);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Notepad";
        }

        private void miOpenFile_Click(object sender, RoutedEventArgs e)
        {
            if (textChanged)
            {
                var result = MessageBox.Show("Do you want to save the changes?" , "Notepad", MessageBoxButton.YesNoCancel);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        if (File.Exists(filePath))
                        {
                            miSave_Click(sender, e);
                        }
                        else
                        {
                            miSaveFile_Click(sender, e);
                        }
                        break;
                    case MessageBoxResult.No:
                        break;
                    case MessageBoxResult.Cancel:
                        return;
                }
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                txtValue.Text = File.ReadAllText(openFileDialog.FileName);
                tblStatus.Text = openFileDialog.FileName;
                fileName = openFileDialog.SafeFileName;
                filePath = openFileDialog.FileName;
                MyTitle = fileName;
                textChanged = false;
            }
        }

        private void miSave_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(filePath, txtValue.Text);
        }

        private void miSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save the all the text";
            if (saveFileDialog1.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtValue.Text);
            }
            else
            {
                MessageBox.Show("File error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void miExitApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            textChanged = true;
        }
    }
}
