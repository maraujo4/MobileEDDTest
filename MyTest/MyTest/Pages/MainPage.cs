using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyTest.Pages
{
    public class MainPage : ContentPage
    {
        public Entry m_entryFirstName = new Entry();
        public Entry m_entryLasttName = new Entry();
        public Button m_buttonConcatNames;
        public Label m_lableMergeResult = new Label();
        public MainPage()
        {
            Label labelFirstName = new Label
            {
                Text = "First Name"
            };

            Label labelLastName = new Label
            {
                Text = "Last Name"
            };

            m_buttonConcatNames = new Button
            {
                Text = "Click me!"
            };
            m_buttonConcatNames.Clicked += M_buttonConcatNames_Clicked;
            Content = new StackLayout
            {
                Children =
                {
                    labelFirstName,
                    m_entryFirstName,
                    labelLastName,
                    m_entryLasttName,
                    m_buttonConcatNames,
                    m_lableMergeResult
                }
            };
        }

        private void M_buttonConcatNames_Clicked(object sender, EventArgs e)
        {
            try
            {                
                m_lableMergeResult.Text = $"{m_entryFirstName.Text} {m_entryLasttName.Text} !";
            }
            catch (Exception ex)
            {
                m_lableMergeResult.Text = ex.Message;
            }
        }
    }
}
