using System;
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
        public static new App Current { get { return App.Current; } }

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

            public Dictionary<int, Friend> Friends = new()
            {
            { 0, new Friend() { IdSend = 0, IdReceived = 1} },
            { 1, new Friend() { IdSend = 0, IdReceived = 2} },
            { 2, new Friend() { IdSend = 0, IdReceived = 3} },
            { 3, new Friend() { IdSend = 1, IdReceived = 2} },
            { 4, new Friend() { IdSend = 2, IdReceived = 3} },
            };
            public Dictionary<int, Post> Posts = new()
            {
            { 0, new Post() { Id = 0, IsRead = false, IdUserPost = 0, PopularityScore = 0, SourcePost="/Assets/Posts/post1.jpg", GiveAccess= Post.Access.Public, Title= "Nice snack with a book", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras id consectetur quam. Nam rutrum non dui et feugiat. Morbi a mattis leo. Phasellus efficitur nulla dignissim ipsum commodo, in maximus leo dignissim. Donec venenatis posuere justo quis pulvinar. Etiam eu neque nibh. Vivamus egestas sollicitudin dictum. Nunc tempus orci vel enim facilisis, sit amet rhoncus mi bibendum. Donec vel venenatis orci. Fusce ultricies libero id nulla dignissim, non molestie nunc placerat. Vestibulum hendrerit mi aliquet ante feugiat, a semper augue volutpat. Aenean leo est, sagittis non enim quis, aliquam vestibulum odio. Sed et suscipit orci.", DateTime = new DateTime(2021,11,20,07,00,00)} },
            { 1, new Post() { Id = 1, IsRead = false, IdUserPost = 1, PopularityScore = 3, Reactions = new() { {0, Post.Reaction.Like } }, SourcePost="/Assets/Posts/post2.jpg", GiveAccess= Post.Access.Public, Title= "Relaxing night at the beach", Description = "Aenean vehicula ligula id nisl dapibus auctor. Aliquam ornare, libero eu pulvinar aliquam, sem lorem fermentum nisl, sed convallis lacus sem ut nulla. Suspendisse potenti. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer at rutrum dui. Ut at dolor leo. Maecenas id fringilla diam. Curabitur aliquet efficitur diam sed iaculis. Sed vulputate faucibus facilisis. Quisque tincidunt libero sit amet est dignissim, vitae egestas dui rutrum. Etiam non nisi quis elit consequat pretium non quis ante. Phasellus nec leo est. Vestibulum porttitor ac mauris sit amet tincidunt.", DateTime = new DateTime(2021,11,21,10,30,00) } },
            { 2, new Post() { Id = 2, IsRead = false, IdUserPost = 2, PopularityScore = 5, Reactions = new() { {0, Post.Reaction.Love } }, SourcePost="/Assets/Posts/post3.jpg", GiveAccess= Post.Access.Public, Title= "Trekking in the woods", Description = "Fusce tincidunt lorem mauris, id cursus nunc bibendum quis. Etiam sed malesuada arcu, ut tempus ligula. Ut quis erat non augue molestie scelerisque vel eu lectus. Sed et sapien blandit, iaculis tortor id, cursus nisl. Quisque facilisis congue iaculis. Ut bibendum, orci in posuere efficitur, augue diam posuere massa, quis ultrices augue nibh non est. Donec orci est, egestas a eros non, rutrum luctus neque. Nulla finibus erat in dictum laoreet. Nulla nec enim vitae nisl pulvinar maximus.", DateTime = new DateTime(2021,11,22,16,30,00)} },
            { 3, new Post() { Id = 3, IsRead = false, IdUserPost = 3, PopularityScore = 2, Reactions = new() { {0, Post.Reaction.Sad }, { 1, Post.Reaction.Angry } }, SourcePost="/Assets/Posts/post4.jpg", GiveAccess= Post.Access.Public, Title= "King of the world!", Description = "Phasellus viverra sed ante et egestas. Ut rhoncus ac enim id iaculis. Pellentesque elementum elit orci, nec molestie tellus ornare et. Nam pulvinar laoreet lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer gravida odio id tortor posuere laoreet. Cras mattis tortor vitae orci semper porttitor. Proin luctus purus ut quam rhoncus volutpat. Proin ac suscipit velit. Cras quis erat varius, lacinia ligula ac, tristique dui.", DateTime = new DateTime(2021,11,23,21,00,00)} },
            { 4, new Post() { Id = 4, IsRead = false, IdUserPost = 4, PopularityScore = 0, SourcePost="/Assets/Posts/post5.jpg", GiveAccess= Post.Access.Public, Title= "After work", Description = "Nulla tincidunt eros eros, eget pulvinar massa suscipit eu. In eu leo enim. Aliquam sed feugiat magna. Nunc aliquet mauris dapibus, eleifend sapien quis, lobortis lectus. In hac habitasse platea dictumst. Mauris nec fermentum mauris. Maecenas eleifend tincidunt tortor ut mattis. Nulla feugiat sollicitudin quam in sagittis. Quisque in nisi eu purus fringilla pretium sit amet eget turpis. Vivamus sagittis elit non erat pulvinar tristique. Vivamus hendrerit porta purus id convallis. Praesent efficitur lectus lacus, eu pulvinar velit scelerisque sit amet. Duis vestibulum mattis leo, non viverra arcu mollis ac. Morbi a auctor quam.", DateTime = new DateTime(2021,11,24,12,00,00)} },
            { 5, new Post() { Id = 5, IsRead = false, IdUserPost = 0, PopularityScore = 5, Reactions = new() { {1, Post.Reaction.Love } }, SourcePost="/Assets/Posts/post6.jpg", GiveAccess= Post.Access.FriendsOnly, Title= "New Zealand 2017", Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Quisque varius malesuada tellus ut tincidunt. Sed porta suscipit tortor. Ut faucibus felis eu aliquet scelerisque. Nunc ut diam ornare, auctor felis pharetra, placerat lectus. Nunc mi ligula, sodales vitae augue a, volutpat vulputate mi. Proin ultricies sit amet lacus ac tempor. Morbi dapibus elit in magna sodales, sed condimentum libero scelerisque. Donec sit amet sapien pharetra, aliquam augue ac, feugiat ex. Donec sed erat sem. Curabitur consequat finibus vestibulum. Duis vel feugiat nisi. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Fusce sit amet aliquet nisl, ac iaculis ex. Nullam elementum quis elit et eleifend. Fusce in maximus neque.", DateTime = new DateTime(2021,11,25,01,00,00)} },
            { 6, new Post() { Id = 6, IsRead = false, IdUserPost = 0, PopularityScore = 1, Reactions = new() { {2, Post.Reaction.Sad } }, SourcePost="/Assets/Posts/post7.jpg", GiveAccess= Post.Access.FriendsExcept, IdUserAccess = {2}, Title= "Sweden 2018", Description = "Donec venenatis aliquet lectus, a tempor ex convallis vel. Mauris eros eros, iaculis non volutpat id, pulvinar ac sapien. In auctor, orci blandit accumsan tristique, quam ipsum tempor ante, sed condimentum nunc lectus non massa. Nunc fermentum nunc ipsum, nec lacinia dolor rhoncus id. Maecenas faucibus nisi nec massa vulputate ornare. Nulla ac sem vel augue accumsan placerat quis vitae ante. Morbi ornare justo mollis libero laoreet, in efficitur orci tristique. Proin nec consequat sem, in maximus augue. Proin vitae nunc eu felis cursus interdum.", DateTime = new DateTime(2021,11,26,09,00,00)} },
            { 7, new Post() { Id = 7, IsRead = false, IdUserPost = 0, PopularityScore = 0, SourcePost="/Assets/Posts/post8.jpg", GiveAccess= Post.Access.SpecificFriends, IdUserAccess = {2}, Title= "Internet cafe Sundays", Description = "In ullamcorper pulvinar ex eget fringilla. Ut luctus sed ante vitae posuere. Quisque quis tortor pharetra, tincidunt risus nec, tincidunt dui. Phasellus sagittis sollicitudin tellus. Morbi volutpat tristique dapibus. Ut ut felis facilisis, scelerisque sem sit amet, ultrices felis. Cras rhoncus diam ac leo mattis tristique. Sed vel vestibulum eros. Fusce at iaculis arcu, et porttitor eros.", DateTime = new DateTime(2021,11,27,11,30,00)} },
            { 8, new Post() { Id = 8, IsRead = false, IdUserPost = 1, PopularityScore = 6, Reactions = new() { {1, Post.Reaction.Like }, {2, Post.Reaction.Like } }, SourcePost="/Assets/Posts/post9.jpg", GiveAccess= Post.Access.FriendsOnly, Title= "Surprise!", Description = "Duis quis sapien ex. Nam in est eget nisi ultricies scelerisque nec vitae metus. Aenean pulvinar ut dui et rhoncus. Nam dolor ipsum, vulputate in sapien nec, pellentesque feugiat nulla. Proin aliquet tempus tincidunt. Phasellus id faucibus velit. Nullam non nisi lectus. Praesent in arcu eget urna aliquet egestas eu eget nibh. Sed bibendum eget magna id pretium.", DateTime = new DateTime(2021,11,28,14,30,00)} },
            { 9, new Post() { Id = 9, IsRead = false, IdUserPost = 1, PopularityScore = 1, Reactions = new() { {1, Post.Reaction.Sad } }, SourcePost="/Assets/Posts/post10.jpg", GiveAccess= Post.Access.OnlyMe, Title= "Secret painting", Description = "Cras sit amet dictum arcu, sit amet tempus ante. Aliquam nisi augue, pharetra nec erat vitae, aliquam fermentum arcu. Duis viverra arcu ac magna cursus bibendum. Etiam laoreet semper felis, tincidunt tristique lorem placerat vel. Nam leo nisl, tempor ut facilisis fermentum, maximus at odio. Donec et laoreet sem, non mattis sem. Sed accumsan at sem non egestas. Donec ultricies libero ultricies tellus euismod, eu sollicitudin nisl dictum. Quisque non consequat purus, sit amet dignissim justo. Ut placerat dolor vel tellus viverra, malesuada tempus ante sodales. Nullam dignissim at nulla vel volutpat. Phasellus egestas ultrices scelerisque. Integer tellus enim, convallis ut elit vel, pretium facilisis orci. Mauris fringilla velit metus, sed gravida elit blandit at.", DateTime = new DateTime(2021,11,29,17,30,00)} },
            };
            public Dictionary<int, Sticker> stickers = new()
            {
            { 0, new Sticker() { SourceSticker = "/Assets/Icons/angry.png"} },
            { 1, new Sticker() { SourceSticker = "/Assets/Icons/like.png"} },
            { 2, new Sticker() { SourceSticker = "/Assets/Icons/love.png"} },
            { 3, new Sticker() { SourceSticker = "/Assets/Icons/sad.png"} },
            };
    }
}
