﻿namespace WelcomeToTurkeyAPI.Dtos.CommentDtos
{
    public class AddNewCommentDto
    {
        public int UserId { get; set; }
        public int BlogId { get; set; }
        public string Message { get; set; }
    }
}
