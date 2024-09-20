using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Models;

namespace Services.Repository
{
    public interface IFileTypeRepository
    {
        FileType GetFileType(int id);

        List<FileType> GetFileTypes();
    }
}
