using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IFilesCommentRepository
    {
        FilesComment GetFilesComment(int id);

        List<FilesComment> GetFilesComments();

        void InsertFilesComment(FilesComment filesComment);

        void UpdateFilesComment(FilesComment filesComment);

        void DeleteFilesComment(int id);
    }
}
