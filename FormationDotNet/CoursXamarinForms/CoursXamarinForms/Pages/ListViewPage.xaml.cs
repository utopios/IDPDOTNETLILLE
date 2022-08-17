﻿using CoursXamarinForms.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoursXamarinForms.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        ObservableCollection<string> datas = new ObservableCollection<string>() { "toto", "tata", "titi" };
        ObservableCollection<Personne> dataPersonnes = new ObservableCollection<Personne>() { new Personne() { Name = "tata", Age=33 } };
        public ListViewPage()
        {
            InitializeComponent();
            demoListView.ItemsSource = dataPersonnes;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            datas.Add(demoEntry.Text);
        }
    }
}