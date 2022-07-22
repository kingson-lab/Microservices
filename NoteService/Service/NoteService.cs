using System;
using System.Collections.Generic;
using NoteService.Exceptions;
using NoteService.Models;
using NoteService.Repository;

namespace NoteService.Service
{
    public class NoteService : INoteService
    {
        //define a private variable to represent repository

        //Use constructor Injection to inject all required dependencies.

        public NoteService(INoteRepository _noteRepository)
        {

        }
        
        //This method should be used to create a new note.
        public bool CreateNote(Note note)
        {
            throw new NotImplementedException();
        }

        //This method should be used to delete an existing note for a user
        public bool DeleteNote(string userId, int noteId)
        {
            throw new NotImplementedException();
        }

        //This methos is used to retreive all notes for a user
        public List<Note> GetAllNotesByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        //This method is used to update an existing note for a user
        public Note UpdateNote(int noteId, string userId, Note note)
        {
            throw new NotImplementedException();
        }
        
    }
}
