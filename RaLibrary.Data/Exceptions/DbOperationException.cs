﻿using System;

namespace RaLibrary.Data.Exceptions
{
    public class DbOperationException : Exception
    {
        private const string msg = "An error occurred when operating database.";

        public DbOperationException() : base(msg) { }

        public DbOperationException(string message) : base(message) { }
    }
}