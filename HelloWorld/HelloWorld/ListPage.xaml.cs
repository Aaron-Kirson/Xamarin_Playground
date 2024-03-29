﻿using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup ("A", "A")
                {
                      new Contact {Name = "Aaron", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "online"}
                },
                  new ContactGroup ("D", "D")
                {
                     new Contact {Name = "Daniel", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "online"}
      
                },
                    new ContactGroup ("N", "N")
                {
                               new Contact {Name = "Naomi", ImageUrl = "http://lorempixel.com/100/100/people/3", Status = "online"}
                }


              
            };
        }
    }
}