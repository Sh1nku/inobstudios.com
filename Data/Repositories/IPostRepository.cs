﻿using iNOBStudios.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iNOBStudios.Data.Repositories {
    public interface IPostRepository {
        public IEnumerable<Post> GetPosts(bool track = false, string[] info = null);
        public Post GetPostByPostId(int postId, bool track = false, string[] info = null);
        public IEnumerable<PostVersion> GetPostVersionsByPostId(int postId, bool track = false, string[] info = null);

        public Post CreatePost(Post post);
    }
}
