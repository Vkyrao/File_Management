using DAL.EntityFramework;

using Domain.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace Services.Repository

{

    public class FilesCommentRepository : IFilesCommentRepository

    {

        private readonly FileManagementContext _context;

        public FilesCommentRepository(FileManagementContext context)

        {

            _context = context;

        }

        public void DeleteFilesComment(int id)

        {

            FilesComment filesComment = GetFilesComment(id);

            if (filesComment != null)

            {

                _context.FilesComment.Remove(filesComment);

                _context.SaveChanges();

            }

        }

        public FilesComment GetFilesComment(int id)

        {

            return _context.FilesComment.Find(id) ?? throw new InvalidOperationException($"FilesComment with id {id} not found.");

        }

        public List<FilesComment> GetFilesComments()

        {

            List<FilesComment> filesComments = new List<FilesComment>();

            filesComments = _context.FilesComment.ToList();

            return filesComments;

        }

        public void InsertFilesComment(FilesComment filesComment)

        {

            _context.FilesComment.Add(filesComment);

            _context.SaveChanges();

        }

        public void UpdateFilesComment(FilesComment filesComment)

        {

            _context.FilesComment.Update(filesComment);

            _context.SaveChanges();

        }

    }

}
