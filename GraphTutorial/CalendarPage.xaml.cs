// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.Graph;
using Microsoft.Toolkit.Graph.Providers;
using Microsoft.Toolkit.Uwp.UI.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GraphTutorial
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CalendarPage : Page
    {
        public CalendarPage()
        {
            this.InitializeComponent();
        }

        private void ShowNotification(string message)
        {
            // Get the main page that contains the InAppNotification
            var mainPage = (Window.Current.Content as Frame).Content as MainPage;

            // Get the notification control
            var notification = mainPage.FindName("Notification") as InAppNotification;

            notification.Show(message);
        }

        // OnNavigatedTo
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            // Get the Graph client from the provider
            var graphClient = ProviderManager.Instance.GlobalProvider.Graph;

           
            // Get the user's mailbox settings to determine
            // their time zone  
            // !!! RnD !!!
            User user = await graphClient.Me.Request()
                .Select(u => new { u.Devices }) // // { u.MailboxSettings }
                .GetAsync();
                

            // var init
            DateTime startOfWeek = DateTime.Today;

            try
            {
                                                                        //user.MailboxSettings.TimeZone);
                startOfWeek = GetUtcStartOfWeekInTimeZone(DateTime.Today, "Pacific Standard Time"); 
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[ex] Exception (GetUtcStartOfWeekInTimeZone): " + ex.Message);
                    
                // Plan B
                startOfWeek = DateTime.Today;
            }

            DateTime endOfWeek = startOfWeek.AddDays(7);

            List<QueryOption> queryOptions = new List<QueryOption>
            {
                new QueryOption("startDateTime", startOfWeek.ToString("o")),
                new QueryOption("endDateTime", endOfWeek.ToString("o"))
            };

            // Get the events
            IUserCalendarViewCollectionPage events = null;
            try
            {
            // !!! RnD !!!
                events = await graphClient.Me.CalendarView.Request(queryOptions)
                    .Header("Prefer", $"outlook.timezone=\"Pacific Standard Time\"") // \"{user.MailboxSettings.TimeZone}\
                    .Select(ev => new
                    {
                        ev.Subject,
                        ev.Organizer,
                        ev.Start,
                        ev.End
                    })
                    .OrderBy("start/dateTime")
                    .Top(50)
                    .GetAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[ex] Exception (IUserCalendarViewCollectionPage) : " + ex.Message);
            }

            // init
            EventList.ItemsSource = null;

            if (events != null)
            {
                EventList.ItemsSource = events.CurrentPage.ToList();
            }            

            base.OnNavigatedTo(e);

        }//OnNavigatedTo


        // GetUtcStartOfWeekInTimeZone
        private static DateTime GetUtcStartOfWeekInTimeZone(DateTime today, string timeZoneId)
        {
            TimeZoneInfo userTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            // Assumes Sunday as first day of week
            int diff = System.DayOfWeek.Sunday - today.DayOfWeek;

            // create date as unspecified kind
            DateTime unspecifiedStart = DateTime.SpecifyKind(today.AddDays(diff), DateTimeKind.Unspecified);

            // convert to UTC
            return TimeZoneInfo.ConvertTimeToUtc(unspecifiedStart, userTimeZone);

        }//GetUtcStartOfWeekInTimeZone
    }
}
