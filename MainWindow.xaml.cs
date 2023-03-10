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
using System.Windows.Threading;

namespace Quiz
{
  /// <summary>
  /// Interaktionslogik für MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    int richtig_beantwortet = 0;
    
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnStart_Click(object sender, RoutedEventArgs e)
    {
      tabQuestion1.Visibility = Visibility.Visible;
      
      bool what = true;
      stopwatch(what);
      int newIndex = tcSample.SelectedIndex + 1;
      if (newIndex >= tcSample.Items.Count)
        newIndex = 0;
      tcSample.SelectedIndex = newIndex;
    }

    private void btn11_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion1.Visibility = Visibility.Hidden;
      txtQuiz1.Visibility = Visibility.Hidden;
      btn11.Visibility = Visibility.Hidden;
      btn12.Visibility = Visibility.Hidden;
      btn13.Visibility = Visibility.Hidden;
      btn14.Visibility = Visibility.Hidden;
      txtRichtig1.Visibility = Visibility.Visible;
      btnNext1.Visibility = Visibility.Visible;
      richtig_beantwortet++;
    }

    private void btn12_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion1.Visibility = Visibility.Hidden;
      txtQuiz1.Visibility = Visibility.Hidden;
      btn11.Visibility = Visibility.Hidden;
      btn12.Visibility = Visibility.Hidden;
      btn13.Visibility = Visibility.Hidden;
      btn14.Visibility = Visibility.Hidden;
      btnNext1.Visibility = Visibility.Visible;
      txtFalsch1.Visibility = Visibility.Visible;
    }

    private void btn13_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion1.Visibility = Visibility.Hidden;
      txtQuiz1.Visibility = Visibility.Hidden;
      btn11.Visibility = Visibility.Hidden;
      btn12.Visibility = Visibility.Hidden;
      btn13.Visibility = Visibility.Hidden;
      btn14.Visibility = Visibility.Hidden;
      btnNext1.Visibility = Visibility.Visible;
      txtFalsch1.Visibility = Visibility.Visible;
    }

    private void btn14_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion1.Visibility = Visibility.Hidden;
      txtQuiz1.Visibility = Visibility.Hidden;
      btn11.Visibility = Visibility.Hidden;
      btn12.Visibility = Visibility.Hidden;
      btn13.Visibility = Visibility.Hidden;
      btn14.Visibility = Visibility.Hidden;
      btnNext1.Visibility = Visibility.Visible;
      txtFalsch1.Visibility = Visibility.Visible;
    }

    private void btnNext1_Click(object sender, RoutedEventArgs e)
    {
      tabQuestion2.Visibility = Visibility.Visible;

      int newIndex = tcSample.SelectedIndex + 1;
      if (newIndex >= tcSample.Items.Count)
        newIndex = 0;
      tcSample.SelectedIndex = newIndex;
    }

    private void btn21_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion2.Visibility = Visibility.Hidden;
      txtQuiz2.Visibility = Visibility.Hidden;
      btn21.Visibility = Visibility.Hidden;
      btn22.Visibility = Visibility.Hidden;
      btn23.Visibility = Visibility.Hidden;
      btn24.Visibility = Visibility.Hidden;
      btnNext2.Visibility = Visibility.Visible;
      txtFalsch2.Visibility = Visibility.Visible;
    }

    private void btn22_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion2.Visibility = Visibility.Hidden;
      txtQuiz2.Visibility = Visibility.Hidden;
      btn21.Visibility = Visibility.Hidden;
      btn22.Visibility = Visibility.Hidden;
      btn23.Visibility = Visibility.Hidden;
      btn24.Visibility = Visibility.Hidden;
      btnNext2.Visibility = Visibility.Visible;
      txtFalsch2.Visibility = Visibility.Visible;
    }

    private void btn23_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion2.Visibility = Visibility.Hidden;
      txtQuiz2.Visibility = Visibility.Hidden;
      btn21.Visibility = Visibility.Hidden;
      btn22.Visibility = Visibility.Hidden;
      btn23.Visibility = Visibility.Hidden;
      btn24.Visibility = Visibility.Hidden;
      txtRichtig2.Visibility = Visibility.Visible;
      btnNext2.Visibility = Visibility.Visible;
      richtig_beantwortet++;
    }

    private void btn24_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion2.Visibility = Visibility.Hidden;
      txtQuiz2.Visibility = Visibility.Hidden;
      btn21.Visibility = Visibility.Hidden;
      btn22.Visibility = Visibility.Hidden;
      btn23.Visibility = Visibility.Hidden;
      btn24.Visibility = Visibility.Hidden;
      btnNext2.Visibility = Visibility.Visible;
      txtFalsch2.Visibility = Visibility.Visible;
    }

    private void btnNext2_Click(object sender, RoutedEventArgs e)
    {
      tabQuestion3.Visibility = Visibility.Visible;

      int newIndex = tcSample.SelectedIndex + 1;
      if (newIndex >= tcSample.Items.Count)
        newIndex = 0;
      tcSample.SelectedIndex = newIndex;
    }

    private void btnNext3_Click(object sender, RoutedEventArgs e)
    {
      tabQuestion4.Visibility = Visibility.Visible;

      int newIndex = tcSample.SelectedIndex + 1;
      if (newIndex >= tcSample.Items.Count)
        newIndex = 0;
      tcSample.SelectedIndex = newIndex;
    }

    private void btn31_Click(object sender, RoutedEventArgs e)
    {
      // Richtig
      txtQuestion3.Visibility = Visibility.Hidden;
      txtQuiz3.Visibility = Visibility.Hidden;
      btn31.Visibility = Visibility.Hidden;
      btn32.Visibility = Visibility.Hidden;
      btn33.Visibility = Visibility.Hidden;
      btn34.Visibility = Visibility.Hidden;
      txtRichtig3.Visibility = Visibility.Visible;
      btnNext3.Visibility = Visibility.Visible;
      richtig_beantwortet++;
    }

    private void btn32_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion3.Visibility = Visibility.Hidden;
      txtQuiz3.Visibility = Visibility.Hidden;
      btn31.Visibility = Visibility.Hidden;
      btn32.Visibility = Visibility.Hidden;
      btn33.Visibility = Visibility.Hidden;
      btn34.Visibility = Visibility.Hidden;
      txtFalsch3.Visibility = Visibility.Visible;
      btnNext3.Visibility = Visibility.Visible;
    }

    private void btn33_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion3.Visibility = Visibility.Hidden;
      txtQuiz3.Visibility = Visibility.Hidden;
      btn31.Visibility = Visibility.Hidden;
      btn32.Visibility = Visibility.Hidden;
      btn33.Visibility = Visibility.Hidden;
      btn34.Visibility = Visibility.Hidden;
      txtFalsch3.Visibility = Visibility.Visible;
      btnNext3.Visibility = Visibility.Visible;
    }

    private void btn34_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion3.Visibility = Visibility.Hidden;
      txtQuiz3.Visibility = Visibility.Hidden;
      btn31.Visibility = Visibility.Hidden;
      btn32.Visibility = Visibility.Hidden;
      btn33.Visibility = Visibility.Hidden;
      btn34.Visibility = Visibility.Hidden;
      txtFalsch3.Visibility = Visibility.Visible;
      btnNext3.Visibility = Visibility.Visible;
    }

    private void btn41_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion4.Visibility = Visibility.Hidden;
      txtQuiz4.Visibility = Visibility.Hidden;
      btn41.Visibility = Visibility.Hidden;
      btn42.Visibility = Visibility.Hidden;
      btn43.Visibility = Visibility.Hidden;
      btn44.Visibility = Visibility.Hidden;
      txtFalsch4.Visibility = Visibility.Visible;
      btnNext4.Visibility = Visibility.Visible;
    }

    private void btn42_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion4.Visibility = Visibility.Hidden;
      txtQuiz4.Visibility = Visibility.Hidden;
      btn41.Visibility = Visibility.Hidden;
      btn42.Visibility = Visibility.Hidden;
      btn43.Visibility = Visibility.Hidden;
      btn44.Visibility = Visibility.Hidden;
      txtFalsch4.Visibility = Visibility.Visible;
      btnNext4.Visibility = Visibility.Visible;
    }

    private void btn43_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion4.Visibility = Visibility.Hidden;
      txtQuiz4.Visibility = Visibility.Hidden;
      btn41.Visibility = Visibility.Hidden;
      btn42.Visibility = Visibility.Hidden;
      btn43.Visibility = Visibility.Hidden;
      btn44.Visibility = Visibility.Hidden;
      txtFalsch4.Visibility = Visibility.Visible;
      btnNext4.Visibility = Visibility.Visible;
    }

    private void btn44_Click(object sender, RoutedEventArgs e)
    {
      // Richtig
      txtQuestion4.Visibility = Visibility.Hidden;
      txtQuiz4.Visibility = Visibility.Hidden;
      btn41.Visibility = Visibility.Hidden;
      btn42.Visibility = Visibility.Hidden;
      btn43.Visibility = Visibility.Hidden;
      btn44.Visibility = Visibility.Hidden;
      txtRichtig4.Visibility = Visibility.Visible;
      btnNext4.Visibility = Visibility.Visible;
      richtig_beantwortet++;
    }

    private void btnNext4_Click(object sender, RoutedEventArgs e)
    {
      tabQuestion5.Visibility = Visibility.Visible;

      int newIndex = tcSample.SelectedIndex + 1;
      if (newIndex >= tcSample.Items.Count)
        newIndex = 0;
      tcSample.SelectedIndex = newIndex;
    }

    private void btn51_Click(object sender, RoutedEventArgs e)
    {
      // Richtig
      txtQuestion5.Visibility = Visibility.Hidden;
      txtQuiz5.Visibility = Visibility.Hidden;
      btn51.Visibility = Visibility.Hidden;
      btn52.Visibility = Visibility.Hidden;
      btn53.Visibility = Visibility.Hidden;
      btn54.Visibility = Visibility.Hidden;
      txtRichtig5.Visibility = Visibility.Visible;
      btnNext5.Visibility = Visibility.Visible;
      richtig_beantwortet++;
    }

    private void btn52_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion5.Visibility = Visibility.Hidden;
      txtQuiz5.Visibility = Visibility.Hidden;
      btn51.Visibility = Visibility.Hidden;
      btn52.Visibility = Visibility.Hidden;
      btn53.Visibility = Visibility.Hidden;
      btn54.Visibility = Visibility.Hidden;
      txtFalsch5.Visibility = Visibility.Visible;
      btnNext5.Visibility = Visibility.Visible;
    }

    private void btn53_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion5.Visibility = Visibility.Hidden;
      txtQuiz5.Visibility = Visibility.Hidden;
      btn51.Visibility = Visibility.Hidden;
      btn52.Visibility = Visibility.Hidden;
      btn53.Visibility = Visibility.Hidden;
      btn54.Visibility = Visibility.Hidden;
      txtFalsch5.Visibility = Visibility.Visible;
      btnNext5.Visibility = Visibility.Visible;
    }

    private void btn54_Click(object sender, RoutedEventArgs e)
    {
      txtQuestion5.Visibility = Visibility.Hidden;
      txtQuiz5.Visibility = Visibility.Hidden;
      btn51.Visibility = Visibility.Hidden;
      btn52.Visibility = Visibility.Hidden;
      btn53.Visibility = Visibility.Hidden;
      btn54.Visibility = Visibility.Hidden;
      txtFalsch5.Visibility = Visibility.Visible;
      btnNext5.Visibility = Visibility.Visible;
    }

    int newIndex = 0;

    private void btnNext5_Click(object sender, RoutedEventArgs e)
    {
      tabFinish.Visibility = Visibility.Visible;

      bool what = false;
      stopwatch(what);
      newIndex = tcSample.SelectedIndex + 1;
      if (newIndex >= tcSample.Items.Count)
        newIndex = 0;
      tcSample.SelectedIndex = newIndex;

      txtPunkte.Content = "Du hast " + richtig_beantwortet + " von 5 Fragen richtig beantwortet";
      txtProzent.Content = "Das sind " + richtig_beantwortet * 100 / 5 + "%";
    }

    DispatcherTimer timer = new DispatcherTimer();

    public void stopwatch(bool what)
    {
      if (what == true)
      {
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Dt_Tick;
        timer.Start();
      }
      if (!what)
      {
        timer.Stop();
      }
    }
    private int increment = 0;
    private void Dt_Tick(object sender, EventArgs e)
    {
      increment++;
      lblTime.Content = increment.ToString();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      tabQuestion1.Visibility = Visibility.Hidden;
      tabQuestion2.Visibility = Visibility.Hidden;
      tabQuestion3.Visibility = Visibility.Hidden;
      tabQuestion4.Visibility = Visibility.Hidden;
      tabQuestion5.Visibility = Visibility.Hidden;
      tabFinish.Visibility = Visibility.Hidden;
    }
  }
}
