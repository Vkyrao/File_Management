using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.EntityFramework;

using Domain.Models;

namespace Services.Repository

{

    public class FileTypeRepository : IFileTypeRepository

    {

        private FileManagementContext _context;

        public FileTypeRepository(FileManagementContext context)

        {

            _context = context;

        }

        public FileType GetFileType(int id)

        {

            return _context.FileType.Find(id) ?? throw new InvalidOperationException($"FileType with id {id} not found.");

        }

        public List<FileType> GetFileTypes()

        {

            return _context.FileType.ToList();

        }

    }

}

