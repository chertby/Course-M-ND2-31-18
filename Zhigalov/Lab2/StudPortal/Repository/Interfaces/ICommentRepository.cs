﻿using RepositoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ICommentRepository : IRepository<CommentEntity>
    {
        void Edit(CommentEntity comment);
    }
}
