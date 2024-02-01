using System;
using System.Data;
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
using Business;


                                                    //LE SILAS
                                                    //219114578


namespace PresentationLayer
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
      string fname = name.Text;
      string lname = surname.Text;
      string gender_ = gender.Text;
      string email_ = email.Text;
      if( fname != "" && lname != "" && gender_ != "" && email_ != "")
      {
        Business.Businesslayer.add(fname, lname, gender_, email_);
        clear();
        dataGrid.ItemsSource = Business.Businesslayer.fetch().DefaultView;
      }
    }
    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
      string fname = name.Text;
      string lname = surname.Text;
      string gender_ = gender.Text;
      string email_ = email.Text;
      string id = id_.Text;
      
      clear();
      Business.Businesslayer.update(fname, lname, gender_, email_, id);
      dataGrid.ItemsSource = Business.Businesslayer.fetch().DefaultView;
    }
    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
      string id = id_.Text; 
      Business.Businesslayer.delete(id);
      clear();
      dataGrid.ItemsSource = Business.Businesslayer.fetch().DefaultView;
    }
    private void Button_Click_3(object sender, RoutedEventArgs e)
    {
      clear(); 
    }
    public void clear() 
    {
      name.Clear();
      surname.Clear();
      gender.Clear();
      email.Clear();
      id_.Clear();
      dataGrid.ItemsSource = null;
    }
    private void idTxt_TextChanged(object sender, TextChangedEventArgs e)
    {
      if(id_.Text != "" )
      {
      }
    }
    private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
    }
  }
}
