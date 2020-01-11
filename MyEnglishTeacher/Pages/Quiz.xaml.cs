using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyEnglishTeacher.Model;

namespace MyEnglishTeacher.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz : ContentPage
    {
        Word quizWord = WordsOfDay.randomWord();
        public Quiz()
        {
            InitializeComponent();

            qLabel.Text = quizWord.english;





        }

        private void quizButton_Clicked(object sender, EventArgs e)
        {
            Check();
        }

        public void Check()
        {

            if (qEntry.Text.Equals(quizWord.turkish))
            {
                succesLabel.Text = "Correct!!";
            }
            else
            {
                succesLabel.Text = "Try Again";
            }
        }
    }
}