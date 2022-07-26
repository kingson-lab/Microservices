﻿using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using NoteService.Models;

namespace NoteService.Repository
{
    public class NoteRepository : INoteRepository
    {
        //define a private variable to represent NoteContext
        public NoteRepository(NoteContext _context)
        {
        }

        //This method should be used to create a new note. NoteId should be autogenerated and
        // must start with 101.This should create a new NotUser if not exists else should push 
        //new note entry into existing NoteUser collection. UserId is identified by CreatedBy
        public bool CreateNote(Note note)
        {
            throw new NotImplementedException();
        }

        //This method should be used to retreive all notes for a user
        public List<Note> FindAllNotesByUser(string userId)
        {
            throw new NotImplementedException();
        }

        //This method should be used to delete a note for a specific user
        public bool DeleteNote(string userId, int noteId)
        {
            throw new NotImplementedException();
        }

        //This method is used to update an existing note for a user
        public bool UpdateNote(int noteId, string userId, Note note)
        {
            throw new NotImplementedException();
        }
    }
}
