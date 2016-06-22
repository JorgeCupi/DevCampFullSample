using Newtonsoft.Json;
using RESTSampleOne.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;

namespace RESTSampleOne.ViewModel
{
    class UserPageViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
        }

        public UserPageViewModel()
        {
            Users = new ObservableCollection<User>();
            GetUsers();
        }

        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }



        public async void GetUsers()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(
                "http://jsonplaceholder.typicode.com/Users");
            List<User> tempList = JsonConvert.DeserializeObject
                <List<User>>(result);

            foreach (User item in tempList)
            {
                Users.Add(item);
            }
        }
    }
}
