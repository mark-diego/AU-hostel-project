using System;
using Xamarin.Forms;

namespace AU_Hostel_Project.UI
{
    public class ProfileScreen : ContentPage
    {
        public ProfileScreen(string studentName, string allocationDetails)
        {
            Title = "Student Profile";

            Content = new StackLayout
            {
                Padding = new Thickness(10),
                Children = {
                    new Label { Text = "Student Name:", FontAttributes = FontAttributes.Bold },
                    new Label { Text = studentName },
                    new Label { Text = "Allocation Details:", FontAttributes = FontAttributes.Bold },
                    new Label { Text = allocationDetails }
                }
            };
        }
    }
}