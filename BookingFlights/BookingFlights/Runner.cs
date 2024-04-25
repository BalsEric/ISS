using System;
using System.Windows.Forms;
using BookingFlights.controllers;
using BookingFlights.Repository;
using Microsoft.EntityFrameworkCore;

namespace BookingFlights
{
    static class Runner
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var contextOptions = new DbContextOptionsBuilder<DBContext>()
                .UseSqlite("Data Source=C:\\Eric\\flights.db").Options;

            var context = new DBContext(contextOptions);
            Service.Service service = new Service.Service(context);
            ApplicationConfiguration.Initialize();
            LogInController logInController = new LogInController(service);
            Application.Run(new LogIn(logInController));
        }
    }
}