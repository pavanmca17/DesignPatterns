﻿namespace GenericRepository.Models
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public T Value { get; set; }

    }
}