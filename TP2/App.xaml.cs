﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TP2.Classes;

namespace TP2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current { get { return Application.Current as App; } }

        public static readonly string ApplicationBaseUri = "pack://application:,,,/TP2;component";

        public static Uri GetUri(string path)
        {
            return new Uri(ApplicationBaseUri + path);
        }

        public Dictionary<int, User> Users = new()
        {
            { 0, new User() { Id = 0, Name = "Tom", LastName = "Richards", Source="/Assets/Users/user1.jpg" } },
            { 1, new User() { Id = 1, Name = "Elliot", LastName = "Hart", Source="/Assets/Users/user2.jpg"} },
            { 2, new User() { Id = 2, Name = "Rachel", LastName = "Chapman", Source="/Assets/Users/user3.jpg"} },
            { 3, new User() { Id = 3, Name = "Myriam", LastName = "Leblanc", Source="/Assets/Users/user4.jpg"} },
            { 4, new User() { Id = 4, Name = "Paul", LastName = "Burnham", Source="/Assets/Users/user5.jpg"} },
        };

        public Dictionary<int, Offer> Offers = new()
        {
            { 0, new Car() { Id = 0, Titre = "2014 Honda Accord", Description = "170k km", Price = 6000,
                DateDeMiseEnVente = new DateTime(2021, 11, 19), Source = "/Assets/Offers/Cars/car1.jpg",
                Fabriquant = "Accord", Marque = "Honda", Odometre = 170, Annee = new DateOnly(2014, 01, 01)} },
            { 1, new Car() { Id = 1, Titre = "2015 Toyota Camry", Description = "200k km", Price = 5000,
                DateDeMiseEnVente = new DateTime(2021, 11, 19), Source = "/Assets/Offers/Cars/car2.jpg",
                Fabriquant = "Camry", Marque = "Toyota", Odometre = 200, Annee = new DateOnly(2015, 01, 01)} },
            { 2, new Car() { Id = 2, Titre = "2013 Nissan Leaf", Description = "210k km", Price = 8000,
                DateDeMiseEnVente = new DateTime(2021, 11, 21), Source = "/Assets/Offers/Cars/car3.jpg",
                Fabriquant = "Leaf", Marque = "Nissan", Odometre = 210, Annee = new DateOnly(2013, 01, 01)} },
            { 3, new Car() { Id = 3, Titre = "2021 Toyota Yaris", Description = "20k km", Price = 10000,
                DateDeMiseEnVente = new DateTime(2021, 11, 21), Source = "/Assets/Offers/Cars/car4.jpg",
                Fabriquant = "Yaris", Marque = "Toyota", Odometre = 20, Annee = new DateOnly(2021, 01, 01)} },
            { 4, new Car() { Id = 4, Titre = "2001 Honda Civic", Description = "350k km", Price = 1000,
                DateDeMiseEnVente = new DateTime(2021, 11, 23), Source = "/Assets/Offers/Cars/car5.jpg",
                Fabriquant = "Civic", Marque = "Honda", Odometre = 350, Annee = new DateOnly(2001, 01, 01)} },
            { 5, new Car() { Id = 5, Titre = "2011 Honda Civic", Description = "140k km", Price = 6000,
                DateDeMiseEnVente = new DateTime(2021, 11, 23), Source = "/Assets/Offers/Cars/car6.jpg",
                Fabriquant = "Civic", Marque = "Honda", Odometre = 140, Annee = new DateOnly(2011, 01, 01)} },
            { 6, new Car() { Id = 6, Titre = "2021 Toyota Camry", Description = "10k km", Price = 20000,
                DateDeMiseEnVente = new DateTime(2021, 11, 25), Source = "/Assets/Offers/Cars/car7.jpg",
                Fabriquant = "Camry", Marque = "Toyota", Odometre = 10, Annee = new DateOnly(2021, 01, 01)} },
            { 7, new Car() { Id = 7, Titre = "2015 Nissan Infiniti", Description = "150k km", Price = 7000,
                DateDeMiseEnVente = new DateTime(2021, 11, 25), Source = "/Assets/Offers/Cars/car8.jpg",
                Fabriquant = "Infiniti", Marque = "Nissan", Odometre = 150, Annee = new DateOnly(2015, 01, 01)} },
            { 8, new Car() { Id = 8, Titre = "2016 Nissan Infiniti", Description = "170k km", Price = 9000,
                DateDeMiseEnVente = new DateTime(2021, 11, 27), Source = "/Assets/Offers/Cars/car9.jpg",
                Fabriquant = "Infiniti", Marque = "Nissan", Odometre = 170, Annee = new DateOnly(2016, 01, 01)} },
            { 9, new Car() { Id = 9, Titre = "2018 Honda Accord", Description = "90k km", Price = 12000,
                DateDeMiseEnVente = new DateTime(2021, 11, 27), Source = "/Assets/Offers/Cars/car10.jpg",
                Fabriquant = "Accord", Marque = "Honda", Odometre = 90, Annee = new DateOnly(2018, 01, 01)} },
            { 10, new Car() { Id = 10, Titre = "2013 Toyota Yaris", Description = "210k km", Price = 5000,
                DateDeMiseEnVente = new DateTime(2021, 11, 29), Source = "/Assets/Offers/Cars/car11.jpg",
                Fabriquant = "Yaris", Marque = "Toyota", Odometre = 210, Annee = new DateOnly(2013, 01, 01)} },
            { 11, new Car() { Id = 11, Titre = "2000 Nissan Altima", Description = "320k km", Price = 2000,
                DateDeMiseEnVente = new DateTime(2021, 11, 29), Source = "/Assets/Offers/Cars/car12.jpg",
                Fabriquant = "Altima", Marque = "Nissan", Odometre = 320, Annee = new DateOnly(2000, 01, 01)} }
        };

        public List<string> Category = new()
        {
            "Appliances",
            "Cars",
            "Property Rentals"
        };

        public List<string> Maker = new()
        {
            "All",
            "Honda",
            "Nissan",
            "Toyota"
        };

        public List<string> Brand = new()
        {
            "All",
            "Accord",
            "Altima",
            "Camry",
            "Civic",
            "Corolla",
            "Fit",
            "Infiniti",
            "Leaf",
            "Yaris"
        };
    }
}
