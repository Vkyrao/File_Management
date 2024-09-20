using DAL.EntityFramework;

using Domain.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Services.Repository

{

    public class FilesSharedRepository : IFilesSharedRepository

    {

        private readonly FileManagementContext _context;

        public FilesSharedRepository(FileManagementContext context)

        {

            _context = context;

        }

        public void DeleteFilesShared(int id)

        {

            FilesShared filesShared = GetFilesShared(id);

            if (filesShared != null)

            {

                _context.FilesShared.Remove(filesShared);

                _context.SaveChanges();

            }

        }

        public FilesShared GetFilesShared(int id)

        {

            return _context.FilesShared.Find(id) ?? throw new InvalidOperationException($"FilesShared with id {id} not found.");

        }

        public List<FilesShared> GetFilesShareds()

        {

            List<FilesShared> filesShareds = new List<FilesShared>();

            filesShareds = _context.FilesShared.ToList();

            return filesShareds;

        }

        public void InsertFilesShared(FilesShared filesShared)

        {

            _context.FilesShared.Add(filesShared);

            _context.SaveChanges();

        }

        public void UpdateFilesShared(FilesShared filesShared)

        {

            _context.FilesShared.Update(filesShared);

            _context.SaveChanges();

        }

    }

}

