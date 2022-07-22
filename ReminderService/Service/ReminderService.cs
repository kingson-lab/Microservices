using System;
using System.Collections.Generic;
using System.Linq;
using ReminderService.Exceptions;
using ReminderService.Models;
using ReminderService.Repository;

namespace ReminderService.Service
{
    public class ReminderService : IReminderService
    {
        //define a private variable to represent repository

        //Use constructor Injection to inject all required dependencies.

        public ReminderService(IReminderRepository reminderRepository)
        {

        }

        //This method should be used to save a new reminder.
        public Reminder CreateReminder(Reminder reminder)
        {
            throw new NotImplementedException();
        }
        //This method should be used to delete an existing reminder.
        public bool DeleteReminder(int reminderId)
        {
            throw new NotImplementedException();
        }
        // This method should be used to get all reminders by userId
        public List<Reminder> GetAllRemindersByUserId(string userId)
        {
            throw new NotImplementedException();
        }
        //This method should be used to get a reminder by reminderId.
        public Reminder GetReminderById(int reminderId)
        {
            throw new NotImplementedException();
        }
        //This method should be used to update an existing reminder.
        public bool UpdateReminder(int reminderId, Reminder reminder)
        {
            throw new NotImplementedException();
        }
    }
}
