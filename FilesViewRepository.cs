using DAL.EntityFramework;

using Domain.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Services.Repository

{

    public class FilesViewRepository : IFilesViewRepository

    {

        private readonly FileManagementContext _context;

        public FilesViewRepository(FileManagementContext context)

        {

            _context = context;

        }

        public void DeleteFilesView(int id)

        {

            FilesView filesView = GetFilesView(id);

            if (filesView != null)

            {

                _context.FilesView.Remove(filesView);

                _context.SaveChanges();

            }

        }

        public FilesView GetFilesView(int id)

        {

            return _context.FilesView.Find(id) ?? throw new InvalidOperationException($"FilesView with id {id} not found.");

        }

        public List<FilesView> GetFilesViews()

        {

            List<FilesView> filesViews = new List<FilesView>();

            filesViews = _context.FilesView.ToList();

            return filesViews;

        }

        public void InsertFilesView(FilesView filesView)

        {

            _context.FilesView.Add(filesView);

            _context.SaveChanges();

        }

        public void UpdateFilesView(FilesView filesView)

        {

            _context.FilesView.Update(filesView);

            _context.SaveChanges();

        }

    }

}

