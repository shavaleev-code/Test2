using Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;

namespace Client.Controls
{
    public partial class MainUserControl : UserControl
    {
        private ObservableCollection<Message> MessageList;

        public MainUserControl()
        {
            InitializeComponent();
            MessageList = new ObservableCollection<Message>();
            GetMessages();
            
        }

        //Сортирует записи по времени
        private void DateColumnHeader_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.ItemsSource = MessageList.OrderBy(x => x.Time);
        }

        //Сортирует записи по именам
        private void UserColumnHeader_OnClick(object sender, RoutedEventArgs e)
        {            
            ListView.ItemsSource = MessageList.OrderBy(x => x.UserName);
        }

        //Отправляет сообщения на сервер и отображает в таблице
        private void SendMessages(object sender, RoutedEventArgs e)
        {           
            if(Message.Text == string.Empty || UserName.Text == string.Empty)
            {
                return;
            }

            try
            {
                var clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                var client = new HttpClient(clientHandler);
                var requestUrl = $"https://localhost:5001/Message/Create";
                var message = new Message { Time = DateTime.Now, Text = Message.Text, UserName = UserName.Text};
                MessageList.Add(message);
                ListView.ItemsSource = MessageList;
                var response = client.PostAsync(requestUrl, new StringContent(JsonConvert.SerializeObject(message), Encoding.UTF8, "application/json"));             
            }
            catch (Exception ex)
            {
                
            }
        }

        //Запрашивает сообщения из бд и отображает в таблице
        private void GetMessages()
        {
            try
            {
                var clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                var client = new HttpClient(clientHandler);
                var requestUrl = $"https://localhost:5001/Message/Get";
                var messages = client.GetAsync(requestUrl).Result.Content.ReadAsStringAsync().Result;
                
                MessageList = JsonConvert.DeserializeObject<ObservableCollection<Message>>(messages);
                ListView.ItemsSource = MessageList;
            }
            catch (Exception e)
            {
               
            }
        }

        //Отображает сообщения, которые находятся в нужных временных рамках
        private void DateCheck_Click(object sender, RoutedEventArgs e)
        {
            if((bool)DateCheck.IsChecked == false)
            {
                ListView.ItemsSource = MessageList;
                return;
            }

            if(StartDate.Text == string.Empty || EndDate.Text == string.Empty)
            {
                return;
            }

            try 
            {
                var messages = new ObservableCollection<Message>(MessageList.Where(x => IsValidDate(x.Time, StartDate.Text, EndDate.Text)));
                ListView.ItemsSource = messages;
            }
            catch(Exception ex)
            {

            }
            
        }

        //Проверка даты, находится ли она в нужных временных рамках
        private bool IsValidDate(DateTime date, string startDate, string endDate)
        {
            var start = DateTime.ParseExact(startDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var end = DateTime.ParseExact(endDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var compareWithStartDate = DateTime.Compare(start, date);
            var compareWithEndDate = DateTime.Compare(date, end);
            if (compareWithStartDate < 0 && compareWithEndDate < 0)
            {
                return true;
            }

            return false;
        }
    }
}
