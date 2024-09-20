using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IFilesSharedRepository
    {
        FilesShared GetFilesShared(int id);

        List<FilesShared> GetFilesShareds();

        void InsertFilesShared(FilesShared filesShared);

        void UpdateFilesShared(FilesShared filesShared);

        void DeleteFilesShared(int id);
    }
}
